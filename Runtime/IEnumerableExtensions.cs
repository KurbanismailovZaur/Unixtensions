using System;
using System.Collections.Generic;
using System.Linq;

namespace Unixtensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Returns the distinct elements of <paramref name="enumerable"/> that are not in <paramref name="elements"/>.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="elements">Elements to exclude.</param>
        /// <returns>A list of distinct elements excluding the specified elements.</returns>
        public static List<T> Except<T>(this IEnumerable<T> enumerable, params T[] elements) => enumerable.Except((IEnumerable<T>)elements).ToList();

        /// <summary>
        /// Represents an enumerable as a string in the format <c>[a, b, c, ...]</c>.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>A string representation of <paramref name="enumerable"/>.</returns>
        public static string AsDisplayString<T>(this IEnumerable<T> enumerable) => $"[{string.Join(", ", enumerable)}]";

        /// <summary>
        /// Loops over all elements.
        /// </summary>
        /// <typeparam name="T">Element type.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="action">Action to invoke for each element.</param>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var element in enumerable)
                action(element);
        }
    }
}