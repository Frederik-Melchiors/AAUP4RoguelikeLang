﻿using System;
using Antlr_language.ast.expression;
using Antlr_language.ast.statement;

namespace Antlr_language.ast.structure
{
    public class BlockNode : AbstractNode
    {
        private List<StatementNode> statementNodes = new List<StatementNode>();
        public string CodeGen()
        {
            string result = "";
            foreach (StatementNode statement in statementNodes) {
                result += statement.CodeGen();
            }
            return result;
        }

    }
}
