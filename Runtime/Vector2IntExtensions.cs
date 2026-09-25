using System.Collections.Generic;
using UnityEngine;

namespace Unixtensions
{
    public static class Vector2IntExtensions
    {
        /// <summary>
        /// Returns a copy of the vector with the selected component replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The component index, from 0 to 1.</param>
        /// <param name="value">The value to assign to the corresponding component.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector2Int With(this Vector2Int vector, int axis, int value)
        {
            vector[axis] = value;
            return vector;
        }

        /// <summary>
        /// Returns a copy of the vector with its x component replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The new x component value.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector2Int WithX(this Vector2Int vector, int x) => With(vector, 0, x);

        /// <summary>
        /// Returns a copy of the vector with its y component replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The new y component value.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector2Int WithY(this Vector2Int vector, int y) => With(vector, 1, y);

        /// <summary>
        /// Returns a copy of the vector with the selected component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The index of the component to negate, from 0 to 1.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector2Int WithNegate(this Vector2Int vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Returns a copy of the vector with its x component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector2Int WithNegateX(this Vector2Int vector) => WithNegate(vector, 0);

        /// <summary>
        /// Returns a copy of the vector with its y component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector2Int WithNegateY(this Vector2Int vector) => WithNegate(vector, 1);

        /// <summary>
        /// Returns a vector with every component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified components negated.</returns>
        public static Vector2Int Negate(this Vector2Int vector) => new(-vector.x, -vector.y);

        /// <summary>
        /// Creates a vector whose components are in YX order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector2Int"/>.</returns>
        public static Vector2Int GetYX(this Vector2Int vector) => new(vector.y, vector.x);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> by inserting a value at the x component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector3Int"/>.</returns>
        public static Vector3Int InsertX(this Vector2Int vector, int x = 0) => new(x, vector.x, vector.y);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> by inserting a value at the y component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector3Int"/>.</returns>
        public static Vector3Int InsertY(this Vector2Int vector, int y = 0) => new(vector.x, y, vector.y);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> by inserting a value at the z component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="z">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector3Int"/>.</returns>
        public static Vector3Int InsertZ(this Vector2Int vector, int z = 0) => new(vector.x, vector.y, z);

        /// <summary>
        /// Gets the index and value of the vector's largest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The zero-based index and value of the largest component.</returns>
        public static (int index, int value) MaxComponent(this Vector2Int vector) => vector.x >= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// Gets the index and value of the vector's smallest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The zero-based index and value of the smallest component.</returns>
        public static (int index, int value) MinComponent(this Vector2Int vector) => vector.x <= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// Creates a vector containing the absolute value of each component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with absolute component values.</returns>
        public static Vector2Int Abs(this Vector2Int vector) => new(Mathf.Abs(vector.x), Mathf.Abs(vector.y));

        /// <summary>
        /// Clamps each component to the specified range.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="min">The lower bound for each component.</param>
        /// <param name="max">The upper bound for each component.</param>
        /// <returns>The vector with clamped components.</returns>
        public static Vector2Int Clamp(this Vector2Int vector, int min, int max)
        {
            return new Vector2Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }

        /// <summary>
        /// Divides each component by the corresponding component of <paramref name="other"/>.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="other">The vector containing the divisors.</param>
        /// <returns>The component-wise integer quotients, truncated toward zero.</returns>
        public static Vector2Int Divide(this Vector2Int vector, Vector2Int other)
        {
            return new Vector2Int(vector.x / other.x, vector.y / other.y);
        }

        /// <summary>
        /// Checks whether the vector's components are equal.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns><see langword="true"/> if the components are equal; otherwise, <see langword="false"/>.</returns>
        public static bool IsUniform(this Vector2Int vector) => vector.x == vector.y;

        /// <summary>
        /// Finds the point in <paramref name="points"/> closest to <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The reference point.</param>
        /// <param name="points">The candidate points, in index order.</param>
        /// <returns>The closest point and its zero-based index; (<see cref="Vector2Int.zero"/>, -1) for an empty list.</returns>
        public static (Vector2Int point, int index) GetClosestPoint(this Vector2Int point, params Vector2Int[] points)
        {
            return GetClosestPoint(point, (IList<Vector2Int>)points);
        }

        /// <summary>
        /// Finds the point in <paramref name="points"/> closest to <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The reference point.</param>
        /// <param name="points">The candidate points, in index order.</param>
        /// <returns>The closest point and its zero-based index; (<see cref="Vector2Int.zero"/>, -1) for an empty list.</returns>
        public static (Vector2Int point, int index) GetClosestPoint(this Vector2Int point, IList<Vector2Int> points)
        {
            var closestIndex = -1;
            var closestPoint = Vector2Int.zero;
            var closestSquaredDistance = double.PositiveInfinity;

            for (var index = 0; index < points.Count; index++)
            {
                var candidate = points[index];
                var deltaX = (double)point.x - candidate.x;
                var deltaY = (double)point.y - candidate.y;
                var squaredDistance = deltaX * deltaX + deltaY * deltaY;

                if (squaredDistance < closestSquaredDistance)
                {
                    closestIndex = index;
                    closestSquaredDistance = squaredDistance;
                    closestPoint = candidate;
                }
            }

            return (closestPoint, closestIndex);
        }

        /// <summary>
        /// Finds the closest point on the infinite line defined by the ray.
        /// </summary>
        /// <remarks>The projection is not clamped to the ray's forward half-line; the distance may be negative.</remarks>
        /// <param name="point">The point to project.</param>
        /// <param name="origin">The line's reference point.</param>
        /// <param name="direction">The line direction, which must be normalized.</param>
        /// <returns>The closest point on the line and its signed distance along the direction from the ray's origin.</returns>
        public static (Vector2 point, float distance) GetClosestPointOnRay(this Vector2Int point, Vector2 origin, Vector2 direction)
        {
            return Vector2Extensions.GetClosestPointOnRay(point, origin, direction);
        }

        /// <summary>
        /// Finds the closest point on the line segment.
        /// </summary>
        /// <param name="point">The point to project.</param>
        /// <param name="start">The start of the segment.</param>
        /// <param name="end">The end of the segment.</param>
        /// <returns>The closest point on the segment and the distance along the segment from <paramref name="start"/> to that point.</returns>
        public static (Vector2 point, float distance) GetClosestPointOnSegment(this Vector2Int point, Vector2 start, Vector2 end)
        {
            return Vector2Extensions.GetClosestPointOnSegment(point, start, end);
        }
    }
}
