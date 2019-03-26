// Generated from c:\Users\Jakob\Documents\GitHub\sw417f19\CBlunt\CBlunt.g4 by ANTLR 4.7.1
#pragma warning disable 3021
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class CBluntParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
<<<<<<< HEAD
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NUMBER=7, STRING=8, ID=9, 
		DIGIT=10, WS=11;
	public static final int
		RULE_start = 0, RULE_expression = 1, RULE_identifier = 2, RULE_declaration = 3, 
		RULE_types = 4;
	public static final String[] ruleNames = {
		"start", "expression", "identifier", "declaration", "types"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'='", "';'", "'\"'", "'number'", "'string'", "'void'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, null, null, null, null, "NUMBER", "STRING", "ID", "DIGIT", 
		"WS"
=======
		NUMBER=1, ID=2, SEMICOLON=3, DIGIT=4, WS=5;
	public static final int
		RULE_start = 0, RULE_expression = 1, RULE_identifier = 2;
	public static final String[] ruleNames = {
		"start", "expression", "identifier"
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

	@Override
	public String getGrammarFileName() { return "CBlunt.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public CBluntParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class StartContext extends ParserRuleContext {
		public ExpressionContext expression() {
			return getRuleContext(ExpressionContext.class,0);
		}
		public StartContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_start; }
	}

	public final StartContext start() throws RecognitionException {
		StartContext _localctx = new StartContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_start);
		try {
			enterOuterAlt(_localctx, 1);
			{
<<<<<<< HEAD
			setState(10);
=======
			setState(6);
>>>>>>> test-antlr
			expression();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExpressionContext extends ParserRuleContext {
<<<<<<< HEAD
		public List<DeclarationContext> declaration() {
			return getRuleContexts(DeclarationContext.class);
		}
		public DeclarationContext declaration(int i) {
			return getRuleContext(DeclarationContext.class,i);
=======
		public List<IdentifierContext> identifier() {
			return getRuleContexts(IdentifierContext.class);
		}
		public IdentifierContext identifier(int i) {
			return getRuleContext(IdentifierContext.class,i);
>>>>>>> test-antlr
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expression; }
	}

	public final ExpressionContext expression() throws RecognitionException {
		ExpressionContext _localctx = new ExpressionContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_expression);
		int _la;
		try {
			setState(20);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
<<<<<<< HEAD
				setState(12);
				declaration();
				setState(16);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__3) | (1L << T__4) | (1L << T__5))) != 0)) {
					{
					{
					setState(13);
					declaration();
					}
					}
					setState(18);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
=======
				setState(8);
				identifier();
				setState(9);
				match(SEMICOLON);
				setState(11); 
				_errHandler.sync(this);
				_la = _input.LA(1);
				do {
					{
					{
					setState(10);
					identifier();
					}
					}
					setState(13); 
					_errHandler.sync(this);
					_la = _input.LA(1);
				} while ( _la==ID );
				setState(15);
				match(SEMICOLON);
>>>>>>> test-antlr
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
<<<<<<< HEAD
				setState(19);
				declaration();
=======
				setState(17);
				identifier();
				setState(18);
				match(SEMICOLON);
>>>>>>> test-antlr
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IdentifierContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(CBluntParser.ID, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_identifier; }
	}

	public final IdentifierContext identifier() throws RecognitionException {
		IdentifierContext _localctx = new IdentifierContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_identifier);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(22);
			match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

<<<<<<< HEAD
	public static class DeclarationContext extends ParserRuleContext {
		public TypesContext types() {
			return getRuleContext(TypesContext.class,0);
		}
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode NUMBER() { return getToken(CBluntParser.NUMBER, 0); }
		public TerminalNode ID() { return getToken(CBluntParser.ID, 0); }
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_declaration);
		int _la;
		try {
			setState(42);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(24);
				types();
				setState(25);
				identifier();
				setState(28);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__0) {
					{
					setState(26);
					match(T__0);
					setState(27);
					match(NUMBER);
					}
				}

				setState(30);
				match(T__1);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(32);
				types();
				setState(33);
				identifier();
				setState(38);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==T__0) {
					{
					setState(34);
					match(T__0);
					setState(35);
					match(T__2);
					setState(36);
					match(ID);
					setState(37);
					match(T__2);
					}
				}

				setState(40);
				match(T__1);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TypesContext extends ParserRuleContext {
		public TypesContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_types; }
	}

	public final TypesContext types() throws RecognitionException {
		TypesContext _localctx = new TypesContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_types);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(44);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__3) | (1L << T__4) | (1L << T__5))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\r\61\4\2\t\2\4\3"+
		"\t\3\4\4\t\4\4\5\t\5\4\6\t\6\3\2\3\2\3\3\3\3\7\3\21\n\3\f\3\16\3\24\13"+
		"\3\3\3\5\3\27\n\3\3\4\3\4\3\5\3\5\3\5\3\5\5\5\37\n\5\3\5\3\5\3\5\3\5\3"+
		"\5\3\5\3\5\3\5\5\5)\n\5\3\5\3\5\5\5-\n\5\3\6\3\6\3\6\2\2\7\2\4\6\b\n\2"+
		"\3\3\2\6\b\2\60\2\f\3\2\2\2\4\26\3\2\2\2\6\30\3\2\2\2\b,\3\2\2\2\n.\3"+
		"\2\2\2\f\r\5\4\3\2\r\3\3\2\2\2\16\22\5\b\5\2\17\21\5\b\5\2\20\17\3\2\2"+
		"\2\21\24\3\2\2\2\22\20\3\2\2\2\22\23\3\2\2\2\23\27\3\2\2\2\24\22\3\2\2"+
		"\2\25\27\5\b\5\2\26\16\3\2\2\2\26\25\3\2\2\2\27\5\3\2\2\2\30\31\7\13\2"+
		"\2\31\7\3\2\2\2\32\33\5\n\6\2\33\36\5\6\4\2\34\35\7\3\2\2\35\37\7\t\2"+
		"\2\36\34\3\2\2\2\36\37\3\2\2\2\37 \3\2\2\2 !\7\4\2\2!-\3\2\2\2\"#\5\n"+
		"\6\2#(\5\6\4\2$%\7\3\2\2%&\7\5\2\2&\'\7\13\2\2\')\7\5\2\2($\3\2\2\2()"+
		"\3\2\2\2)*\3\2\2\2*+\7\4\2\2+-\3\2\2\2,\32\3\2\2\2,\"\3\2\2\2-\t\3\2\2"+
		"\2./\t\2\2\2/\13\3\2\2\2\7\22\26\36(,";
=======
	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\7\33\4\2\t\2\4\3"+
		"\t\3\4\4\t\4\3\2\3\2\3\3\3\3\3\3\6\3\16\n\3\r\3\16\3\17\3\3\3\3\3\3\3"+
		"\3\3\3\5\3\27\n\3\3\4\3\4\3\4\2\2\5\2\4\6\2\2\2\31\2\b\3\2\2\2\4\26\3"+
		"\2\2\2\6\30\3\2\2\2\b\t\5\4\3\2\t\3\3\2\2\2\n\13\5\6\4\2\13\r\7\5\2\2"+
		"\f\16\5\6\4\2\r\f\3\2\2\2\16\17\3\2\2\2\17\r\3\2\2\2\17\20\3\2\2\2\20"+
		"\21\3\2\2\2\21\22\7\5\2\2\22\27\3\2\2\2\23\24\5\6\4\2\24\25\7\5\2\2\25"+
		"\27\3\2\2\2\26\n\3\2\2\2\26\23\3\2\2\2\27\5\3\2\2\2\30\31\7\4\2\2\31\7"+
		"\3\2\2\2\4\17\26";
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