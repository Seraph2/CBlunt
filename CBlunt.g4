grammar CBlunt;

@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}
	
start
    : 'Main' '(' ')' '{' statement '}' function*
    ;
	
function
	: type ID '(' ((DATATYPE ID ',')* DATATYPE ID)? ')' '{' statement '}'
	;

statement
	: (((declaration | fcall)  ';') | iterative | selective)* \\Why use many words when few word do trick
	;
	
fcall
	: ID '(' (Parameter ',')* Parameter ')'
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
    | type 'array' ID ('=' '{' (expression ',')* '}' )?
    ;
	
expression
	: expression ('*' | '/') expression
	| expression ('+' | '-') expression
	| '(' expression ')'
	| Parameter
	| fcall
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

Parameter	: ID
			| STRING
			| NUMBER


//https://stackoverflow.com/questions/29800106/how-do-i-escape-an-escape-character-with-antlr-4


NUMBER : '-'?[0-9]+('.'[0-9]+)? ;

STRING : '"' (~('"' | '\\' | '\r' | '\n') | '\\' ('"' | '\\'))* '"';

ID : [a-zA-Z_][a-zA-Z_0-9]* ;

DIGIT: [0-9]+;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines