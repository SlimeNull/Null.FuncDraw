using NCalculatorLib;
using NCalculatorLib.Exprs;
using Null.Calculator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Null.FuncDraw.Model
{
    public abstract class CalcFunctionBase
    {

        public Color ForeCore { get; set; }

        public string FunctionName { get; set; }
        public abstract double Calculate(double input);

        public override string ToString()
        {
            return $"{FunctionName}.{ColorTranslator.ToHtml(ForeCore)}";
        }
    }

    public class StrExprCalcFunction : CalcFunctionBase
    {
        private Expr baseExpr;
        public readonly string Expression;

        public StrExprCalcFunction(string expr) : this($"{DateTime.Now:dd-HH-mm-ss}", expr)
        { }

        public StrExprCalcFunction(string name, string expr)
        {
            FunctionName = name;
            Expression = expr;
            baseExpr = new Parser(new Lexer(new StringReader(expr)).Lex().ToArray()).Parse();
        }

        public override double Calculate(double input)
        {
            NCalc.Constants["x"] = input;
            return baseExpr.Eval();
        }

        public override string ToString()
        {
            return $"{base.ToString()}: {Expression}";
        }
    }

    public class ChainOptCalcFunction : CalcFunctionBase
    {
        private readonly List<ISubOperation> operations;

        public ChainOptCalcFunction()
        {
            operations = new List<ISubOperation>();

            DateTime time = DateTime.Now;
            FunctionName = $"{time.Day}-{time.Hour}-{time.Minute}-{time.Second}";
        }

        public ChainOptCalcFunction(string name)
        {
            operations = new List<ISubOperation>();
            FunctionName = name;
        }

        public List<ISubOperation> Operations => operations;

        public override string ToString()
        {
            return $"Function Name:{FunctionName} OperationCount:{operations.Count}";
        }

        public override double Calculate(double input)
        {
            FuncDataContainer container = new FuncDataContainer();
            container.LastValue = input;

            foreach (ISubOperation opt in operations)
            {
                opt.Initialize(container);
                container.LastValue = opt.GetFunc().Invoke();
            }

            return container.LastValue;
        }
    }
}
