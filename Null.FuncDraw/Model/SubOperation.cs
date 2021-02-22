﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Null.FuncDraw.Model
{
    public interface ISubOperation
    {
        SOParamType MainParamType { get; set; }
        SOParamType ViceParamType { get; set; }
        string MainParamSource { get; set; }
        string ViceParamSource { get; set; }
        void Initialize(FuncDataContainer dataContainer);
        double GetMainParam();
        double GetViceParam();
        Func<double> GetFunc();
    }
    public enum SOParamType
    {
        FromLast, FromVariable, FromConstant
    }
    public abstract class SubOperation : ISubOperation                      // 所有操作的基类
    {
        private SOParamType mainParamType;
        private SOParamType viceParamType;
        protected FuncDataContainer dataContainer;

        protected Func<double> getMainParamFunc = () => 0;
        protected Func<double> getViceParamFunc = () => 0;

        public SubOperation()
        {
            MainParamType = SOParamType.FromLast;
            ViceParamType = SOParamType.FromConstant;
        }

        public SOParamType MainParamType
        {
            get => mainParamType;
            set
            {
                mainParamType = value;
                getMainParamFunc = value switch
                {
                    SOParamType.FromLast => () => dataContainer.LastValue,
                    SOParamType.FromVariable => () => dataContainer.Variables.TryGetValue(MainParamSource, out double result) ? result : 0,
                    SOParamType.FromConstant => double.TryParse(MainParamSource, out double result) ? () => result : () => 0,
                    _ => () => 0,
                };
            }
        }
        public SOParamType ViceParamType
        {
            get => viceParamType;
            set
            {
                viceParamType = value;
                getViceParamFunc = value switch
                {
                    SOParamType.FromLast => () => dataContainer.LastValue,
                    SOParamType.FromVariable => () => dataContainer.Variables.TryGetValue(ViceParamSource, out double result) ? result : 0,
                    SOParamType.FromConstant => double.TryParse(ViceParamSource, out double result) ? () => result : () => 0,
                    _ => () => 0
                };
            }
        }
        public virtual string MainParamSource { get; set; } = string.Empty;
        public virtual string ViceParamSource { get; set; } = string.Empty;

        public void Initialize(FuncDataContainer dataContainer)
        {
            this.dataContainer = dataContainer;
        }

        public double GetMainParam()
        {
            return getMainParamFunc.Invoke();
        }
        public double GetViceParam()
        {
            return getViceParamFunc.Invoke();
        }

        public abstract Func<double> GetFunc();
    }
    public class SubOperationOption
    {
        public string OperationName;
        public SOParamType MainParamType;
        public SOParamType ViceParamType;
        public string MainParamSource;
        public string ViceParamSource;
    }
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
    }
    public class ModifyValue : SubOperation                                 // 赋值与返回值
    {
        public override Func<double> GetFunc()
        {
            return () =>
            {
                double main = getMainParamFunc.Invoke();
                dataContainer.Variables[ViceParamSource] = main;
                return main;
            };
        }
    }
    public class PlusOperation : SubOperation                       // 加法
    {
        public override Func<double> GetFunc()
        {
            return () => getMainParamFunc.Invoke() + getViceParamFunc.Invoke();
        }
    }
    public class MinusOperation : SubOperation                      // 减法
    {
        public override Func<double> GetFunc()
        {
            return () => getMainParamFunc.Invoke() - getViceParamFunc.Invoke();
        }
    }
    public class MulOperation : SubOperation                        // 乘法
    {
        public override Func<double> GetFunc()
        {
            return () => getMainParamFunc.Invoke() * getViceParamFunc.Invoke();
        }
    }
    public class DivOperation : SubOperation                        // 除法
    {
        public override Func<double> GetFunc()
        {
            return () => getMainParamFunc.Invoke() / getViceParamFunc.Invoke();
        }
    }
    public class PowOperation : SubOperation                        // 次方
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Pow(getMainParamFunc.Invoke(), getViceParamFunc.Invoke());
        }
    }
    public class LogOperation : SubOperation                        // 次方
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Log(getMainParamFunc.Invoke(), getViceParamFunc.Invoke());
        }
    }
    public class SinOperation : SubOperation                                // Sin函数
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Sin(getMainParamFunc.Invoke());
        }
    }
    public class CosOperation : SubOperation                                // Cos函数
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Cos(getMainParamFunc.Invoke());
        }
    }
    public class TanOperation : SubOperation                                // Tan函数
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Tan(getMainParamFunc.Invoke());
        }
    }
    public class AsinOperation : SubOperation                               // Asin函数
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Asin(getMainParamFunc.Invoke());
        }
    }
    public class AcosOperation : SubOperation                               // Acos函数
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Acos(getMainParamFunc.Invoke());
        }
    }
    public class AtanOperation : SubOperation                               // Atan函数
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Atan(getMainParamFunc.Invoke());
        }
    }
    public class SinhOperation : SubOperation                               // 
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Sinh(getMainParamFunc.Invoke());
        }
    }
    public class CoshOperation : SubOperation
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Cosh(getMainParamFunc.Invoke());
        }
    }
    public class TanhOperation : SubOperation
    {
        public override Func<double> GetFunc()
        {
            return () => Math.Tanh(getMainParamFunc.Invoke());
        }
    }
}
