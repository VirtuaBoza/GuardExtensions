using System;
using System.Diagnostics;

namespace GuardExtensions
{
    public static class GuardExtensions
    {
        [DebuggerStepThrough]
        public static T ThrowIfNull<T>(this T obj, string parameterName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            return obj;
        }

        [DebuggerStepThrough]
        public static string ThrowIfNullOrEmpty(this string obj, string parameterName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (string.IsNullOrEmpty(obj))
            {
                throw new ArgumentException("String cannot be empty.", parameterName);
            }

            return obj;
        }

        [DebuggerStepThrough]
        public static string ThrowIfNullOrWhiteSpace(this string obj, string parameterName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (string.IsNullOrWhiteSpace(obj))
            {
                throw new ArgumentException("String cannot be empty or whitespace.", parameterName);
            }

            return obj;
        }
    }
}
