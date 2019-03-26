// Generated from c:\Users\Jakob\Documents\GitHub\sw417f19\CBlunt\CBlunt.g4 by ANTLR 4.7.1
#pragma warning disable 3021
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class CBluntLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
<<<<<<< HEAD
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NUMBER=7, STRING=8, ID=9, 
		DIGIT=10, WS=11;
=======
		NUMBER=1, ID=2, SEMICOLON=3, DIGIT=4, WS=5;
>>>>>>> test-antlr
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	public static final String[] ruleNames = {
<<<<<<< HEAD
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "NUMBER", "STRING", "ID", 
		"DIGIT", "WS"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'='", "';'", "'\"'", "'number'", "'string'", "'void'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, null, null, null, null, "NUMBER", "STRING", "ID", "DIGIT", 
		"WS"
=======
		"NUMBER", "ID", "SEMICOLON", "DIGIT", "WS"
	};

	private static final String[] _LITERAL_NAMES = {
		null, null, null, "';'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, "NUMBER", "ID", "SEMICOLON", "DIGIT", "WS"
>>>>>>> test-antlr
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public CBluntLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "CBlunt.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
<<<<<<< HEAD
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\r]\b\1\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\3\2\3\2\3\3\3\3\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3\5\3\5\3\6\3"+
		"\6\3\6\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\b\5\b\64\n\b\3\b\6\b\67\n"+
		"\b\r\b\16\b8\3\b\3\b\6\b=\n\b\r\b\16\b>\5\bA\n\b\3\t\3\t\3\t\7\tF\n\t"+
		"\f\t\16\tI\13\t\3\n\3\n\7\nM\n\n\f\n\16\nP\13\n\3\13\6\13S\n\13\r\13\16"+
		"\13T\3\f\6\fX\n\f\r\f\16\fY\3\f\3\f\2\2\r\3\3\5\4\7\5\t\6\13\7\r\b\17"+
		"\t\21\n\23\13\25\f\27\r\3\2\6\3\2\62;\5\2C\\aac|\6\2\62;C\\aac|\5\2\13"+
		"\f\17\17\"\"\2d\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3"+
		"\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2"+
		"\2\27\3\2\2\2\3\31\3\2\2\2\5\33\3\2\2\2\7\35\3\2\2\2\t\37\3\2\2\2\13&"+
		"\3\2\2\2\r-\3\2\2\2\17\63\3\2\2\2\21B\3\2\2\2\23J\3\2\2\2\25R\3\2\2\2"+
		"\27W\3\2\2\2\31\32\7?\2\2\32\4\3\2\2\2\33\34\7=\2\2\34\6\3\2\2\2\35\36"+
		"\7$\2\2\36\b\3\2\2\2\37 \7p\2\2 !\7w\2\2!\"\7o\2\2\"#\7d\2\2#$\7g\2\2"+
		"$%\7t\2\2%\n\3\2\2\2&\'\7u\2\2\'(\7v\2\2()\7t\2\2)*\7k\2\2*+\7p\2\2+,"+
		"\7i\2\2,\f\3\2\2\2-.\7x\2\2./\7q\2\2/\60\7k\2\2\60\61\7f\2\2\61\16\3\2"+
		"\2\2\62\64\7/\2\2\63\62\3\2\2\2\63\64\3\2\2\2\64\66\3\2\2\2\65\67\t\2"+
		"\2\2\66\65\3\2\2\2\678\3\2\2\28\66\3\2\2\289\3\2\2\29@\3\2\2\2:<\7\60"+
		"\2\2;=\t\2\2\2<;\3\2\2\2=>\3\2\2\2><\3\2\2\2>?\3\2\2\2?A\3\2\2\2@:\3\2"+
		"\2\2@A\3\2\2\2A\20\3\2\2\2BC\t\3\2\2CG\t\3\2\2DF\t\2\2\2ED\3\2\2\2FI\3"+
		"\2\2\2GE\3\2\2\2GH\3\2\2\2H\22\3\2\2\2IG\3\2\2\2JN\t\3\2\2KM\t\4\2\2L"+
		"K\3\2\2\2MP\3\2\2\2NL\3\2\2\2NO\3\2\2\2O\24\3\2\2\2PN\3\2\2\2QS\t\2\2"+
		"\2RQ\3\2\2\2ST\3\2\2\2TR\3\2\2\2TU\3\2\2\2U\26\3\2\2\2VX\t\5\2\2WV\3\2"+
		"\2\2XY\3\2\2\2YW\3\2\2\2YZ\3\2\2\2Z[\3\2\2\2[\\\b\f\2\2\\\30\3\2\2\2\13"+
		"\2\638>@GNTY\3\b\2\2";
=======
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\7\62\b\1\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\3\2\5\2\17\n\2\3\2\6\2\22\n\2\r\2\16"+
		"\2\23\3\2\3\2\6\2\30\n\2\r\2\16\2\31\5\2\34\n\2\3\3\3\3\7\3 \n\3\f\3\16"+
		"\3#\13\3\3\4\3\4\3\5\6\5(\n\5\r\5\16\5)\3\6\6\6-\n\6\r\6\16\6.\3\6\3\6"+
		"\2\2\7\3\3\5\4\7\5\t\6\13\7\3\2\6\3\2\62;\5\2C\\aac|\6\2\62;C\\aac|\5"+
		"\2\13\f\17\17\"\"\28\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2"+
		"\13\3\2\2\2\3\16\3\2\2\2\5\35\3\2\2\2\7$\3\2\2\2\t\'\3\2\2\2\13,\3\2\2"+
		"\2\r\17\7/\2\2\16\r\3\2\2\2\16\17\3\2\2\2\17\21\3\2\2\2\20\22\t\2\2\2"+
		"\21\20\3\2\2\2\22\23\3\2\2\2\23\21\3\2\2\2\23\24\3\2\2\2\24\33\3\2\2\2"+
		"\25\27\7\60\2\2\26\30\t\2\2\2\27\26\3\2\2\2\30\31\3\2\2\2\31\27\3\2\2"+
		"\2\31\32\3\2\2\2\32\34\3\2\2\2\33\25\3\2\2\2\33\34\3\2\2\2\34\4\3\2\2"+
		"\2\35!\t\3\2\2\36 \t\4\2\2\37\36\3\2\2\2 #\3\2\2\2!\37\3\2\2\2!\"\3\2"+
		"\2\2\"\6\3\2\2\2#!\3\2\2\2$%\7=\2\2%\b\3\2\2\2&(\t\2\2\2\'&\3\2\2\2()"+
		"\3\2\2\2)\'\3\2\2\2)*\3\2\2\2*\n\3\2\2\2+-\t\5\2\2,+\3\2\2\2-.\3\2\2\2"+
		".,\3\2\2\2./\3\2\2\2/\60\3\2\2\2\60\61\b\6\2\2\61\f\3\2\2\2\n\2\16\23"+
		"\31\33!).\3\b\2\2";
>>>>>>> test-antlr
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}