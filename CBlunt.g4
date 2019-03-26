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

identifier
    : ID
    ;

declaration
    : types identifier ('=' NUMBER)? ';'
    | types identifier ('=' '"' ID '"')? ';'
    ;

types
    : 'number'
    | 'string'
    | 'void'
    ;

NUMBER : '-'?[0-9]+('.'[0-9]+)? ;

STRING : [a-zA-Z_][a-zA-Z_][0-9]* ;

ID : [a-zA-Z_][a-zA-Z_0-9]* ;
	
/*
local_variable_declaration
	: local_variable_declarator
	;

local_variable_type 
	: VAR
	;
	
local_variable_declarator
	: identifier ('=' local_variable_initializer)?
	;
	
local_variable_initializer
	: expression
	;
	
expression
	: assignment
	;

assignment
	: unary_expression assignment_operator expression
	;

unary_expression
	: '+' unary_expression
	| '-' unary_expression
	| BANG unary_expression
	| '~' unary_expression
	| '++' unary_expression
	| '--' unary_expression
	| OPEN_PARENS type CLOSE_PARENS unary_expression
	| AWAIT unary_expression // C# 5
	| '&' unary_expression
	| '*' unary_expression
	;

assignment_operator
	: '=' | '+=' | '-=' | '*=' | '/=' | '%=' | '&=' | '|=' | '^=' | '<<='
	;

type 
	: base_type ('?' | rank_specifier | '*')*
	;

base_type
	: simple_type
	| class_type  // represents types: enum, class, interface, delegate, type_parameter
	| VOID '*'
	;

simple_type 
	: numeric_type
	| BOOL
	;

numeric_type 
	: integral_type
	| floating_point_type
	| DECIMAL
	;

integral_type 
	: SBYTE
	| BYTE
	| SHORT
	| USHORT
	| INT
	| UINT
	| LONG
	| ULONG
	| CHAR
	;

floating_point_type 
	: FLOAT
	| DOUBLE
	;

class_type 
	: namespace_or_type_name
	| OBJECT
	| DYNAMIC
	| STRING
	;
*/

DIGIT: [0-9]+;
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines