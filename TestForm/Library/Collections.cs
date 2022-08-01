using System;
using System.Collections;
using System.Collections.Generic;

namespace Null.Library
{
    public static partial class Lib
    {
        public static IEnumerable ConcatEnumerable(IEnumerable enumerable1, IEnumerable enumerable2)
        {
            return new ComplexIterator<object>(enumerable1, enumerable2);
        }
        public static IEnumerable<T> ConcatEnumerable<T>(IEnumerable<T> enumerable1, IEnumerable<T> enumerable2)
        {
            return new ComplexIterator<T>(enumerable1, enumerable2);
        }
        public static IEnumerable ConcatEnumerable(params IEnumerable[] enumerators)
        {
            if (enumerators.Length == 0)
                return null;

            IEnumerable result = enumerators[0];
            for (int i = 1, len = enumerators.Length; i < len; i++)
                result = ConcatEnumerable(result, enumerators[i]);

            return result;
        }
        public static IEnumerable<T> ConcatEnumerable<T>(params IEnumerable<T>[] enumerators)
        {
            if (enumerators.Length == 0)
                return null;

            IEnumerable<T> result = enumerators[0];
            for (int i = 1, len = enumerators.Length; i < len; i++)
                result = ConcatEnumerable(result, enumerators[i]);

            return result;
        }
    }
    class ComplexEnumerator : IEnumerator
    {
        public ComplexEnumerator(IEnumerator enumerator1, IEnumerator enumerator2)
        {
            currentFunc = () => enumerator1.Current;
            moveNextFunc = () => enumerator1.MoveNext() || (enumerator2.MoveNext() &
                ((Func<bool>)(() =>
                {
                    currentFunc = () => enumerator2.Current;
                    moveNextFunc = () => enumerator2.MoveNext();
                    return true;
                })).Invoke());
            resetAction = () =>
            {
                enumerator1.Reset();
                enumerator2.Reset();
                currentFunc = () => enumerator1.Current;
                moveNextFunc = () => enumerator1.MoveNext() || (enumerator2.MoveNext() &
                    ((Func<bool>)(() =>
                    {
                        currentFunc = () => enumerator2.Current;
                        moveNextFunc = () => enumerator2.MoveNext();
                        return true;
                    })).Invoke());
            };
        }
        Func<object> currentFunc;
        Func<bool> moveNextFunc;

        Action resetAction;

        public object Current => currentFunc.Invoke();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            return moveNextFunc.Invoke();
        }

        public void Reset()
        {
            resetAction.Invoke();
        }
    }
    class ComplexIterator<T> : IEnumerable, IEnumerable<T>
    {
        IEnumerable<T> iter1, iter2;
        public ComplexIterator(IEnumerable iter1, IEnumerable iter2)
        {
            this.iter1 = (IEnumerable<T>)iter1;
            this.iter2 = (IEnumerable<T>)iter2;
        }
        public ComplexIterator(IEnumerable<T> iter1, IEnumerable<T> iter2)
        {
            this.iter1 = iter1;
            this.iter2 = iter2;
        }

        public IEnumerator GetEnumerator()
        {
            return new ComplexEnumerator(iter1.GetEnumerator(), iter2.GetEnumerator());
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new ComplexEnumerator<T>(iter1.GetEnumerator(), iter2.GetEnumerator());
        }
    }
    class ComplexEnumerator<T> : IEnumerator, IEnumerator<T>
    {
        public ComplexEnumerator(IEnumerator<T> enumerator1, IEnumerator<T> enumerator2)
        {
            currentFunc = () => enumerator1.Current;
            moveNextFunc = () => enumerator1.MoveNext() || (enumerator2.MoveNext() &
                ((Func<bool>)(() =>
                {
                    currentFunc = () => enumerator2.Current;
                    moveNextFunc = () => enumerator2.MoveNext();
                    return true;
                })).Invoke());
            resetAction = () =>
            {
                enumerator1.Reset();
                enumerator2.Reset();
                currentFunc = () => enumerator1.Current;
                moveNextFunc = () => enumerator1.MoveNext() || (enumerator2.MoveNext() &
                    ((Func<bool>)(() =>
                    {
                        currentFunc = () => enumerator2.Current;
                        moveNextFunc = () => enumerator2.MoveNext();
                        return true;
                    })).Invoke());
            };
        }
        Func<T> currentFunc;
        Func<bool> moveNextFunc;

        Action resetAction;

        public object Current => currentFunc.Invoke();

        T IEnumerator<T>.Current => currentFunc.Invoke();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            return moveNextFunc.Invoke();
        }

        public void Reset()
        {
            resetAction.Invoke();
        }
    }
}
