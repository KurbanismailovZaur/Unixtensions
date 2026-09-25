using System;

namespace Unixtensions
{
    public static class IEquatableExtensions
    {
        /// <summary>
        /// Checks whether every element of <paramref name="values"/> equals <paramref name="value"/>.
        /// </summary>
        /// <typeparam name="T">The type of the values to compare.</typeparam>
        /// <param name="value">The value to compare.</param>
        /// <param name="values">The elements to compare against the value.</param>
        /// <returns><see langword="true"/> if every element equals the value; otherwise, <see langword="false"/>. An empty array returns <see langword="true"/>.</returns>
        public static bool EqualsToAll<T>(this T value, params T[] values) where T : IEquatable<T>
        {
            foreach (var candidate in values)
            {
                if (!candidate.Equals(value))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Checks whether at least one element of <paramref name="values"/> equals <paramref name="value"/>.
        /// </summary>
        /// <typeparam name="T">The type of the values to compare.</typeparam>
        /// <param name="value">The value to compare.</param>
        /// <param name="values">The elements to compare against the value.</param>
        /// <returns><see langword="true"/> if at least one element equals the value; otherwise, <see langword="false"/>. An empty array returns <see langword="false"/>.</returns>
        public static bool EqualsToAny<T>(this T value, params T[] values) where T : IEquatable<T>
        {
            foreach (var candidate in values)
            {
                if (candidate.Equals(value))
                    return true;
            }

            return false;
        }
    }
}