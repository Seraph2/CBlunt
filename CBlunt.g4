grammar CBlunt;

@parser::header {#pragma warning disable 3021}
@lexer::header {#pragma warning disable 3021}

start	: expression;
expression	: term ('+' term)*
			| term ('-' term)*;
			
term: exp ('*' exp)*
	| exp ('/' exp)*;
	
exp	: DIGIT
	| LPAREN expression RPAREN ;

LPAREN: '(';
RPAREN: ')';

DIGIT: [0-9]+;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines