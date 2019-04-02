grammar CBlunt;

@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}
	
start
    : (function | declaration)* // this will only be used if "int Main" HAS to be the first function declared. note that of course it is possible to declare and assign after main has been declared
    ;
	
block : '{' statement* '}' ;
	
function
	: functiontype ID '(' ((variabletype ID ',')* variabletype ID)? ')' block
	;

statement
	: (((declaration | functioncall | variableedit) ';') | iterative | selective) comment?
	;
	
functioncall
	: ID '(' ((parameter ',')* parameter)? ')'
	;
	
iterative
	: 'while' '(' condition ')' block
	| 'for' '(' declaration ';' condition ';' expression ')' block //expression might need to be replaced
	;
	
selective   
	: 'if' '(' condition ')' block else?
	;
	
else : 'else' (block | selective) ;

declaration
    : variabletype ID ('=' expression)?
    ;

variableedit      
	: ID equals expression
	;
	
expression
	: expression (('+' | '-' | '*' | '/') expression)+
	| '(' expression ')'
	| parameter
	;
	
condition
	: '!'? ( logic | ID ) (conditional condition)*
	;
	
logic
	: ( expression relational expression )
	;
	
relational
	: '==' | '>=' | '<=' | '>' | '<' | '!='
	;
	
conditional
	: '||' | '&&' 
	;

variabletype
    : 'number'
    | 'text'
	| 'bool'
    ;
	
functiontype
	: variabletype
	| 'void'
	;

parameter
	: STRING
	| NUMBER
	| TRUTH
	| ID
	| functioncall
	;

ID : [a-zA-Z_][a-zA-Z_0-9]* ;

NUMBER : '-'?[0-9]+('.'[0-9]+)? ;

STRING : '"' (~'"' | '\\''"')* '"';

TRUTH : 'true' | 'false' ;

DIGIT: [0-9]+;

comment
	: '/' '/' (~'\n')* '\n'
	| '/*' (~'*/')* '*/'
	;
	
equals : '=' | '+=' | '-=' | '*=' | '/=';

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines