using System;
using Antlr_language.ast.expression;
using Antlr_language.ast.statement;

namespace Antlr_language.ast.structure
{
	public class IfNode : AbstractNode
	{
        private ExpressionNode expression;
        private BlockNode block;
        public string CodeGen ()
		{
            //Maybe string builder here?
            string result = "if (";
            result += expression.CodeGen();
            result += ") ";
            result += block.CodeGen();
            return result;
        }

	}
}


