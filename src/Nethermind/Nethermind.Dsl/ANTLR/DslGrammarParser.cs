//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DslGrammar.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class DslGrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WORD=1, DIGIT=2, ADDRESS=3, WS=4, BOOLEAN_OPERATOR=5, ARITHMETIC_SYMBOL=6, 
		CONDITION_VALUE=7, SOURCE=8, WATCH=9, WHERE=10, PUBLISH=11, AND=12, OR=13, 
		CONTAINS=14, PUBLISH_VALUE=15, WEBSOCKETS=16, LOG_PUBLISHER=17;
	public const int
		RULE_tree = 0, RULE_expression = 1, RULE_sourceExpression = 2, RULE_watchExpression = 3, 
		RULE_whereExpression = 4, RULE_publishExpression = 5, RULE_condition = 6, 
		RULE_andCondition = 7, RULE_orCondition = 8;
	public static readonly string[] ruleNames = {
		"tree", "expression", "sourceExpression", "watchExpression", "whereExpression", 
		"publishExpression", "condition", "andCondition", "orCondition"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, "'SOURCE'", "'WATCH'", 
		"'WHERE'", "'PUBLISH'", "'AND'", "'OR'", "'CONTAINS'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WORD", "DIGIT", "ADDRESS", "WS", "BOOLEAN_OPERATOR", "ARITHMETIC_SYMBOL", 
		"CONDITION_VALUE", "SOURCE", "WATCH", "WHERE", "PUBLISH", "AND", "OR", 
		"CONTAINS", "PUBLISH_VALUE", "WEBSOCKETS", "LOG_PUBLISHER"
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

	public override string GrammarFileName { get { return "DslGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DslGrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public DslGrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public DslGrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class TreeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public TreeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_tree; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterTree(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitTree(this);
		}
	}

	[RuleVersion(0)]
	public TreeContext tree() {
		TreeContext _localctx = new TreeContext(Context, State);
		EnterRule(_localctx, 0, RULE_tree);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << SOURCE) | (1L << WATCH) | (1L << WHERE) | (1L << PUBLISH) | (1L << AND) | (1L << OR))) != 0)) {
				{
				{
				State = 18;
				expression();
				}
				}
				State = 23;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SourceExpressionContext sourceExpression() {
			return GetRuleContext<SourceExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WatchExpressionContext watchExpression() {
			return GetRuleContext<WatchExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public WhereExpressionContext whereExpression() {
			return GetRuleContext<WhereExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PublishExpressionContext publishExpression() {
			return GetRuleContext<PublishExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public AndConditionContext andCondition() {
			return GetRuleContext<AndConditionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public OrConditionContext orCondition() {
			return GetRuleContext<OrConditionContext>(0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		ExpressionContext _localctx = new ExpressionContext(Context, State);
		EnterRule(_localctx, 2, RULE_expression);
		try {
			State = 30;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case SOURCE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 24;
				sourceExpression();
				}
				break;
			case WATCH:
				EnterOuterAlt(_localctx, 2);
				{
				State = 25;
				watchExpression();
				}
				break;
			case WHERE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 26;
				whereExpression();
				}
				break;
			case PUBLISH:
				EnterOuterAlt(_localctx, 4);
				{
				State = 27;
				publishExpression();
				}
				break;
			case AND:
				EnterOuterAlt(_localctx, 5);
				{
				State = 28;
				andCondition();
				}
				break;
			case OR:
				EnterOuterAlt(_localctx, 6);
				{
				State = 29;
				orCondition();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SourceExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SOURCE() { return GetToken(DslGrammarParser.SOURCE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD() { return GetToken(DslGrammarParser.WORD, 0); }
		public SourceExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sourceExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterSourceExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitSourceExpression(this);
		}
	}

	[RuleVersion(0)]
	public SourceExpressionContext sourceExpression() {
		SourceExpressionContext _localctx = new SourceExpressionContext(Context, State);
		EnterRule(_localctx, 4, RULE_sourceExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32;
			Match(SOURCE);
			State = 33;
			Match(WORD);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WatchExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WATCH() { return GetToken(DslGrammarParser.WATCH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD() { return GetToken(DslGrammarParser.WORD, 0); }
		public WatchExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_watchExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterWatchExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitWatchExpression(this);
		}
	}

	[RuleVersion(0)]
	public WatchExpressionContext watchExpression() {
		WatchExpressionContext _localctx = new WatchExpressionContext(Context, State);
		EnterRule(_localctx, 6, RULE_watchExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35;
			Match(WATCH);
			State = 36;
			Match(WORD);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhereExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WHERE() { return GetToken(DslGrammarParser.WHERE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionContext condition() {
			return GetRuleContext<ConditionContext>(0);
		}
		public WhereExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whereExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterWhereExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitWhereExpression(this);
		}
	}

	[RuleVersion(0)]
	public WhereExpressionContext whereExpression() {
		WhereExpressionContext _localctx = new WhereExpressionContext(Context, State);
		EnterRule(_localctx, 8, RULE_whereExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38;
			Match(WHERE);
			State = 39;
			condition();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PublishExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLISH() { return GetToken(DslGrammarParser.PUBLISH, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PUBLISH_VALUE() { return GetToken(DslGrammarParser.PUBLISH_VALUE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD() { return GetToken(DslGrammarParser.WORD, 0); }
		public PublishExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_publishExpression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterPublishExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitPublishExpression(this);
		}
	}

	[RuleVersion(0)]
	public PublishExpressionContext publishExpression() {
		PublishExpressionContext _localctx = new PublishExpressionContext(Context, State);
		EnterRule(_localctx, 10, RULE_publishExpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 41;
			Match(PUBLISH);
			State = 42;
			Match(PUBLISH_VALUE);
			State = 43;
			Match(WORD);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD() { return GetToken(DslGrammarParser.WORD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode BOOLEAN_OPERATOR() { return GetToken(DslGrammarParser.BOOLEAN_OPERATOR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONDITION_VALUE() { return GetToken(DslGrammarParser.CONDITION_VALUE, 0); }
		public ConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_condition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitCondition(this);
		}
	}

	[RuleVersion(0)]
	public ConditionContext condition() {
		ConditionContext _localctx = new ConditionContext(Context, State);
		EnterRule(_localctx, 12, RULE_condition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45;
			Match(WORD);
			State = 46;
			Match(BOOLEAN_OPERATOR);
			State = 47;
			Match(CONDITION_VALUE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AndConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode AND() { return GetToken(DslGrammarParser.AND, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionContext condition() {
			return GetRuleContext<ConditionContext>(0);
		}
		public AndConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_andCondition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterAndCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitAndCondition(this);
		}
	}

	[RuleVersion(0)]
	public AndConditionContext andCondition() {
		AndConditionContext _localctx = new AndConditionContext(Context, State);
		EnterRule(_localctx, 14, RULE_andCondition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 49;
			Match(AND);
			State = 50;
			condition();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OrConditionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OR() { return GetToken(DslGrammarParser.OR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ConditionContext condition() {
			return GetRuleContext<ConditionContext>(0);
		}
		public OrConditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_orCondition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.EnterOrCondition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IDslGrammarListener typedListener = listener as IDslGrammarListener;
			if (typedListener != null) typedListener.ExitOrCondition(this);
		}
	}

	[RuleVersion(0)]
	public OrConditionContext orCondition() {
		OrConditionContext _localctx = new OrConditionContext(Context, State);
		EnterRule(_localctx, 16, RULE_orCondition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52;
			Match(OR);
			State = 53;
			condition();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x13', ':', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', '\a', 
		'\x2', '\x16', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x19', '\v', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x5', '\x3', '!', '\n', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x2', '\x2', '\v', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', 
		'\x10', '\x12', '\x2', '\x2', '\x2', '\x36', '\x2', '\x17', '\x3', '\x2', 
		'\x2', '\x2', '\x4', ' ', '\x3', '\x2', '\x2', '\x2', '\x6', '\"', '\x3', 
		'\x2', '\x2', '\x2', '\b', '%', '\x3', '\x2', '\x2', '\x2', '\n', '(', 
		'\x3', '\x2', '\x2', '\x2', '\f', '+', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x10', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\x12', '\x36', '\x3', '\x2', '\x2', '\x2', '\x14', '\x16', '\x5', 
		'\x4', '\x3', '\x2', '\x15', '\x14', '\x3', '\x2', '\x2', '\x2', '\x16', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x17', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x18', '\x3', '\x2', '\x2', '\x2', '\x18', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x17', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'!', '\x5', '\x6', '\x4', '\x2', '\x1B', '!', '\x5', '\b', '\x5', '\x2', 
		'\x1C', '!', '\x5', '\n', '\x6', '\x2', '\x1D', '!', '\x5', '\f', '\a', 
		'\x2', '\x1E', '!', '\x5', '\x10', '\t', '\x2', '\x1F', '!', '\x5', '\x12', 
		'\n', '\x2', ' ', '\x1A', '\x3', '\x2', '\x2', '\x2', ' ', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', ' ', '\x1C', '\x3', '\x2', '\x2', '\x2', ' ', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', ' ', '\x1E', '\x3', '\x2', '\x2', '\x2', ' ', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '!', '\x5', '\x3', '\x2', '\x2', '\x2', 
		'\"', '#', '\a', '\n', '\x2', '\x2', '#', '$', '\a', '\x3', '\x2', '\x2', 
		'$', '\a', '\x3', '\x2', '\x2', '\x2', '%', '&', '\a', '\v', '\x2', '\x2', 
		'&', '\'', '\a', '\x3', '\x2', '\x2', '\'', '\t', '\x3', '\x2', '\x2', 
		'\x2', '(', ')', '\a', '\f', '\x2', '\x2', ')', '*', '\x5', '\xE', '\b', 
		'\x2', '*', '\v', '\x3', '\x2', '\x2', '\x2', '+', ',', '\a', '\r', '\x2', 
		'\x2', ',', '-', '\a', '\x11', '\x2', '\x2', '-', '.', '\a', '\x3', '\x2', 
		'\x2', '.', '\r', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\a', '\x3', 
		'\x2', '\x2', '\x30', '\x31', '\a', '\a', '\x2', '\x2', '\x31', '\x32', 
		'\a', '\t', '\x2', '\x2', '\x32', '\xF', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\x34', '\a', '\xE', '\x2', '\x2', '\x34', '\x35', '\x5', '\xE', '\b', 
		'\x2', '\x35', '\x11', '\x3', '\x2', '\x2', '\x2', '\x36', '\x37', '\a', 
		'\xF', '\x2', '\x2', '\x37', '\x38', '\x5', '\xE', '\b', '\x2', '\x38', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x4', '\x17', ' ',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
