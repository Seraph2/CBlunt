//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CBlunt.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CBlunt.ANTLR.AutoGeneratedParser {
#pragma warning disable 3021
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class CBluntLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
<<<<<<< HEAD
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NUMBER=7, STRING=8, ID=9, 
		DIGIT=10, WS=11;
=======
		NUMBER=1, ID=2, SEMICOLON=3, DIGIT=4, WS=5;
>>>>>>> test-antlr
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
<<<<<<< HEAD
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "NUMBER", "STRING", "ID", 
		"DIGIT", "WS"
=======
		"NUMBER", "ID", "SEMICOLON", "DIGIT", "WS"
>>>>>>> test-antlr
	};


	public CBluntLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CBluntLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
<<<<<<< HEAD
		null, "'='", "';'", "'\"'", "'number'", "'string'", "'void'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "NUMBER", "STRING", "ID", "DIGIT", 
		"WS"
=======
		null, null, null, "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUMBER", "ID", "SEMICOLON", "DIGIT", "WS"
>>>>>>> test-antlr
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CBlunt.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CBluntLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
<<<<<<< HEAD
		'\x5964', '\x2', '\r', ']', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', 
		'\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', 
		'\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', 
		'\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', 
		'\v', '\x4', '\f', '\t', '\f', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x5', '\b', '\x34', '\n', '\b', '\x3', 
		'\b', '\x6', '\b', '\x37', '\n', '\b', '\r', '\b', '\xE', '\b', '\x38', 
		'\x3', '\b', '\x3', '\b', '\x6', '\b', '=', '\n', '\b', '\r', '\b', '\xE', 
		'\b', '>', '\x5', '\b', '\x41', '\n', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\a', '\t', '\x46', '\n', '\t', '\f', '\t', '\xE', '\t', 
		'I', '\v', '\t', '\x3', '\n', '\x3', '\n', '\a', '\n', 'M', '\n', '\n', 
		'\f', '\n', '\xE', '\n', 'P', '\v', '\n', '\x3', '\v', '\x6', '\v', 'S', 
		'\n', '\v', '\r', '\v', '\xE', '\v', 'T', '\x3', '\f', '\x6', '\f', 'X', 
		'\n', '\f', '\r', '\f', '\xE', '\f', 'Y', '\x3', '\f', '\x3', '\f', '\x2', 
		'\x2', '\r', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', 
		'\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', 
		'\x17', '\r', '\x3', '\x2', '\x6', '\x3', '\x2', '\x32', ';', '\x5', '\x2', 
		'\x43', '\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', '\x32', ';', 
		'\x43', '\\', '\x61', '\x61', '\x63', '|', '\x5', '\x2', '\v', '\f', '\xF', 
		'\xF', '\"', '\"', '\x2', '\x64', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x3', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x5', '\x1B', '\x3', '\x2', '\x2', '\x2', '\a', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\t', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\v', '&', '\x3', '\x2', '\x2', '\x2', '\r', '-', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\x33', '\x3', '\x2', '\x2', '\x2', '\x11', '\x42', 
		'\x3', '\x2', '\x2', '\x2', '\x13', 'J', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'R', '\x3', '\x2', '\x2', '\x2', '\x17', 'W', '\x3', '\x2', '\x2', '\x2', 
		'\x19', '\x1A', '\a', '?', '\x2', '\x2', '\x1A', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', '\x1C', '\a', '=', '\x2', '\x2', '\x1C', '\x6', 
		'\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\a', '$', '\x2', '\x2', '\x1E', 
		'\b', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\a', 'p', '\x2', '\x2', 
		' ', '!', '\a', 'w', '\x2', '\x2', '!', '\"', '\a', 'o', '\x2', '\x2', 
		'\"', '#', '\a', '\x64', '\x2', '\x2', '#', '$', '\a', 'g', '\x2', '\x2', 
		'$', '%', '\a', 't', '\x2', '\x2', '%', '\n', '\x3', '\x2', '\x2', '\x2', 
		'&', '\'', '\a', 'u', '\x2', '\x2', '\'', '(', '\a', 'v', '\x2', '\x2', 
		'(', ')', '\a', 't', '\x2', '\x2', ')', '*', '\a', 'k', '\x2', '\x2', 
		'*', '+', '\a', 'p', '\x2', '\x2', '+', ',', '\a', 'i', '\x2', '\x2', 
		',', '\f', '\x3', '\x2', '\x2', '\x2', '-', '.', '\a', 'x', '\x2', '\x2', 
		'.', '/', '\a', 'q', '\x2', '\x2', '/', '\x30', '\a', 'k', '\x2', '\x2', 
		'\x30', '\x31', '\a', '\x66', '\x2', '\x2', '\x31', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '\x32', '\x34', '\a', '/', '\x2', '\x2', '\x33', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\x3', '\x2', '\x2', '\x2', 
		'\x34', '\x36', '\x3', '\x2', '\x2', '\x2', '\x35', '\x37', '\t', '\x2', 
		'\x2', '\x2', '\x36', '\x35', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', 
		'\x3', '\x2', '\x2', '\x2', '\x38', '\x36', '\x3', '\x2', '\x2', '\x2', 
		'\x38', '\x39', '\x3', '\x2', '\x2', '\x2', '\x39', '@', '\x3', '\x2', 
		'\x2', '\x2', ':', '<', '\a', '\x30', '\x2', '\x2', ';', '=', '\t', '\x2', 
		'\x2', '\x2', '<', ';', '\x3', '\x2', '\x2', '\x2', '=', '>', '\x3', '\x2', 
		'\x2', '\x2', '>', '<', '\x3', '\x2', '\x2', '\x2', '>', '?', '\x3', '\x2', 
		'\x2', '\x2', '?', '\x41', '\x3', '\x2', '\x2', '\x2', '@', ':', '\x3', 
		'\x2', '\x2', '\x2', '@', '\x41', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\t', '\x3', '\x2', 
		'\x2', '\x43', 'G', '\t', '\x3', '\x2', '\x2', '\x44', '\x46', '\t', '\x2', 
		'\x2', '\x2', '\x45', '\x44', '\x3', '\x2', '\x2', '\x2', '\x46', 'I', 
		'\x3', '\x2', '\x2', '\x2', 'G', '\x45', '\x3', '\x2', '\x2', '\x2', 'G', 
		'H', '\x3', '\x2', '\x2', '\x2', 'H', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'I', 'G', '\x3', '\x2', '\x2', '\x2', 'J', 'N', '\t', '\x3', '\x2', '\x2', 
		'K', 'M', '\t', '\x4', '\x2', '\x2', 'L', 'K', '\x3', '\x2', '\x2', '\x2', 
		'M', 'P', '\x3', '\x2', '\x2', '\x2', 'N', 'L', '\x3', '\x2', '\x2', '\x2', 
		'N', 'O', '\x3', '\x2', '\x2', '\x2', 'O', '\x14', '\x3', '\x2', '\x2', 
		'\x2', 'P', 'N', '\x3', '\x2', '\x2', '\x2', 'Q', 'S', '\t', '\x2', '\x2', 
		'\x2', 'R', 'Q', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x3', '\x2', '\x2', 
		'\x2', 'T', 'R', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\x3', '\x2', '\x2', 
		'\x2', 'U', '\x16', '\x3', '\x2', '\x2', '\x2', 'V', 'X', '\t', '\x5', 
		'\x2', '\x2', 'W', 'V', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\x3', '\x2', 
		'\x2', '\x2', 'Y', 'W', '\x3', '\x2', '\x2', '\x2', 'Y', 'Z', '\x3', '\x2', 
		'\x2', '\x2', 'Z', '[', '\x3', '\x2', '\x2', '\x2', '[', '\\', '\b', '\f', 
		'\x2', '\x2', '\\', '\x18', '\x3', '\x2', '\x2', '\x2', '\v', '\x2', '\x33', 
		'\x38', '>', '@', 'G', 'N', 'T', 'Y', '\x3', '\b', '\x2', '\x2',
=======
		'\x5964', '\x2', '\a', '\x32', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x3', '\x2', '\x5', '\x2', '\xF', '\n', 
		'\x2', '\x3', '\x2', '\x6', '\x2', '\x12', '\n', '\x2', '\r', '\x2', '\xE', 
		'\x2', '\x13', '\x3', '\x2', '\x3', '\x2', '\x6', '\x2', '\x18', '\n', 
		'\x2', '\r', '\x2', '\xE', '\x2', '\x19', '\x5', '\x2', '\x1C', '\n', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', ' ', '\n', '\x3', '\f', 
		'\x3', '\xE', '\x3', '#', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x6', '\x5', '(', '\n', '\x5', '\r', '\x5', '\xE', '\x5', ')', 
		'\x3', '\x6', '\x6', '\x6', '-', '\n', '\x6', '\r', '\x6', '\xE', '\x6', 
		'.', '\x3', '\x6', '\x3', '\x6', '\x2', '\x2', '\a', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\x3', '\x2', '\x6', '\x3', 
		'\x2', '\x32', ';', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x38', 
		'\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x3', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x5', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\a', '$', '\x3', '\x2', '\x2', '\x2', '\t', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\v', ',', '\x3', '\x2', '\x2', '\x2', '\r', '\xF', '\a', '/', 
		'\x2', '\x2', '\xE', '\r', '\x3', '\x2', '\x2', '\x2', '\xE', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\xF', '\x11', '\x3', '\x2', '\x2', '\x2', '\x10', 
		'\x12', '\t', '\x2', '\x2', '\x2', '\x11', '\x10', '\x3', '\x2', '\x2', 
		'\x2', '\x12', '\x13', '\x3', '\x2', '\x2', '\x2', '\x13', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x13', '\x14', '\x3', '\x2', '\x2', '\x2', '\x14', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x15', '\x17', '\a', '\x30', '\x2', 
		'\x2', '\x16', '\x18', '\t', '\x2', '\x2', '\x2', '\x17', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '\x18', '\x19', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x1A', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1C', 
		'\x4', '\x3', '\x2', '\x2', '\x2', '\x1D', '!', '\t', '\x3', '\x2', '\x2', 
		'\x1E', ' ', '\t', '\x4', '\x2', '\x2', '\x1F', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', ' ', '#', '\x3', '\x2', '\x2', '\x2', '!', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '!', '\"', '\x3', '\x2', '\x2', '\x2', '\"', '\x6', 
		'\x3', '\x2', '\x2', '\x2', '#', '!', '\x3', '\x2', '\x2', '\x2', '$', 
		'%', '\a', '=', '\x2', '\x2', '%', '\b', '\x3', '\x2', '\x2', '\x2', '&', 
		'(', '\t', '\x2', '\x2', '\x2', '\'', '&', '\x3', '\x2', '\x2', '\x2', 
		'(', ')', '\x3', '\x2', '\x2', '\x2', ')', '\'', '\x3', '\x2', '\x2', 
		'\x2', ')', '*', '\x3', '\x2', '\x2', '\x2', '*', '\n', '\x3', '\x2', 
		'\x2', '\x2', '+', '-', '\t', '\x5', '\x2', '\x2', ',', '+', '\x3', '\x2', 
		'\x2', '\x2', '-', '.', '\x3', '\x2', '\x2', '\x2', '.', ',', '\x3', '\x2', 
		'\x2', '\x2', '.', '/', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\x3', 
		'\x2', '\x2', '\x2', '\x30', '\x31', '\b', '\x6', '\x2', '\x2', '\x31', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\n', '\x2', '\xE', '\x13', '\x19', 
		'\x1B', '!', ')', '.', '\x3', '\b', '\x2', '\x2',
>>>>>>> test-antlr
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace CBlunt.ANTLR.AutoGeneratedParser
