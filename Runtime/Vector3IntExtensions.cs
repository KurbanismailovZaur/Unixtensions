using System.Collections.Generic;
using UnityEngine;

namespace Unixtensions
{
    public static class Vector3IntExtensions
    {
        /// <summary>
        /// Sets the specified component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The index of the first component (0 = X, 1 = Y, 2 = Z).</param>
        /// <param name="value">The value to assign to the specified component.</param>
        /// <returns>A copy of the vector with the specified component values.</returns>
        public static Vector3Int With(this Vector3Int vector, int axis, int value)
        {
            vector[axis] = value;
            return vector;
        }

        /// <summary>
        /// Sets the X component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <returns>A copy of the vector with the specified component values.</returns>
        public static Vector3Int WithX(this Vector3Int vector, int x) => With(vector, 0, x);

        /// <summary>
        /// Sets the Y component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <returns>A copy of the vector with the specified component values.</returns>
        public static Vector3Int WithY(this Vector3Int vector, int y) => With(vector, 1, y);

        /// <summary>
        /// Sets the Z component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <returns>A copy of the vector with the specified component values.</returns>
        public static Vector3Int WithZ(this Vector3Int vector, int z) => With(vector, 2, z);

        /// <summary>
        /// Sets the specified components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the first component (0 = X, 1 = Y, 2 = Z).</param>
        /// <param name="value1">The value to assign to the first specified component.</param>
        /// <param name="axis2">The index of the second component (0 = X, 1 = Y, 2 = Z).</param>
        /// <param name="value2">The value to assign to the second specified component.</param>
        /// <returns>A copy of the vector with the specified component values.</returns>
        public static Vector3Int With(this Vector3Int vector, int axis1, int value1, int axis2, int value2)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;

            return vector;
        }

        /// <summary>
        /// Sets the X and Y components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <returns>A copy of the vector with the specified component values.</returns>
        public static Vector3Int WithXY(this Vector3Int vector, int x, int y) => With(vector, 0, x, 1, y);

        /// <summary>
        /// Sets the X and Y components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the X and Y components, respectively.</param>
        /// <returns>A <see cref="Vector3Int"/> containing the components of the modified vector.</returns>
        public static Vector3Int WithXY(this Vector3Int vector, Vector2Int value) => With(vector, 0, value.x, 1, value.y);

        /// <summary>
        /// Sets the X and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <returns>A copy of the vector with the specified component values.</returns>
        public static Vector3Int WithXZ(this Vector3Int vector, int x, int z) => With(vector, 0, x, 2, z);

        /// <summary>
        /// Sets the X and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the X and Z components, respectively.</param>
        /// <returns>A <see cref="Vector3Int"/> containing the components of the modified vector.</returns>
        public static Vector3Int WithXZ(this Vector3Int vector, Vector2Int value) => With(vector, 0, value.x, 2, value.y);

        /// <summary>
        /// Sets the Y and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <returns>A copy of the vector with the specified component values.</returns>
        public static Vector3Int WithYZ(this Vector3Int vector, int y, int z) => With(vector, 1, y, 2, z);

        /// <summary>
        /// Sets the Y and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the Y and Z components, respectively.</param>
        /// <returns>A <see cref="Vector3Int"/> containing the components of the modified vector.</returns>
        public static Vector3Int WithYZ(this Vector3Int vector, Vector2Int value) => With(vector, 1, value.x, 2, value.y);

        /// <summary>
        /// Negates the specified component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The index of the first component (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector3Int WithNegate(this Vector3Int vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Negates the X component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector3Int WithNegateX(this Vector3Int vector) => WithNegate(vector, 0);

        /// <summary>
        /// Negates the Y component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector3Int WithNegateY(this Vector3Int vector) => WithNegate(vector, 1);

        /// <summary>
        /// Negates the Z component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector3Int WithNegateZ(this Vector3Int vector) => WithNegate(vector, 2);

        /// <summary>
        /// Negates the specified components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the first component (0 = X, 1 = Y, 2 = Z).</param>
        /// <param name="axis2">The index of the second component (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector3Int WithNegate(this Vector3Int vector, int axis1, int axis2)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];

            return vector;
        }

        /// <summary>
        /// Negates the X and Y components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector3Int WithNegateXY(this Vector3Int vector) => vector.WithNegate(0, 1);

        /// <summary>
        /// Negates the X and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector3Int WithNegateXZ(this Vector3Int vector) => vector.WithNegate(0, 2);

        /// <summary>
        /// Negates the Y and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector3Int WithNegateYZ(this Vector3Int vector) => vector.WithNegate(1, 2);

        /// <summary>
        /// Returns a vector with each component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The negated vector.</returns>
        public static Vector3Int Negate(this Vector3Int vector) => new(-vector.x, -vector.y, -vector.z);

        /// <summary>
        /// Creates a <see cref="Vector2Int"/> from the specified components in the given order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the source component to use as the X component (0 = X, 1 = Y, 2 = Z).</param>
        /// <param name="axis2">The index of the source component to use as the Y component (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>A <see cref="Vector2Int"/> containing the selected components in the specified order.</returns>
        public static Vector2Int Get(this Vector3Int vector, int axis1, int axis2) => new(vector[axis1], vector[axis2]);

        /// <summary>
        /// Creates a <see cref="Vector2Int"/> from the X and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2Int"/> containing the selected components in the specified order.</returns>
        public static Vector2Int GetXY(this Vector3Int vector) => Get(vector, 0, 1);

        /// <summary>
        /// Creates a <see cref="Vector2Int"/> from the X and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2Int"/> containing the selected components in the specified order.</returns>
        public static Vector2Int GetXZ(this Vector3Int vector) => Get(vector, 0, 2);

        /// <summary>
        /// Creates a <see cref="Vector2Int"/> from the Y and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2Int"/> containing the selected components in the specified order.</returns>
        public static Vector2Int GetYX(this Vector3Int vector) => Get(vector, 1, 0);

        /// <summary>
        /// Creates a <see cref="Vector2Int"/> from the Y and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2Int"/> containing the selected components in the specified order.</returns>
        public static Vector2Int GetYZ(this Vector3Int vector) => Get(vector, 1, 2);

        /// <summary>
        /// Creates a <see cref="Vector2Int"/> from the Z and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2Int"/> containing the selected components in the specified order.</returns>
        public static Vector2Int GetZX(this Vector3Int vector) => Get(vector, 2, 0);

        /// <summary>
        /// Creates a <see cref="Vector2Int"/> from the Z and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2Int"/> containing the selected components in the specified order.</returns>
        public static Vector2Int GetZY(this Vector3Int vector) => Get(vector, 2, 1);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> from the specified components in the given order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the source component to use as the X component (0 = X, 1 = Y, 2 = Z).</param>
        /// <param name="axis2">The index of the source component to use as the Y component (0 = X, 1 = Y, 2 = Z).</param>
        /// <param name="axis3">The index of the source component to use as the Z component (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>A <see cref="Vector3Int"/> containing the selected components in the specified order.</returns>
        public static Vector3Int Get(this Vector3Int vector, int axis1, int axis2, int axis3) => new(vector[axis1], vector[axis2], vector[axis3]);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> from the X, Z, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3Int"/> containing the selected components in the specified order.</returns>
        public static Vector3Int GetXZY(this Vector3Int vector) => Get(vector, 0, 2, 1);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> from the Y, X, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3Int"/> containing the selected components in the specified order.</returns>
        public static Vector3Int GetYXZ(this Vector3Int vector) => Get(vector, 1, 0, 2);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> from the Y, Z, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3Int"/> containing the selected components in the specified order.</returns>
        public static Vector3Int GetYZX(this Vector3Int vector) => Get(vector, 1, 2, 0);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> from the Z, X, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3Int"/> containing the selected components in the specified order.</returns>
        public static Vector3Int GetZXY(this Vector3Int vector) => Get(vector, 2, 0, 1);

        /// <summary>
        /// Creates a <see cref="Vector3Int"/> from the Z, Y, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3Int"/> containing the selected components in the specified order.</returns>
        public static Vector3Int GetZYX(this Vector3Int vector) => Get(vector, 2, 1, 0);

        private static void Compare(Vector3Int vector, ref int index, int compareIndex, int result)
        {
            if (vector[compareIndex].CompareTo(vector[index]) == result)
                index = compareIndex;
        }

        private static int CompareAllComponents(Vector3Int vector, int result)
        {
            var index = 0;

            Compare(vector, ref index, 1, result);
            Compare(vector, ref index, 2, result);

            return index;
        }

        /// <summary>
        /// Gets the index and value of the largest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The index of the first largest component and its value.</returns>
        public static (int index, int value) MaxComponent(this Vector3Int vector)
        {
            var index = CompareAllComponents(vector, 1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Gets the index and value of the smallest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The index of the first smallest component and its value.</returns>
        public static (int index, int value) MinComponent(this Vector3Int vector)
        {
            var index = CompareAllComponents(vector, -1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Creates a vector containing the absolute value of each component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A vector with the absolute component values.</returns>
        public static Vector3Int Abs(this Vector3Int vector) => new(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));

        /// <summary>
        /// Creates a vector with each component clamped to the specified range.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="min">The minimum allowed component value.</param>
        /// <param name="max">The maximum allowed component value.</param>
        /// <returns>A vector with each component clamped to the range.</returns>
        public static Vector3Int Clamp(this Vector3Int vector, int min, int max)
        {
            return new Vector3Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), Mathf.Clamp(vector.z, min, max));
        }

        /// <summary>
        /// Divides each component by the corresponding component of <paramref name="other"/>.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="other">The vector containing the divisor for each component.</param>
        /// <returns>A vector containing the component-wise quotients. Integer division truncates each quotient toward zero.</returns>
        public static Vector3Int Divide(this Vector3Int vector, Vector3Int other)
        {
            return new Vector3Int(vector.x / other.x, vector.y / other.y, vector.z / other.z);
        }

        /// <summary>
        /// Checks whether all components are equal.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns><see langword="true"/> if all components are equal; otherwise, <see langword="false"/>.</returns>
        public static bool IsUniform(this Vector3Int vector) => vector.x == vector.y && vector.y == vector.z;

        /// <summary>
        /// Gets the closest point in <paramref name="points"/> and its index.
        /// </summary>
        /// <param name="point">The point from which distances are measured.</param>
        /// <param name="points">The candidate points to search.</param>
        /// <returns>The closest point and its zero-based index; for an empty list, <see cref="Vector3Int.zero"/> and -1.</returns>
        public static (Vector3Int point, int index) GetClosestPoint(this Vector3Int point, params Vector3Int[] points)
        {
            return GetClosestPoint(point, (IList<Vector3Int>)points);
        }

        /// <summary>
        /// Gets the closest point in <paramref name="points"/> and its index.
        /// </summary>
        /// <param name="point">The point from which distances are measured.</param>
        /// <param name="points">The candidate points to search.</param>
        /// <returns>The closest point and its zero-based index; for an empty list, <see cref="Vector3Int.zero"/> and -1.</returns>
        public static (Vector3Int point, int index) GetClosestPoint(this Vector3Int point, IList<Vector3Int> points)
        {
            var closestIndex = -1;
            var closestPoint = Vector3Int.zero;
            var closestSquaredDistance = double.PositiveInfinity;

            for (var index = 0; index < points.Count; index++)
            {
                var candidate = points[index];
                var deltaX = (double)point.x - candidate.x;
                var deltaY = (double)point.y - candidate.y;
                var deltaZ = (double)point.z - candidate.z;
                var squaredDistance = deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ;

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
        /// Projects the point onto the infinite line defined by an origin and a direction.
        /// </summary>
        /// <param name="point">The point to project.</param>
        /// <param name="origin">A point on the line.</param>
        /// <param name="direction">The normalized direction of the line.</param>
        /// <returns>The closest point on the line and its signed distance from <paramref name="origin"/> along <paramref name="direction"/>.</returns>
        public static (Vector3 point, float distance) GetClosestPointOnRay(this Vector3Int point, Vector3 origin, Vector3 direction)
        {
            return Vector3Extensions.GetClosestPointOnRay(point, origin, direction);
        }

        /// <summary>
        /// Gets the closest point on the line segment.
        /// </summary>
        /// <param name="point">The point from which the closest point is determined.</param>
        /// <param name="start">The start of the line segment.</param>
        /// <param name="end">The end of the line segment.</param>
        /// <returns>The closest point on the segment and its distance from <paramref name="start"/> along the segment.</returns>

        public static (Vector3 point, float distance) GetClosestPointOnSegment(this Vector3Int point, Vector3 start, Vector3 end)
        {
            return Vector3Extensions.GetClosestPointOnSegment(point, start, end);
        }
    }
}
