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
    : types ('array')? ID ('=' NUMBER)? ';'
    | types ('array')? ID ('=' STRING)? ';'
    ;

types
    : 'number'
    | 'string'
    | 'void'
    ;


//https://stackoverflow.com/questions/29800106/how-do-i-escape-an-escape-character-with-antlr-4


NUMBER : '-'?[0-9]+('.'[0-9]+)? ;

STRING : '"' (~('"' | '\\' | '\r' | '\n') | '\\' ('"' | '\\'))* '"';

ID : [a-zA-Z_][a-zA-Z_0-9]* ;


DIGIT: [0-9]+;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines