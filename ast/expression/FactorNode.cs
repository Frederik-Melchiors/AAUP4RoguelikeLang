﻿using System;

namespace Antlr_language.ast.expression
{
    public class FactorNode : AbstractExpressionNode
    {
        
        private ExpressionNode? parenthesizedExpression;
        private ConstantNode? constant;
        private Factor2Node? factor2;
        private List<ExpressionNode>? arrayExpressionsNode;
        private MapExpressionNode? mapExpression;
        private ArrayAccessNode? arrayAccess;
        private MapAccessNode? mapAccess;

        public Factor2Node? GetFactor2Node() {
            return factor2;
        }

        public FactorNode(ExpressionNode? parenthesizedExpression, ConstantNode? constant, Factor2Node? factor2, List<ExpressionNode>? arrayExpressionsNode, MapExpressionNode? mapExpression, ArrayAccessNode? arrayAccess, MapAccessNode? mapAccess)
        {
            this.parenthesizedExpression = parenthesizedExpression;
            this.constant = constant;
            this.factor2 = factor2;
            this.arrayExpressionsNode = arrayExpressionsNode;
            this.mapExpression = mapExpression;
            this.arrayAccess = arrayAccess;
            this.mapAccess = mapAccess;
        }

        public override string CodeGen(int indentation)
        {
            if (parenthesizedExpression != null) {
                return "(" + parenthesizedExpression.CodeGen(indentation) + ")";
            } else if (constant != null) {
                return constant.CodeGen(indentation);
            } else if (factor2 != null) {
                return factor2.CodeGen(indentation);
            } else {
                throw new NotImplementedException();
            }
        }
        public override Enums.Types getEvaluationType () {
            if(constant != null) {
                if(constant.GetInteger() != null) {
                    return Enums.Types.INTEGER;
                }
                if(constant.GetBoolean() != null) {
                    return Enums.Types.BOOL;
                }
                throw new Exception("Lol neither int or bool xd");
            }
            if(mapExpression != null) {
                return Enums.Types.MAP;
            }
            
            throw new UndefinedTypeException("Error In FactorNode.cs");
            
            // HVAD MED BOOL??? HVBAD ER DET FOR NOGLE FIELDS JEG OPVERHOEVEDT KIGGER PÅ
        }
    }
}
