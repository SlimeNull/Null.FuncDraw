using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForm.Library
{
    public static class Lib
    {
        //public static IEnumerator Range(double stop)
        //{
        //    return new RangeEnumerator(0, stop, 1);
        //}
        //public static IEnumerator Range(double start, double stop)
        //{
        //    return new RangeEnumerator(start, stop, 1);
        //}
        //public static IEnumerator Range(double start, double stop, double step)
        //{
        //    return new RangeEnumerator(start, stop, step);
        //}

        public static IEnumerable<int> Range(int stop)
        {
            return new RangeInteger(new RangeEnumerator(stop));
        }
        public static IEnumerable<int> Range(int start, int stop)
        {
            return new RangeInteger(new RangeEnumerator(start, stop));
        }
        public static IEnumerable<int> Range(int start, int stop, int step)
        {
            return new RangeInteger(new RangeEnumerator(start, stop, step));
        }
        public static IEnumerable<float> Range(float stop)
        {
            return new RangeFloat(new RangeEnumerator(stop));
        }
        public static IEnumerable<float> Range(float start, double stop)
        {
            return new RangeFloat(new RangeEnumerator(start, stop));
        }
        public static IEnumerable<float> Range(float start, float stop, float step)
        {
            return new RangeFloat(new RangeEnumerator(start, stop, step));
        }
        public static IEnumerable<double> Range(double stop)
        {
            return new RangeDouble(new RangeEnumerator(stop));
        }
        public static IEnumerable<double> Range(double start, double stop)
        {
            return new RangeDouble(new RangeEnumerator(start, stop));
        }
        public static IEnumerable<double> Range(double start, double stop, double step)
        {
            return new RangeDouble(new RangeEnumerator(start, stop, step));
        }
    }
    public class RangeInteger : IEnumerable<int>
    {
        RangeEnumerator enumerator;
        public RangeInteger(RangeEnumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        public IEnumerator GetEnumerator()
        {
            return enumerator;
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return enumerator;
        }
    }
    public class RangeFloat : IEnumerable<float>
    {
        RangeEnumerator enumerator;
        public RangeFloat(RangeEnumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        public IEnumerator GetEnumerator()
        {
            return enumerator;
        }

        IEnumerator<float> IEnumerable<float>.GetEnumerator()
        {
            return enumerator;
        }
    }
    public class RangeDouble : IEnumerable<double>, IEnumerable
    {
        RangeEnumerator enumerator;
        public RangeDouble(RangeEnumerator enumerator)
        {
            this.enumerator = enumerator;
        }

        public IEnumerator GetEnumerator()
        {
            return enumerator;
        }

        IEnumerator<double> IEnumerable<double>.GetEnumerator()
        {
            return enumerator;
        }
    }
    public class RangeEnumerator : IEnumerator, IEnumerator<int>, IEnumerator<float>, IEnumerator<double>
    {
        double start, stop, step, current;
        Func<bool> checkMoveFunc;
        public RangeEnumerator(double stop)
        {
            double start = 0;
            double step = start < stop ? 1 : -1;
            Initialize(start, stop, step);
        }
        public RangeEnumerator(double start, double stop)
        {
            double step = start < stop ? 1 : -1;
            Initialize(start, stop, step);
        }
        public RangeEnumerator(double start, double stop, double step)
        {
            Initialize(start, stop, step);
        }
        void Initialize(double start, double stop, double step)
        {
            if (step == 0)
                throw new ArgumentOutOfRangeException();

            if (start < stop)
            {
                if (step <= 0)
                    step *= -1;
                checkMoveFunc = () => 
                    current < this.stop;
            }
            else if (start > stop)
            {
                if (step >= 0)
                    step *= -1;
                checkMoveFunc = () => 
                    current > this.stop;
            }
            else
            {
                checkMoveFunc = () => false;
            }

            this.start = start;
            this.stop = stop;
            this.step = step;

            this.current = start - step;
        }

        public object Current => current;

        int IEnumerator<int>.Current => (int)current;

        float IEnumerator<float>.Current => (float)current;

        double IEnumerator<double>.Current => current;

        public void Dispose()
        {
            current = start;
        }

        public bool MoveNext()
        {
            current += step;
            return checkMoveFunc();
        }

        public void Reset()
        {
            current = start;
        }
    }
}
