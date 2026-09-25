using System;

namespace Unixtensions
{
    public static class IComparableExtensions
    {
        /// <summary>
        /// Checks whether <paramref name="value"/> lies within the specified interval.
        /// </summary>
        /// <typeparam name="T">The type of the values to compare.</typeparam>
        /// <remarks>Reversed endpoints are swapped together with their inclusion flags.</remarks>
        /// <param name="value">The value to check.</param>
        /// <param name="a">The first endpoint.</param>
        /// <param name="b">The second endpoint.</param>
        /// <param name="aInclusive">Whether to include the first endpoint.</param>
        /// <param name="bInclusive">Whether to include the second endpoint.</param>
        /// <returns><see langword="true"/> if the value lies within the interval with the specified endpoint inclusion; otherwise, <see langword="false"/>.</returns>
        public static bool IsBetween<T>(this T value, T a, T b, bool aInclusive = true, bool bInclusive = true) where T: IComparable
        {
            if (a.CompareTo(b) > 0)
            {
                (a, b) = (b, a);
                (aInclusive, bInclusive) = (bInclusive, aInclusive);
            }

            int lower = value.CompareTo(a);
            if (lower < 0 || (lower == 0 && !aInclusive))
                return false;

            int upper = value.CompareTo(b);
            return upper < 0 || (upper == 0 && bInclusive);
        }
    }
}