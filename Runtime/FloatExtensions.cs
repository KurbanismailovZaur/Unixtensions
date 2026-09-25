using UnityEngine;

namespace Unixtensions
{
    public static class FloatExtensions
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
        public static float Remap(this float value, float min1, float max1, float min2, float max2)
        {
            return min2 + (value - min1) * (max2 - min2) / (max1 - min1);
        }

        /// <summary>
        /// Checks whether two values are approximately equal using <see cref="Mathf.Approximately"/>.
        /// </summary>
        /// <param name="value">The first value to compare.</param>
        /// <param name="other">The second value to compare.</param>
        /// <returns><see langword="true"/> if the values are approximately equal; otherwise, <see langword="false"/>.</returns>
        public static bool Approx(this float value, float other) => Mathf.Approximately(value, other);
        
        /// <summary>
        /// Returns <paramref name="value"/> with its sign randomly preserved or reversed.
        /// </summary>
        /// <param name="value">The value whose sign is randomized.</param>
        /// <returns>The original value or its negation.</returns>
        public static float WithRandomSign(this float value) => value * (Random.Range(0, 2) * 2 - 1);
    }
}
