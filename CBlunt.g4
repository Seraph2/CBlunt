grammar CBlunt;

@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}

start
    : (function | declaration ';')+ // Global scope
    ;

block : '{' (statement)* '}' ; // { ... }

function
	: functiontype ID '(' ((variabletype ID ',')* variabletype ID)? ')' block // void F(number a) { ... }
	;

statement
	: (((declaration | functioncall | variableedit | functionreturn) ';') | iterative | selective)
	;

functioncall
	: ID '(' ((expression ',')* expression)? ')' // F(123,"test",false, 12 + 34);
	;

iterative
	: 'while' '(' condition ')' block // while (2 > 1) { ... }
	| 'for' '(' (declaration | variableedit) ';' condition ';' variableedit ')' block // Init, condition, post-block
	;

selective
	: 'if' '(' condition ')' block elsestmt? // Else is not required but can be used
	;

elsestmt
	: 'else' (block | selective) // Leads to a block or another if (that is technically another block)
	;

declaration
    : variabletype ID ('=' expression)? // text a = "hello";
    ;

variableedit
	: ID equals expression // a = "edited";
	;

expression
	: parameter calculation* // 1 + 2 + 3 + (5 + 2)
	;

calculation
	: operator (parameter | '(' expression ')') // 5 + 2 + 5 + 7 + (1231231 - 5)
	;

condition
	: (logic | truth | ID) (conditional condition)* // if (5 > 2), if (true), if(b)
	| '!' ('(' logic ')' | truth | ID) (conditional condition)* // if(!(5 > 2)), if(!false), if(!b)
	;

logic
	: expression relational expression // 1 + 2 >= 12 + 87 + 12
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

functionreturn // return "test"
	: 'return' expression?
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

WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, and newlines

operator
    : '+'
    | '-'
    | '*'
    | '/'
    ;