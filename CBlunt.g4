grammar CBlunt;

@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}
	
start
    : 'void' 'Main' '(' ')' '{' statements? '}' (function | declaration)* // this will only be used if "int Main" HAS to be the first function declared. note that of course it is possible to declare and assign after main has been declared
    ;
	
function
	: type ID '(' (type ID (',' type ID)*)? ')' '{' statements? '}'
	;

statements
	: statement statements
	| statement
	;

statement
	: (declaration | functioncall) ';'
	;
	
idcall
	: ID
	| ID '[' [0-9]+ ']'
	| ID '(' (parameter (',' parameter)*)? ')'
	;

iterative
	: 'while' '(' condition ')' '{' statement '}'
	| 'for' '(' declaration ';' condition ';' expression ')' '{' statement '}' \\expression might need to be replaced
	;
	
selective   
	: 'if' '(' condition ')' '{' statement '}'
	;

declaration
    : type ID ('=' expression)?
    | type 'array' ID ('=' '{' ( expression ',')* expression  '}' )?
    ;
	
expression
	: expression ('*' | '/') expression
	| expression ('+' | '-') expression
	| '(' expression ')'
	| parameter
	| idcall
	;
	
condition
	: (expression logic expression | ID) (logic condition)*
	;
	
logic
	: ('==' | '>=' | '<=' | '>' | '<' | '!=' | '||' | '^^' | '&&')
	;

type
    : 'number'
    | 'string'
	| 'bool'
    | 'void'
    ;

parameter
	: ID
	| STRING
	| NUMBER
	;

NUMBER : '-'?[0-9]+('.'[0-9]+)? ;

STRING : '"' (~('"' | '\\' | '\r' | '\n') | '\\' ('"' | '\\'))* '"';

ID : [a-zA-Z_][a-zA-Z_0-9]* ;

DIGIT: [0-9]+;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines