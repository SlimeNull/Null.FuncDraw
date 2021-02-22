using System;
using System.Collections;
using System.Collections.Generic;

namespace Null.Library
{
    public static partial class Lib
    {
        public static IEnumerable<int> Range(int stop)
        {
            return new RangeIterator(stop);
        }
        public static IEnumerable<int> Range(int start, int stop)
        {
            return new RangeIterator(start, stop);
        }
        public static IEnumerable<int> Range(int start, int stop, int step)
        {
            return new RangeIterator(start, stop, step);
        }
        public static IEnumerable<float> Range(float stop)
        {
            return new RangeIterator(stop);
        }
        public static IEnumerable<float> Range(float start, double stop)
        {
            return new RangeIterator(start, stop);
        }
        public static IEnumerable<float> Range(float start, float stop, float step)
        {
            return new RangeIterator(start, stop, step);
        }
        public static IEnumerable<double> Range(double stop)
        {
            return new RangeIterator(stop);
        }
        public static IEnumerable<double> Range(double start, double stop)
        {
            return new RangeIterator(start, stop);
        }
        public static IEnumerable<double> Range(double start, double stop, double step)
        {
            return new RangeIterator(start, stop, step);
        }
    }
    public class RangeIterator : IEnumerable, IEnumerable<int>, IEnumerable<float>, IEnumerable<double>
    {
        double start, stop, step;
        public RangeIterator(double stop)
        {
            double start = 0;
            double step = stop > 0 ? 1 : -1;

            this.start = start;
            this.stop = stop;
            this.step = step;
        }
        public RangeIterator(double start, double stop)
        {
            double step = stop > start ? 1 : -1;

            this.start = start;
            this.stop = stop;
            this.step = step;
        }
        public RangeIterator(double start, double stop, double step)
        {
            this.start = start;
            this.stop = stop;
            this.step = step;
        }

        public IEnumerator GetEnumerator()
        {
            return new RangeEnumerator(start, stop, step);
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new RangeEnumerator(start, stop, step);
        }

        IEnumerator<float> IEnumerable<float>.GetEnumerator()
        {
            return new RangeEnumerator(start, stop, step);
        }

        IEnumerator<double> IEnumerable<double>.GetEnumerator()
        {
            return new RangeEnumerator(start, stop, step);
        }


        public List<int> ToIntegerList()
        {
            List<int> result = new List<int>();
            double current = start;
            for (int i = 0; current < stop; current = start + step * i)
                result.Add((int)current);

            return result;
        }
        public List<float> ToFloatList()
        {
            List<float> result = new List<float>();
            double current = start;
            for (int i = 0; current < stop; current = start + step * i)
                result.Add((float)current);

            return result;
        }
        public List<double> ToDoubleList()
        {
            List<double> result = new List<double>();
            double current = start;
            for (int i = 0; current < stop; current = start + step * i)
                result.Add((double)current);

            return result;
        }
    }
    public class RangeEnumerator : IEnumerator, IEnumerator<int>, IEnumerator<float>, IEnumerator<double>
    {
        int index = -1;
        double start, stop, step, current;
        Func<bool> checkMoveFunc;
        public RangeEnumerator(double start, double stop, double step)
        {
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
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            index++;
            current = start + step * index;
            return checkMoveFunc.Invoke();
        }

        public void Reset()
        {
            index = 0;
            current = start;
        }
    }
}
