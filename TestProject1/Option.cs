using System.Diagnostics.CodeAnalysis;

namespace Monad
{
    public static class Option
    {
        public static Option<T> Empty<T>() where T : class
        {
            return new Option<T> ();
        }

        internal static Option<T> FromValue<T>(T someClass) where T : class
        {
            return new Option<T>(someClass);
        }
    }

    public struct Option<T> where T: class
    {
        private T _value;
        public Option(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }

        public T Value
        { 
            get
            {
                if (_value == null)
                    throw new InvalidOperationException();

                return _value; 
            } 
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is Option<T>)
            {
                var option = (Option<T>)obj;

                return HasValue
                    ? option.HasValue && _value.Equals(option.Value)
                    : option.HasValue == false;
            }

            return false;
        }

        internal T? ValueOr(Func<T> or)
        {
            if (_value == null)
            {
                return or();
            }

            return _value;
        }

        internal Option<K> Select<K>(Func<T, K> select) where K : class
        {
            if (_value != null)
                return new Option<K>(select(_value));

            return new Option<K>();
        }

        public static bool operator ==(Option<T> left, Option<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Option<T> left, Option<T> right)
        {
            return !(left == right);
        }
    }
}