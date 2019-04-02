grammar CBlunt;

@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}
	
start
    : (function | declaration)* // this will only be used if "int Main" HAS to be the first function declared. note that of course it is possible to declare and assign after main has been declared
    ;
	
function
	: functionvariabletype ID '(' (variabletype ID (',' variabletype ID)*)? ')' block
	;

block
	: '{' statement*? '}'
	;

statement
	: (((declaration | functioncall | variableedit) ';') | iterative	| selective)
	;
	
functioncall
	: ID '(' (parameter (',' parameter)*)? ')'
	;

iterative
	: 'while' '(' condition ')' block
	| 'for' '(' declaration ';' condition ';' expression ')' block //expression might need to be replaced
	;
	
selective   
	: 'if' '(' condition ')' block elsestmt?
	;

elsestmt
	: 'else' (block |selective)
	;

declaration
    : variabletype ID ('=' expression)?
    ;

variableedit
	: ID equals expression
	;
	
expression
	: expression (('+' | '-' | '*' | '/')) //expression)* // Error
	| '(' expression ')'
	| parameter
	;
	
condition
	: '!'?(expression logic expression | ID) (logic condition)*
	;

logic : (expression relational expression) (relational expression)* ;
	
relational
	: '=='
	| '>='
	| '<='
	| '>'
	| '<'
	| '!='
	;

conditional
	: '||' 
	| '&&' 
	| 'or'
	| 'and' ;

variabletype
    : 'number'
    | 'text'
	| 'bool'
    ;

functionvariabletype
	: variabletype
	| 'void'
    ;

parameter
	: STRING
	| NUMBER
	| ID
	| functioncall
	;

ID : [a-zA-Z_][a-zA-Z_0-9]* ;

NUMBER : '-'?[0-9]+('.'[0-9]+)? ;

STRING : '"' (~('"' | '\\' | '\r' | '\n') | '\\' ('"' | '\\'))* '"';

DIGIT: [0-9]+;

comment
	: '/' '/' .*? '\n'
	| '/' '*' .*? '*' '/'
	;

equals
	: '='
	| '+='
	| '-='
	| '*='
	| '/='
	;

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines