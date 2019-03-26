grammar Calculator;
start	: expression;
expression	: term ('+' term)*
			| term ('-' term)*;
			
term: exp ('*' exp)*
	| exp ('/' exp)*;
	
exp	: DIGIT
	| LPAREN expression RPAREN ;

//operand: DIGIT | LPAREN operand (OPERATOR operand)+ RPAREN;

LPAREN: '(';
RPAREN: ')';

//OPERATOR1: MULTIPLY | DIVIDE ;
//OPERATOR2: ADD | SUBTRACT ;

//ADD: DIGIT '+' DIGIT | '+' DIGIT;
//SUBTRACT: DIGIT '-' DIGIT | '-' DIGIT;
//MULTIPLY: DIGIT '*' DIGIT | '*' DIGIT;
//DIVIDE: DIGIT '/' DIGIT | '/' DIGIT;

DIGIT: [0-9]+;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines