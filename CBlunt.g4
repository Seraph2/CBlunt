grammar CBlunt;

@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}

start
    : (function | declaration ';')+
    ;

block : '{' (statement)* '}' ;

function
	: functiontype ID '(' ((variabletype ID ',')* variabletype ID)? ')' block
	;

statement
	: (((declaration | functioncall | variableedit | functionreturn) ';') | iterative | selective)
	;

functioncall
	: ID '(' ((parameter ',')* parameter)? ')'
	;

iterative
	: 'while' '(' condition ')' block
	| 'for' '(' (declaration | variableedit) ';' condition ';' variableedit ')' block
	;

selective
	: 'if' '(' condition ')' block elsestmt?
	;

elsestmt
	: 'else' (block | selective)
	;

declaration
    : variabletype ID ('=' expression)?
    ;

variableedit
	: ID equals expression
	;

expression
	: parameter calculation*
	| parameter
	;

calculation
	: operator parameter
	| operator '(' expression ')'
	;

condition
	: '!'? (logic | ID) (conditional condition)*
	;

logic
	: (expression relational expression)
	;


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
	| 'and'
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
	| truth
	| ID
	| functioncall
	;

functionreturn
	: 'return' expression
	;

ID : [a-zA-Z_][a-zA-Z_0-9]* ;

NUMBER : '-'?[0-9]+('.'[0-9]+)? ;

STRING : '"' (~'"' | '\\''"')* '"';

truth
	: 'true'
	| 'false'
	;

DIGIT: [0-9]+;

equals
	: operator? '='
	;

LINECOMMENT
	: '//' ~[\r\n]* -> skip
	;

COMMENT
	: '/*' .*? '*/' -> skip
	;

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines

operator
    : '+'
    | '-'
    | '*'
    | '/'
    ;