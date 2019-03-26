grammar CBlunt;

@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}
	
start
    : expression
    ;

expression
	: declaration (declaration)*
    | declaration
	;

declaration
    : types ID ('=' NUMBER)? ';'
    | types ID ('=' '"' STRING '"')? ';'
    ;

types
    : 'number'
    | 'string'
    | 'void'
    ;

NUMBER : '-'?[0-9]+('.'[0-9]+)? ;

//STRING : [a-zA-Z0-9]+;

ID : [a-zA-Z_][a-zA-Z_0-9]* ;


DIGIT: [0-9]+;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines