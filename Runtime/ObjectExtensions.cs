namespace Unixtensions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Checks whether every element of <paramref name="objects"/> equals <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The value to compare.</param>
        /// <param name="objects">The elements to compare against the value.</param>
        /// <returns><see langword="true"/> if every element equals the value; otherwise, <see langword="false"/>. An empty array returns <see langword="true"/>.</returns>
        public static bool EqualsToAll(this object obj, params object[] objects)
        {
            foreach (var candidate in objects)
            {
                if (!candidate.Equals(obj))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Checks whether at least one element of <paramref name="objects"/> equals <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The value to compare.</param>
        /// <param name="objects">The elements to compare against the value.</param>
        /// <returns><see langword="true"/> if at least one element equals the value; otherwise, <see langword="false"/>. An empty array returns <see langword="false"/>.</returns>
        public static bool EqualsToAny(this object obj, params object[] objects)
        {
            foreach (var candidate in objects)
            {
                if (candidate.Equals(obj))
                    return true;
            }

            return false;
        }
    }
}