using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ExpressionDemo.Visitors
{
    class VisitorModifier : ExpressionVisitor
    {
        public Expression Modify(Expression expression)
        {
            return Visit(expression);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.NodeType == ExpressionType.LessThanOrEqual)
            {
                return Expression.MakeBinary(ExpressionType.LessThan, node.Left, node.Right);
            }
            return base.VisitBinary(node);
        }
    }
}
