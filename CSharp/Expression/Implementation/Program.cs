using CSharp.ExpressionDemo.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp.ExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumLessThan5();
            //MultiLessThanTen();
            //PowerDemo();
            ExpressionVisitorDemo();

            Console.Read();
        }


        static void NumLessThan5()
        {
            //num => num < 5
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression five = Expression.Constant(5, typeof(int));
            BinaryExpression numLessThanFive = Expression.LessThan(numParam, five);
            Expression<Func<int, bool>> lambda1 =
                Expression.Lambda<Func<int, bool>>(
                    numLessThanFive,
                    new ParameterExpression[] { numParam });

            Console.WriteLine($"Lambda的内容：{lambda1.ToString()}");

            //表达式的编译
            var func = lambda1.Compile();
            Console.WriteLine($"Lambda的运行结果：{func(6)}");
        }

        static void MultiLessThanTen()
        {
            //(x, y) => x * y < 10
            ParameterExpression xPara = Expression.Parameter(typeof(int), "x"); //x
            ParameterExpression yPara = Expression.Parameter(typeof(int), "y"); //y
            ConstantExpression ten = Expression.Constant(10, typeof(int)); //10
            BinaryExpression multi = Expression.Multiply(xPara, yPara); //x * y
            BinaryExpression multiLessThanTen = Expression.LessThan(multi, ten); // x * y < 10
            Expression<Func<int, int, bool>> lambda = Expression.Lambda<Func<int, int, bool>>(multiLessThanTen, new ParameterExpression[] { xPara, yPara });
            //(x ,y) => (x * y) < 10
            Console.WriteLine($"Lambda的内容{lambda.ToString()}");
            var func02 = lambda.Compile();
            Console.WriteLine($"Lambda的运行结果：{func02(2, 3)}");
        }

        static void PowerDemo()
        {
            // The expression tree to execute.  
            BinaryExpression be = Expression.Power(Expression.Constant(2D), Expression.Constant(3D));

            // Create a lambda expression.  
            Expression<Func<double>> le = Expression.Lambda<Func<double>>(be);

            // Compile the lambda expression.  
            Func<double> compiledExpression = le.Compile();

            // Execute the lambda expression.  
            double result = compiledExpression();

            // Display the result.  
            Console.WriteLine(result);
        }

        static void ExpressionVisitorDemo()
        {
            VisitorModifier modifier = new VisitorModifier();
            //num => num <= 10
            Expression<Func<int, bool>> expression = num => num <= 10;
            Console.WriteLine(expression.ToString());
            //num => num < 10
            Expression expressionModifid = modifier.Modify(expression);
            Console.WriteLine(expressionModifid.ToString());
        }
    }
}
