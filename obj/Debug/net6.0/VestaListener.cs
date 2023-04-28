﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\fredm\RiderProjects\P4Project\Antlr language\Content\Vesta.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Antlr_language.Content {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="VestaParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IVestaListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] VestaParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] VestaParser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] VestaParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] VestaParser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>arrayIdentifierExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayIdentifierExpression([NotNull] VestaParser.ArrayIdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>arrayIdentifierExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayIdentifierExpression([NotNull] VestaParser.ArrayIdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>arrayExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayExpression([NotNull] VestaParser.ArrayExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>arrayExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayExpression([NotNull] VestaParser.ArrayExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>randomExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRandomExpression([NotNull] VestaParser.RandomExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>randomExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRandomExpression([NotNull] VestaParser.RandomExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] VestaParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] VestaParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>arrayOperationExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayOperationExpression([NotNull] VestaParser.ArrayOperationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>arrayOperationExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayOperationExpression([NotNull] VestaParser.ArrayOperationExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] VestaParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] VestaParser.ParenthesizedExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] VestaParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] VestaParser.NotExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicationExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationExpression([NotNull] VestaParser.MultiplicationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicationExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationExpression([NotNull] VestaParser.MultiplicationExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>additionExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditionExpression([NotNull] VestaParser.AdditionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additionExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditionExpression([NotNull] VestaParser.AdditionExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>compareExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareExpression([NotNull] VestaParser.CompareExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compareExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareExpression([NotNull] VestaParser.CompareExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] VestaParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] VestaParser.BooleanExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] VestaParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] VestaParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] VestaParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] VestaParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] VestaParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] VestaParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] VestaParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] VestaParser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] VestaParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] VestaParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] VestaParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] VestaParser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.chanceBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChanceBlock([NotNull] VestaParser.ChanceBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.chanceBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChanceBlock([NotNull] VestaParser.ChanceBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] VestaParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] VestaParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] VestaParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] VestaParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.declartion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclartion([NotNull] VestaParser.DeclartionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.declartion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclartion([NotNull] VestaParser.DeclartionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] VestaParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] VestaParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] VestaParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] VestaParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.arrayOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayOp([NotNull] VestaParser.ArrayOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.arrayOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayOp([NotNull] VestaParser.ArrayOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultOp([NotNull] VestaParser.MultOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultOp([NotNull] VestaParser.MultOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOp([NotNull] VestaParser.AddOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOp([NotNull] VestaParser.AddOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareOp([NotNull] VestaParser.CompareOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareOp([NotNull] VestaParser.CompareOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOp([NotNull] VestaParser.BoolOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOp([NotNull] VestaParser.BoolOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] VestaParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] VestaParser.ConstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="VestaParser.identifierType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierType([NotNull] VestaParser.IdentifierTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="VestaParser.identifierType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierType([NotNull] VestaParser.IdentifierTypeContext context);
}
} // namespace Antlr_language.Content
