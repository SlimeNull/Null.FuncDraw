using System;
using System.Collections.Generic;

namespace Null.FuncDraw.Model
{
    public static class SubOperationManager
    {
        static Dictionary<Type, string> type2name = new Dictionary<Type, string>()
        {
            {typeof(ModifyValue), "ModifyValue"},

            {typeof(PlusOperation), "PlusOperation"},
            {typeof(MinusOperation), "MinusOperation"},
            {typeof(MulOperation), "MulOperation"},
            {typeof(DivOperation), "DivOperation"},
            
            {typeof(SinOperation), "SinOperation"},
            {typeof(AsinOperation), "AsinOperation"},
            {typeof(SinhOperation), "SinhOperation"},
            {typeof(CosOperation), "CosOperation"},
            {typeof(AcosOperation), "AcosOperation"},
            {typeof(CoshOperation), "CoshOperation"},
            {typeof(TanOperation), "TanOperation"},
            {typeof(AtanOperation), "AtanOperation"},
            {typeof(TanhOperation), "TanhOperation"},
            
            {typeof(PowOperation), "PowOperation"},
            {typeof(LogOperation), "LogOperation"},
        };

        public static ISubOperation GetSubOperationInstance(SubOperationOption option)
        {
            ISubOperation result = option.OperationName switch
            {
                "ModifyValue" => new ModifyValue(),

                "PlusOperation" => new PlusOperation(),
                "MinusOperation" => new MinusOperation(),
                "MulOperation" => new MulOperation(),
                "DivOperation" => new DivOperation(),

                "SinOperation" => new SinOperation(),
                "AsinOperation" => new AsinOperation(),
                "SinhOperation" => new SinOperation(),
                "CosOperation" => new CosOperation(),
                "AcosOperation" => new AcosOperation(),
                "CoshOperation" => new CosOperation(),
                "TanOperation" => new TanOperation(),
                "AtanOperation" => new AtanOperation(),
                "TanhOperation" => new TanOperation(),

                "PowOperation" => new PowOperation(),
                "LogOperation" => new LogOperation(),

                _ => new ModifyValue(),
            };

            result.MainParamSource = option.MainParamSource;
            result.ViceParamSource = option.ViceParamSource;
            result.MainParamType = option.MainParamType;
            result.ViceParamType = option.ViceParamType;

            return result;
        }
        public static string GetSubOperationName(Type operationType)
        {
            return type2name.TryGetValue(operationType, out string result) ? result : "ModifyValue";
        }
        public static string GetOperationDescription(string operationName)
        {
            return operationName switch
            {
                "ModifyValue" => "Set main parameter as a variable and return it. Variable name should be specified as vice parameter.",
                "PlusOperation" => "Plus main parameter and vice parameter, then return the result.",
                "MinusOperation" => "Minus main parameter by vice parameter, then return the result.",
                "MulOperation" => "Multiply main parameter and vice parameter, then return the result.",
                "DivOperation" => "Divide main parameter by the vice parameter, then return the result",

                "SinOperation" => "Use Math.Sin function to evaluate and return the result",
                "CosOperation" => "Use Math.Cos function to evaluate and return the result",
                "TanOperation" => "Use Math.Tan function to evaluate and return the result",
                "AsinOperation" => "Use Math.Asin function to evaluate and return the result",
                "AcosOperation" => "Use Math.Acos function to evaluate and return the result",
                "AtanOperation" => "Use Math.Atan function to evaluate and return the result",
                "SinhOperation" => "Use Math.Sinh function to evaluate and return the result",
                "CoshOperation" => "Use Math.Cosh function to evaluate and return the result",
                "TanhOperation" => "Use Math.Tanh function to evaluate and return the result",

                "PowOperation" => "Use Math.Pow function to evaluate and return the result",
                "LogOperation" => "Use Math.Log function to evaluate and return the result",
                _ => "Unknown Operation!"
            };
        }
    }
}
