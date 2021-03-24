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

                "SinOperation" => "Returns the sine of the specified angle.  \nMain parameter: the angle.",
                "CosOperation" => "Returns the cosine of the specified angle.  \nMain parameter: the angle.",
                "TanOperation" => "Returns the tangent of the specified angle.  \nMain parameter: the angle.",
                "AsinOperation" => "Returns the angle whose sine is the specified number.\n  Main parameter: A number representing a sine, where d must be greater than or equal to -1, but less than or equal to 1.",
                "AcosOperation" => "Returns the angle whose cosine is the specified number.\n  Main parameter: A number representing a cosine, where d must be greater than or equal to - 1, but less than or equal to 1.",
                "AtanOperation" => "Returns the angle whose tangent is the specified number.\n  Main parameter: A number representing a tangent.",
                "SinhOperation" => "Returns the hyperbolic sine of the specified angle.\n  Main parameter: An angle, measured in radians.",
                "CoshOperation" => "Returns the hyperbolic cosine of the specified angle.\n  Main parameter: An angle, measured in radians.",
                "TanhOperation" => "Returns the hyperbolic tangent of the specified angle.\n  Main parameter: An angle, measured in radians.",

                "PowOperation" => "Returns a specified number raised to the specified power.\n  Main parameter: A double-precision floating-point number to be raised to a power.\n  Vice parameter: A double-precision floating-point number that specifies a power.",
                "LogOperation" => "Returns the logarithm of a specified number in a specified base.\n  Main parameter: The number whose logarithm is to be found.\n  Vice parameter: The base of the logarithm.",
                _ => "Unknown Operation!"
            };
        }
    }
}
