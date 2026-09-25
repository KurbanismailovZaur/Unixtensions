using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unixtensions
{
    public static class Vector3Extensions
    {
        /// <summary>
        /// Returns a copy of the vector with the selected component replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The component index, from 0 to 2.</param>
        /// <param name="value">The value to assign to the corresponding component.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 With(this Vector3 vector, int axis, float value)
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
        public static Vector3 WithX(this Vector3 vector, float x) => With(vector, 0, x);

        /// <summary>
        /// Returns a copy of the vector with its y component replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The new y component value.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 WithY(this Vector3 vector, float y) => With(vector, 1, y);

        /// <summary>
        /// Returns a copy of the vector with its z component replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="z">The new z component value.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 WithZ(this Vector3 vector, float z) => With(vector, 2, z);

        /// <summary>
        /// Returns a copy of the vector with the selected components replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The component index, from 0 to 2.</param>
        /// <param name="value1">The value to assign to the corresponding component.</param>
        /// <param name="axis2">The component index, from 0 to 2.</param>
        /// <param name="value2">The value to assign to the corresponding component.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 With(this Vector3 vector, int axis1, float value1, int axis2, float value2)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;

            return vector;
        }

        /// <summary>
        /// Returns a copy of the vector with its x and y components replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The new x component value.</param>
        /// <param name="y">The new y component value.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 WithXY(this Vector3 vector, float x, float y) => With(vector, 0, x, 1, y);

        /// <summary>
        /// Returns a copy of the vector with its x and y components replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The x and y values to assign to the vector's x and y components, respectively.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 WithXY(this Vector3 vector, Vector2 value) => With(vector, 0, value.x, 1, value.y);

        /// <summary>
        /// Returns a copy of the vector with its x and z components replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The new x component value.</param>
        /// <param name="z">The new z component value.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 WithXZ(this Vector3 vector, float x, float z) => With(vector, 0, x, 2, z);

        /// <summary>
        /// Returns a copy of the vector with its x and z components replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The x and y values to assign to the vector's x and z components, respectively.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 WithXZ(this Vector3 vector, Vector2 value) => With(vector, 0, value.x, 2, value.y);

        /// <summary>
        /// Returns a copy of the vector with its y and z components replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The new y component value.</param>
        /// <param name="z">The new z component value.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 WithYZ(this Vector3 vector, float y, float z) => With(vector, 1, y, 2, z);

        /// <summary>
        /// Returns a copy of the vector with its y and z components replaced.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The x and y values to assign to the vector's y and z components, respectively.</param>
        /// <returns>The modified copy of the vector.</returns>
        public static Vector3 WithYZ(this Vector3 vector, Vector2 value) => With(vector, 1, value.x, 2, value.y);

        /// <summary>
        /// Returns a copy of the vector with the selected component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The index of the component to negate, from 0 to 2.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector3 WithNegate(this Vector3 vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Returns a copy of the vector with its x component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector3 WithNegateX(this Vector3 vector) => WithNegate(vector, 0);

        /// <summary>
        /// Returns a copy of the vector with its y component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector3 WithNegateY(this Vector3 vector) => WithNegate(vector, 1);

        /// <summary>
        /// Returns a copy of the vector with its z component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified component negated.</returns>
        public static Vector3 WithNegateZ(this Vector3 vector) => WithNegate(vector, 2);

        /// <summary>
        /// Returns a copy of the vector with the selected components negated in order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the component to negate, from 0 to 2.</param>
        /// <param name="axis2">The index of the component to negate, from 0 to 2.</param>
        /// <returns>The vector with the specified components negated.</returns>
        public static Vector3 WithNegate(this Vector3 vector, int axis1, int axis2)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];

            return vector;
        }

        /// <summary>
        /// Returns a copy of the vector with its x and y components negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified components negated.</returns>
        public static Vector3 WithNegateXY(this Vector3 vector) => vector.WithNegate(0, 1);

        /// <summary>
        /// Returns a copy of the vector with its x and z components negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified components negated.</returns>
        public static Vector3 WithNegateXZ(this Vector3 vector) => vector.WithNegate(0, 2);

        /// <summary>
        /// Returns a copy of the vector with its y and z components negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified components negated.</returns>
        public static Vector3 WithNegateYZ(this Vector3 vector) => vector.WithNegate(1, 2);

        /// <summary>
        /// Returns a vector with every component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with the specified components negated.</returns>
        public static Vector3 Negate(this Vector3 vector) => new(-vector.x, -vector.y, -vector.z);

        /// <summary>
        /// Creates a vector from the selected components in the specified order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The source component index, from 0 to 2.</param>
        /// <param name="axis2">The source component index, from 0 to 2.</param>
        /// <returns>The resulting <see cref="Vector2"/>.</returns>
        public static Vector2 Get(this Vector3 vector, int axis1, int axis2) => new(vector[axis1], vector[axis2]);

        /// <summary>
        /// Creates a vector whose components are in XY order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector2"/>.</returns>
        public static Vector2 GetXY(this Vector3 vector) => Get(vector, 0, 1);

        /// <summary>
        /// Creates a vector whose components are in XZ order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector2"/>.</returns>
        public static Vector2 GetXZ(this Vector3 vector) => Get(vector, 0, 2);

        /// <summary>
        /// Creates a vector whose components are in YX order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector2"/>.</returns>
        public static Vector2 GetYX(this Vector3 vector) => Get(vector, 1, 0);

        /// <summary>
        /// Creates a vector whose components are in YZ order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector2"/>.</returns>
        public static Vector2 GetYZ(this Vector3 vector) => Get(vector, 1, 2);

        /// <summary>
        /// Creates a vector whose components are in ZX order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector2"/>.</returns>
        public static Vector2 GetZX(this Vector3 vector) => Get(vector, 2, 0);

        /// <summary>
        /// Creates a vector whose components are in ZY order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector2"/>.</returns>
        public static Vector2 GetZY(this Vector3 vector) => Get(vector, 2, 1);

        /// <summary>
        /// Creates a vector from the selected components in the specified order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The source component index, from 0 to 2.</param>
        /// <param name="axis2">The source component index, from 0 to 2.</param>
        /// <param name="axis3">The source component index, from 0 to 2.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 Get(this Vector3 vector, int axis1, int axis2, int axis3) => new(vector[axis1], vector[axis2], vector[axis3]);

        /// <summary>
        /// Creates a vector whose components are in XZY order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 GetXZY(this Vector3 vector) => Get(vector, 0, 2, 1);

        /// <summary>
        /// Creates a vector whose components are in YXZ order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 GetYXZ(this Vector3 vector) => Get(vector, 1, 0, 2);

        /// <summary>
        /// Creates a vector whose components are in YZX order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 GetYZX(this Vector3 vector) => Get(vector, 1, 2, 0);

        /// <summary>
        /// Creates a vector whose components are in ZXY order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 GetZXY(this Vector3 vector) => Get(vector, 2, 0, 1);

        /// <summary>
        /// Creates a vector whose components are in ZYX order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The resulting <see cref="Vector3"/>.</returns>
        public static Vector3 GetZYX(this Vector3 vector) => Get(vector, 2, 1, 0);

        /// <summary>
        /// Creates a <see cref="Vector4"/> by inserting a value at the x component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector4"/>.</returns>
        public static Vector4 InsertX(this Vector3 vector, float x = 0) => new(x, vector.x, vector.y, vector.z);

        /// <summary>
        /// Creates a <see cref="Vector4"/> by inserting a value at the y component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector4"/>.</returns>
        public static Vector4 InsertY(this Vector3 vector, float y = 0) => new(vector.x, y, vector.y, vector.z);

        /// <summary>
        /// Creates a <see cref="Vector4"/> by inserting a value at the z component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="z">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector4"/>.</returns>
        public static Vector4 InsertZ(this Vector3 vector, float z = 0) => new(vector.x, vector.y, z, vector.z);

        /// <summary>
        /// Creates a <see cref="Vector4"/> by inserting a value at the w component and preserving the order of the original components.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="w">The value to insert.</param>
        /// <returns>The resulting <see cref="Vector4"/>.</returns>
        public static Vector4 InsertW(this Vector3 vector, float w = 0) => new(vector.x, vector.y, vector.z, w);

        private static void Compare(Vector3 vector, ref int index, int compareIndex, int result)
        {
            if (vector[compareIndex].CompareTo(vector[index]) == result)
                index = compareIndex;
        }

        private static int CompareAllComponents(Vector3 vector, int result)
        {
            var index = 0;

            Compare(vector, ref index, 1, result);
            Compare(vector, ref index, 2, result);

            return index;
        }

        /// <summary>
        /// Gets the index and value of the vector's largest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The zero-based index and value of the largest component.</returns>
        public static (int index, float value) MaxComponent(this Vector3 vector)
        {
            var index = CompareAllComponents(vector, 1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Gets the index and value of the vector's smallest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The zero-based index and value of the smallest component.</returns>
        public static (int index, float value) MinComponent(this Vector3 vector) 
        {
            var index = CompareAllComponents(vector, -1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Linearly maps each component from one range to another without clamping.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="min1">The start of the source range.</param>
        /// <param name="max1">The end of the source range.</param>
        /// <param name="min2">The start of the target range.</param>
        /// <param name="max2">The end of the target range.</param>
        /// <returns>The vector with remapped components.</returns>
        public static Vector3 Remap(this Vector3 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector3(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2), vector.z.Remap(min1, max1, min2, max2));
        }

        /// <summary>
        /// Creates a vector containing the absolute value of each component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with absolute component values.</returns>
        public static Vector3 Abs(this Vector3 vector) => new(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));

        /// <summary>
        /// Clamps each component to the specified range.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="min">The lower bound for each component.</param>
        /// <param name="max">The upper bound for each component.</param>
        /// <returns>The vector with clamped components.</returns>
        public static Vector3 Clamp(this Vector3 vector, float min, float max)
        {
            return new Vector3(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), Mathf.Clamp(vector.z, min, max));
        }

        /// <summary>
        /// Clamps each component to the inclusive range from 0 to 1.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The vector with clamped components.</returns>
        public static Vector3 Clamp01(this Vector3 vector)
        {
            return new Vector3(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y), Mathf.Clamp01(vector.z));
        }

        /// <summary>
        /// Divides each component by the corresponding component of <paramref name="other"/>.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="other">The vector containing the divisors.</param>
        /// <returns>The vector containing the component-wise quotients.</returns>
        public static Vector3 Divide(this Vector3 vector, Vector3 other)
        {
            return new Vector3(vector.x / other.x, vector.y / other.y, vector.z / other.z);
        }

        /// <summary>
        /// Checks whether adjacent vector components are approximately equal.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns><see langword="true"/> if each adjacent pair is approximately equal; otherwise, <see langword="false"/>.</returns>
        public static bool IsUniform(this Vector3 vector) => vector.x.Approx(vector.y) && vector.y.Approx(vector.z);

        /// <summary>
        /// Calculates one point of a roughly evenly distributed set on a sphere centered at the origin.
        /// </summary>
        /// <param name="index">The zero-based point index, less than the total point count.</param>
        /// <param name="radius">The sphere radius.</param>
        /// <param name="count">The total number of points, which must be positive.</param>
        /// <returns>The calculated point.</returns>
        public static Vector3 EventlyDistributedPointOnSphere(int index, float radius, int count)
        {
            var k = index + 0.5f;
            var phi = Mathf.Acos(1f - 2f * k / count);
            var theta = Mathf.PI * (1 + Mathf.Sqrt(5)) * k;

            var x = Mathf.Cos(theta) * Mathf.Sin(phi);
            var y = Mathf.Sin(theta) * Mathf.Sin(phi);
            var z = Mathf.Cos(phi);

            return new Vector3(x, y, z) * radius;
        }


        /// <summary>
        /// Finds the point in <paramref name="points"/> closest to <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The reference point.</param>
        /// <param name="points">The candidate points, in index order.</param>
        /// <returns>The closest point and its zero-based index; (<see cref="Vector3.zero"/>, -1) for an empty list.</returns>
        public static (Vector3 point, int index) GetClosestPoint(this Vector3 point, params Vector3[] points)
        {
            return GetClosestPoint(point, (IList<Vector3>)points);
        }

        /// <summary>
        /// Finds the point in <paramref name="points"/> closest to <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The reference point.</param>
        /// <param name="points">The candidate points, in index order.</param>
        /// <returns>The closest point and its zero-based index; (<see cref="Vector3.zero"/>, -1) for an empty list.</returns>
        public static (Vector3 point, int index) GetClosestPoint(this Vector3 point, IList<Vector3> points)
        {
            var closestIndex = -1;
            var closestPoint = Vector3.zero;
            var closestSquaredDistance = double.PositiveInfinity;

            for (var index = 0; index < points.Count; index++)
            {
                var candidate = points[index];
                var dx = (double)point.x - candidate.x;
                var dy = (double)point.y - candidate.y;
                var dz = (double)point.z - candidate.z;
                var squaredDistance = dx * dx + dy * dy + dz * dz;

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
        public static (Vector3 point, float distance) GetClosestPointOnRay(this Vector3 point, Vector3 origin, Vector3 direction)
        {
            var distance = ((double)point.x - origin.x) * direction.x
                         + ((double)point.y - origin.y) * direction.y
                         + ((double)point.z - origin.z) * direction.z;
            var closestPoint = new Vector3(
                (float)(origin.x + direction.x * distance),
                (float)(origin.y + direction.y * distance),
                (float)(origin.z + direction.z * distance));
            return (closestPoint, (float)distance);
        }

        /// <summary>
        /// Finds the closest point on the infinite line defined by the ray.
        /// </summary>
        /// <remarks>The projection is not clamped to the ray's forward half-line; the distance may be negative.</remarks>
        /// <param name="point">The point to project.</param>
        /// <param name="ray">The ray defining the line.</param>
        /// <returns>The closest point on the line and its signed distance along the direction from the ray's origin.</returns>
        public static (Vector3 point, float distance) GetClosestPointOnRay(this Vector3 point, Ray ray)
        {
            return GetClosestPointOnRay(point, ray.origin, ray.direction);
        }

        /// <summary>
        /// Finds the closest point on the line segment.
        /// </summary>
        /// <param name="point">The point to project.</param>
        /// <param name="start">The start of the segment.</param>
        /// <param name="end">The end of the segment.</param>
        /// <returns>The closest point on the segment and the distance along the segment from <paramref name="start"/> to that point.</returns>

        public static (Vector3 point, float distance) GetClosestPointOnSegment(this Vector3 point, Vector3 start, Vector3 end)
        {
            var dx = (double)end.x - start.x;
            var dy = (double)end.y - start.y;
            var dz = (double)end.z - start.z;
            var squaredLength = dx * dx + dy * dy + dz * dz;

            if (squaredLength == 0d)
                return (start, 0f);

            var t = (((double)point.x - start.x) * dx
                   + ((double)point.y - start.y) * dy
                   + ((double)point.z - start.z) * dz) / squaredLength;

            if (t <= 0d)
                return (start, 0f);

            var length = System.Math.Sqrt(squaredLength);
            if (t >= 1d)
                return (end, (float)length);

            var closestPoint = new Vector3(
                (float)((1d - t) * start.x + t * end.x),
                (float)((1d - t) * start.y + t * end.y),
                (float)((1d - t) * start.z + t * end.z));
            return (closestPoint, (float)(t * length));
        }

        /// <summary>
        /// Creates a randomly deflected unit direction using bounded yaw and pitch offsets.
        /// </summary>
        /// <remarks>Uses <see cref="Vector3.up"/> to orient the local frame.</remarks>
        /// <param name="direction">The direction to deflect.</param>
        /// <param name="angle">The maximum absolute yaw and pitch offsets, in degrees.</param>
        /// <returns>The deflected unit direction.</returns>
        public static Vector3 WithRandomDeflection(this Vector3 direction, float angle) => WithRandomDeflection(direction, new Vector2(angle, angle), Vector3.up);

        /// <summary>
        /// Creates a randomly deflected unit direction using bounded yaw and pitch offsets.
        /// </summary>
        /// <param name="direction">The direction to deflect.</param>
        /// <param name="angle">The maximum absolute yaw and pitch offsets, in degrees.</param>
        /// <param name="up">The up direction used to orient the local frame.</param>
        /// <returns>The deflected unit direction.</returns>
        public static Vector3 WithRandomDeflection(this Vector3 direction, float angle, Vector3 up) => WithRandomDeflection(direction, new Vector2(angle, angle), up);

        /// <summary>
        /// Creates a randomly deflected unit direction using bounded yaw and pitch offsets.
        /// </summary>
        /// <remarks>Uses <see cref="Vector3.up"/> to orient the local frame.</remarks>
        /// <param name="direction">The direction to deflect.</param>
        /// <param name="angleX">The maximum absolute yaw offset around the local y axis, in degrees.</param>
        /// <param name="angleY">The maximum absolute pitch offset around the local x axis, in degrees.</param>
        /// <returns>The deflected unit direction.</returns>
        public static Vector3 WithRandomDeflection(this Vector3 direction, float angleX, float angleY) => WithRandomDeflection(direction, new Vector2(angleX, angleY), Vector3.up);

        /// <summary>
        /// Creates a randomly deflected unit direction using bounded yaw and pitch offsets.
        /// </summary>
        /// <param name="direction">The direction to deflect.</param>
        /// <param name="angleX">The maximum absolute yaw offset around the local y axis, in degrees.</param>
        /// <param name="angleY">The maximum absolute pitch offset around the local x axis, in degrees.</param>
        /// <param name="up">The up direction used to orient the local frame.</param>
        /// <returns>The deflected unit direction.</returns>
        public static Vector3 WithRandomDeflection(this Vector3 direction, float angleX, float angleY, Vector3 up) => WithRandomDeflection(direction, new Vector2(angleX, angleY), up);

        /// <summary>
        /// Creates a randomly deflected unit direction using bounded yaw and pitch offsets.
        /// </summary>
        /// <remarks>Uses <see cref="Vector3.up"/> to orient the local frame.</remarks>
        /// <param name="direction">The direction to deflect.</param>
        /// <param name="angles">The maximum absolute yaw (x) and pitch (y) offsets, in degrees.</param>
        /// <returns>The deflected unit direction.</returns>
        public static Vector3 WithRandomDeflection(this Vector3 direction, Vector2 angles) => WithRandomDeflection(direction, angles, Vector3.up);

        /// <summary>
        /// Creates a randomly deflected unit direction using bounded yaw and pitch offsets.
        /// </summary>
        /// <param name="direction">The direction to deflect.</param>
        /// <param name="angles">The maximum absolute yaw (x) and pitch (y) offsets, in degrees.</param>
        /// <param name="up">The up direction used to orient the local frame.</param>
        /// <returns>The deflected unit direction.</returns>
        public static Vector3 WithRandomDeflection(this Vector3 direction, Vector2 angles, Vector3 up)
        {
            if (direction.sqrMagnitude == 0f)
                return direction;

            var randomAngles = Random.insideUnitCircle;
            randomAngles.Scale(angles);

            return Quaternion.LookRotation(direction, up) * Quaternion.Euler(randomAngles.y, randomAngles.x, 0f) * Vector3.forward;
        }
    }
}
