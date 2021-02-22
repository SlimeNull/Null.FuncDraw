using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Null.FuncDraw.Model
{
    public class FuncDataContainer
    {
        private readonly Dictionary<string, double> variables;

        public FuncDataContainer()
        {
            variables = new Dictionary<string, double>();
            variables["PI"] = Math.PI;
            variables["E"] = Math.E;
        }

        public Dictionary<string, double> Variables => variables;
        public double LastValue { get; set; } = 0;
    }
}
