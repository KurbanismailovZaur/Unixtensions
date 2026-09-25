using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Unixtensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Linearly maps a value from one range to another without clamping.
        /// </summary>
        /// <param name="value">The value to remap.</param>
        /// <param name="min1">The start of the source range.</param>
        /// <param name="max1">The end of the source range.</param>
        /// <param name="min2">The start of the target range.</param>
        /// <param name="max2">The end of the target range.</param>
        /// <returns>The remapped value.</returns>
        public static double Remap(this double value, double min1, double max1, double min2, double max2)
        {
            return min2 + (value - min1) * (max2 - min2) / (max1 - min1);
        }

        /// <summary>
        /// Checks whether two values are approximately equal using a relative tolerance of 1E-12.
        /// </summary>
        /// <remarks>
        /// The absolute difference must be less than the greater of 1E-12 times the larger absolute value
        /// and eight times <see cref="Double.Epsilon"/>. Comparisons involving NaN or infinity return false.
        /// </remarks>
        /// <param name="value">The first value to compare.</param>
        /// <param name="other">The second value to compare.</param>
        /// <returns><see langword="true"/> if the values are approximately equal; otherwise, <see langword="false"/>.</returns>
        public static bool Approx(this double value, double other)
        {
            return Math.Abs(value - other) < Math.Max(1E-12 * Math.Max(Math.Abs(value), Math.Abs(other)), double.Epsilon * 8);
        }

        /// <summary>
        /// Returns <paramref name="value"/> with its sign randomly preserved or reversed.
        /// </summary>
        /// <param name="value">The value whose sign is randomized.</param>
        /// <returns>The original value or its negation.</returns>
        public static double WithRandomSign(this double value) => value * (Random.Range(0, 2) * 2 - 1);
    }
}