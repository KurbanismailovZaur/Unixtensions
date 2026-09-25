using System.Collections.Generic;
using UnityEngine;

namespace Unixtensions
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// Returns a copy of the vector with the selected component replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The component index, from 0 to 1.</param>
        /// <param name="value">The value to assign to the corresponding component.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector2 With(this Vector2 vector, int axis, float value)
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
        public static Vector2 WithX(this Vector2 vector, float x) => With(vector, 0, x);

        /// <summary>
        /// Returns a copy of the vector with its y component replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The new y component value.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector2 WithY(this Vector2 vector, float y) => With(vector, 1, y);

        /// <summary>
        /// Returns a copy of the vector with the selected component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The index of the component to negate, from 0 to 1.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector2 WithNegate(this Vector2 vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Returns a copy of the vector with its x component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector2 WithNegateX(this Vector2 vector) => WithNegate(vector, 0);

        /// <summary>
        /// Returns a copy of the vector with its y component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector2 WithNegateY(this Vector2 vector) => WithNegate(vector, 1);

        /// <summary>
        /// Returns a vector with every component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified components negated.</returns>
        public static Vector2 Negate(this Vector2 vector) => new(-vector.x, -vector.y);

        /// <summary>
        /// Creates a vector whose components are in YX order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector2"/>.</returns>
        public static Vector2 GetYX(this Vector2 vector) => new(vector.y, vector.x);

        /// <summary>
        /// Creates a <see cref="Vector3"/> by inserting a value at the x component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 InsertX(this Vector2 vector, float x = 0) => new(x, vector.x, vector.y);

        /// <summary>
        /// Creates a <see cref="Vector3"/> by inserting a value at the y component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 InsertY(this Vector2 vector, float y = 0) => new(vector.x, y, vector.y);

        /// <summary>
        /// Creates a <see cref="Vector3"/> by inserting a value at the z component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="z">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 InsertZ(this Vector2 vector, float z = 0) => new(vector.x, vector.y, z);
        
        /// <summary>
        /// Gets the index and value of the vector's largest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The zero-based index and value of the largest component.</returns>
        public static (int index, float value) MaxComponent(this Vector2 vector) => vector.x >= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// Gets the index and value of the vector's smallest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The zero-based index and value of the smallest component.</returns>
        public static (int index, float value) MinComponent(this Vector2 vector) => vector.x <= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// Linearly maps each component from one range to another without clamping.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="min1">The start of the source range.</param>
        /// <param name="max1">The end of the source range.</param>
        /// <param name="min2">The start of the target range.</param>
        /// <param name="max2">The end of the target range.</param>
        /// <returns>The vector with remapped components.</returns>
        public static Vector2 Remap(this Vector2 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector2(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2));
        }

        /// <summary>
        /// Creates a vector containing the absolute value of each component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with absolute component values.</returns>
        public static Vector2 Abs(this Vector2 vector) => new(Mathf.Abs(vector.x), Mathf.Abs(vector.y));

        /// <summary>
        /// Clamps each component to the specified range.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="min">The lower bound for each component.</param>
        /// <param name="max">The upper bound for each component.</param>
        /// <returns>The vector with clamped components.</returns>
        public static Vector2 Clamp(this Vector2 vector, float min, float max)
        {
            return new Vector2(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }

        /// <summary>
        /// Clamps each component to the inclusive range from 0 to 1.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with clamped components.</returns>
        public static Vector2 Clamp01(this Vector2 vector)
        {
            return new Vector2(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y));
        }

        /// <summary>
        /// Divides each component by the corresponding component of <paramref name="other"/>.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="other">The vector containing the divisors.</param>
        /// <returns>The vector containing the component-wise quotients.</returns>
        public static Vector2 Divide(this Vector2 vector, Vector2 other) => vector / other;

        /// <summary>
        /// Checks whether adjacent vector components are approximately equal.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns><see langword="true"/> if each adjacent pair is approximately equal; otherwise, <see langword="false"/>.</returns>
        public static bool IsUniform(this Vector2 vector) => vector.x.Approx(vector.y);

        /// <summary>
        /// Calculates one point of a roughly evenly distributed set inside a disk centered at the origin.
        /// </summary>
        /// <param name="index">The zero-based point index, less than the total point count.</param>
        /// <param name="radius">The disk radius.</param>
        /// <param name="count">The total number of points, which must be positive.</param>
        /// <returns>The calculated point.</returns>
        public static Vector2 EventlyDistributedPointOnCircle(int index, float radius, int count)
        {
            var k = index + 0.5f;
            var r = Mathf.Sqrt((k) / count);
            var theta = Mathf.PI * (1f + Mathf.Sqrt(5f)) * k;

            var x = r * Mathf.Cos(theta) * radius;
            var y = r * Mathf.Sin(theta) * radius;

            return new Vector2(x, y);
        }

        /// <summary>
        /// Finds the point in <paramref name="points"/> closest to <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The reference point.</param>
        /// <param name="points">The candidate points, in index order.</param>
        /// <returns>The closest point and its zero-based index; (<see cref="Vector2.zero"/>, -1) for an empty list.</returns>
        public static (Vector2 point, int index) GetClosestPoint(this Vector2 point, params Vector2[] points)
        {
            return GetClosestPoint(point, (IList<Vector2>)points);
        }

        /// <summary>
        /// Finds the point in <paramref name="points"/> closest to <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The reference point.</param>
        /// <param name="points">The candidate points, in index order.</param>
        /// <returns>The closest point and its zero-based index; (<see cref="Vector2.zero"/>, -1) for an empty list.</returns>
        public static (Vector2 point, int index) GetClosestPoint(this Vector2 point, IList<Vector2> points)
        {
            var closestIndex = -1;
            var closestPoint = Vector2.zero;
            var closestSquaredDistance = double.PositiveInfinity;

            for (var index = 0; index < points.Count; index++)
            {
                var candidate = points[index];
                var dx = (double)point.x - candidate.x;
                var dy = (double)point.y - candidate.y;
                var squaredDistance = dx * dx + dy * dy;

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
        public static (Vector2 point, float distance) GetClosestPointOnRay(this Vector2 point, Vector2 origin, Vector2 direction)
        {
            var distance = ((double)point.x - origin.x) * direction.x
                         + ((double)point.y - origin.y) * direction.y;
            var closestPoint = new Vector2(
                (float)(origin.x + direction.x * distance),
                (float)(origin.y + direction.y * distance));
            return (closestPoint, (float)distance);
        }

        /// <summary>
        /// Finds the closest point on the line segment.
        /// </summary>
        /// <param name="point">The point to project.</param>
        /// <param name="start">The start of the segment.</param>
        /// <param name="end">The end of the segment.</param>
        /// <returns>The closest point on the segment and the distance along the segment from <paramref name="start"/> to that point.</returns>
        public static (Vector2 point, float distance) GetClosestPointOnSegment(this Vector2 point, Vector2 start, Vector2 end)
        {
            var dx = (double)end.x - start.x;
            var dy = (double)end.y - start.y;
            var squaredLength = dx * dx + dy * dy;

            if (squaredLength == 0d)
                return (start, 0f);

            var t = (((double)point.x - start.x) * dx
                   + ((double)point.y - start.y) * dy) / squaredLength;

            if (t <= 0d)
                return (start, 0f);

            var length = System.Math.Sqrt(squaredLength);
            if (t >= 1d)
                return (end, (float)length);

            var closestPoint = new Vector2(
                (float)((1d - t) * start.x + t * end.x),
                (float)((1d - t) * start.y + t * end.y));
            return (closestPoint, (float)(t * length));
        }

        /// <summary>
        /// Randomly rotates the direction around the z axis within the specified angular limit.
        /// </summary>
        /// <param name="direction">The direction to deflect.</param>
        /// <param name="angle">The maximum absolute rotation angle, in degrees.</param>
        /// <returns>The deflected vector, with its original magnitude preserved.</returns>
        public static Vector2 RandomDeflected(this Vector2 direction, float angle) => Quaternion.AngleAxis(Random.value * angle.WithRandomSign(), Vector3.forward) * direction;

        /// <summary>
        /// Rotates the vector around the z axis.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="angle">The rotation angle, in degrees.</param>
        /// <returns>The rotated vector.</returns>
        public static Vector2 Rotate(this Vector2 vector, float angle) => Quaternion.Euler(0f, 0f, angle) * vector;
    }
}
