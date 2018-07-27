using System;
using System.Diagnostics;

namespace GuardExtensions
{
    public static class GuardExtensions
    {
        /// <summary>
        /// An extension method which throws an ArgumentNullException if the object is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="parameterName">The name of the parameter being checked. Hint: Use nameof(param)</param>
        /// <returns>The same object if not null.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        [DebuggerStepThrough]
        public static T ThrowIfNull<T>(this T obj, string parameterName) where T : class
        {
            if (obj == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            return obj;
        }

        /// <summary>
        /// An extension method which throws an ArgumentNullException if the string is null or an ArgumentException if empty.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="parameterName">The name of the parameter being checked. Hint: Use nameof(param)</param>
        /// <returns>The same object if not null or empty.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// An extension method which throws an ArgumentNullException if the string is null or an ArgumentException if empty or whitespace.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="parameterName">The name of the parameter being checked. Hint: Use nameof(param)</param>
        /// <returns>The same object if not null, empty, or whitespace.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
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
