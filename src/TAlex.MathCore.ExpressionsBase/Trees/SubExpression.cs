﻿using System;


namespace TAlex.MathCore.ExpressionEvaluation.Trees
{
    public abstract class SubExpression<T> : BinaryExpression<T>
    {
        public override string ToString()
        {
            return LeftExpression + "-" + RightExpression;
        }
    }
}
