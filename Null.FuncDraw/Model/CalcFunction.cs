﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Null.FuncDraw.Model
{
    public class CalcFunction
    {
        private readonly List<ISubOperation> operations;

        public CalcFunction()
        {
            operations = new List<ISubOperation>();

            DateTime time = DateTime.Now;
            FunctionName = $"T-{time.Day}-{time.Hour}-{time.Minute}-{time.Second}";
        }

        public CalcFunction(string name)
        {
            operations = new List<ISubOperation>();
            FunctionName = name;
        }

        public Color ForeCore { get; set; }
        public string FunctionName { get; set; }
        public List<ISubOperation> Operations => operations;

        public override string ToString()
        {
            return $"Function Name:{FunctionName} OperationCount:{operations.Count}";
        }

        public double Calculate(double input)
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
