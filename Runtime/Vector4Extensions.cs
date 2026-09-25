using System.Collections.Generic;
using UnityEngine;

namespace Unixtensions
{
    public static class Vector4Extensions
    {
        /// <summary>
        /// Sets the specified component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The index of the first component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="value">The value to assign to the specified component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 With(this Vector4 vector, int axis, float value)
        {
            vector[axis] = value;
            return vector;
        }

        /// <summary>
        /// Sets the X component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithX(this Vector4 vector, float x) => With(vector, 0, x);

        /// <summary>
        /// Sets the Y component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithY(this Vector4 vector, float y) => With(vector, 1, y);

        /// <summary>
        /// Sets the Z component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithZ(this Vector4 vector, float z) => With(vector, 2, z);

        /// <summary>
        /// Sets the W component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="w">The value to assign to the W component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithW(this Vector4 vector, float w) => With(vector, 3, w);

        /// <summary>
        /// Sets the specified components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the first component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="value1">The value to assign to the first specified component.</param>
        /// <param name="axis2">The index of the second component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="value2">The value to assign to the second specified component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 With(this Vector4 vector, int axis1, float value1, int axis2, float value2)
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
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXY(this Vector4 vector, float x, float y) => With(vector, 0, x, 1, y);

        /// <summary>
        /// Sets the X and Y components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the X and Y components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXY(this Vector4 vector, Vector2 value) => With(vector, 0, value.x, 1, value.y);

        /// <summary>
        /// Sets the X and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXZ(this Vector4 vector, float x, float z) => With(vector, 0, x, 2, z);

        /// <summary>
        /// Sets the X and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the X and Z components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXZ(this Vector4 vector, Vector2 value) => With(vector, 0, value.x, 2, value.y);

        /// <summary>
        /// Sets the X and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <param name="w">The value to assign to the W component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXW(this Vector4 vector, float x, float w) => With(vector, 0, x, 3, w);

        /// <summary>
        /// Sets the X and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the X and W components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXW(this Vector4 vector, Vector2 value) => With(vector, 0, value.x, 3, value.y);

        /// <summary>
        /// Sets the Y and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithYZ(this Vector4 vector, float y, float z) => With(vector, 1, y, 2, z);

        /// <summary>
        /// Sets the Y and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the Y and Z components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithYZ(this Vector4 vector, Vector2 value) => With(vector, 1, value.x, 2, value.y);

        /// <summary>
        /// Sets the Y and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <param name="w">The value to assign to the W component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithYW(this Vector4 vector, float y, float w) => With(vector, 1, y, 3, w);

        /// <summary>
        /// Sets the Y and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the Y and W components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithYW(this Vector4 vector, Vector2 value) => With(vector, 1, value.x, 3, value.y);

        /// <summary>
        /// Sets the Z and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <param name="w">The value to assign to the W component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithZW(this Vector4 vector, float z, float w) => With(vector, 2, z, 3, w);

        /// <summary>
        /// Sets the Z and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X and Y values to assign to the Z and W components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithZW(this Vector4 vector, Vector2 value) => With(vector, 2, value.x, 3, value.y);

        /// <summary>
        /// Sets the specified components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the first component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="value1">The value to assign to the first specified component.</param>
        /// <param name="axis2">The index of the second component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="value2">The value to assign to the second specified component.</param>
        /// <param name="axis3">The index of the third component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="value3">The value to assign to the third specified component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 With(this Vector4 vector, int axis1, float value1, int axis2, float value2, int axis3, float value3)
        {
            vector[axis1] = value1;
            vector[axis2] = value2;
            vector[axis3] = value3;

            return vector;
        }

        /// <summary>
        /// Sets the X, Y, and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXYZ(this Vector4 vector, float x, float y, float z) => With(vector, 0, x, 1, y, 2, z);

        /// <summary>
        /// Sets the X, Y, and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X, Y, and Z values to assign to the X, Y, and Z components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXYZ(this Vector4 vector, Vector3 value) => With(vector, 0, value.x, 1, value.y, 2, value.z);

        /// <summary>
        /// Sets the X, Y, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <param name="w">The value to assign to the W component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXYW(this Vector4 vector, float x, float y, float w) => With(vector, 0, x, 1, y, 3, w);

        /// <summary>
        /// Sets the X, Y, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X, Y, and Z values to assign to the X, Y, and W components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXYW(this Vector4 vector, Vector3 value) => With(vector, 0, value.x, 1, value.y, 3, value.z);

        /// <summary>
        /// Sets the X, Z, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="x">The value to assign to the X component.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <param name="w">The value to assign to the W component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXZW(this Vector4 vector, float x, float z, float w) => With(vector, 0, x, 2, z, 3, w);

        /// <summary>
        /// Sets the X, Z, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X, Y, and Z values to assign to the X, Z, and W components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithXZW(this Vector4 vector, Vector3 value) => With(vector, 0, value.x, 2, value.y, 3, value.z);

        /// <summary>
        /// Sets the Y, Z, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="y">The value to assign to the Y component.</param>
        /// <param name="z">The value to assign to the Z component.</param>
        /// <param name="w">The value to assign to the W component.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithYZW(this Vector4 vector, float y, float z, float w) => With(vector, 1, y, 2, z, 3, w);

        /// <summary>
        /// Sets the Y, Z, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="value">The X, Y, and Z values to assign to the Y, Z, and W components, respectively.</param>
        /// <returns>A copy of the vector with the specified components set and all other components unchanged.</returns>
        public static Vector4 WithYZW(this Vector4 vector, Vector3 value) => With(vector, 1, value.x, 2, value.y, 3, value.z);

        /// <summary>
        /// Negates the specified component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis">The index of the first component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>A copy of the vector with the specified component negated and all other components unchanged.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis) => vector.With(axis, -vector[axis]);

        /// <summary>
        /// Negates the X component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified component negated and all other components unchanged.</returns>
        public static Vector4 WithNegateX(this Vector4 vector) => WithNegate(vector, 0);

        /// <summary>
        /// Negates the Y component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified component negated and all other components unchanged.</returns>
        public static Vector4 WithNegateY(this Vector4 vector) => WithNegate(vector, 1);

        /// <summary>
        /// Negates the Z component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified component negated and all other components unchanged.</returns>
        public static Vector4 WithNegateZ(this Vector4 vector) => WithNegate(vector, 2);

        /// <summary>
        /// Negates the W component in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified component negated and all other components unchanged.</returns>
        public static Vector4 WithNegateW(this Vector4 vector) => WithNegate(vector, 3);

        /// <summary>
        /// Negates the specified components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the first component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis2">The index of the second component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis1, int axis2)
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
        public static Vector4 WithNegateXY(this Vector4 vector) => vector.WithNegate(0, 1);

        /// <summary>
        /// Negates the X and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegateXZ(this Vector4 vector) => vector.WithNegate(0, 2);

        /// <summary>
        /// Negates the X and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegateXW(this Vector4 vector) => vector.WithNegate(0, 3);

        /// <summary>
        /// Negates the Y and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegateYZ(this Vector4 vector) => vector.WithNegate(1, 2);

        /// <summary>
        /// Negates the Y and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegateYW(this Vector4 vector) => vector.WithNegate(1, 3);

        /// <summary>
        /// Negates the specified components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the first component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis2">The index of the second component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis3">The index of the third component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis1, int axis2, int axis3)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];
            vector[axis3] = -vector[axis3];

            return vector;
        }

        /// <summary>
        /// Negates the X, Y, and Z components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegateXYZ(this Vector4 vector) => vector.WithNegate(0, 1, 2);

        /// <summary>
        /// Negates the X, Y, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegateXYW(this Vector4 vector) => vector.WithNegate(0, 1, 3);

        /// <summary>
        /// Negates the X, Z, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegateXZW(this Vector4 vector) => vector.WithNegate(0, 2, 3);

        /// <summary>
        /// Negates the Y, Z, and W components in a copy of the vector.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A copy of the vector with the specified components negated.</returns>
        public static Vector4 WithNegateYZW(this Vector4 vector) => vector.WithNegate(1, 2, 3);

        /// <summary>
        /// Returns a vector with each component negated.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The negated vector.</returns>
        public static Vector4 Negate(this Vector4 vector) => new(-vector.x, -vector.y, -vector.z, -vector.w);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the specified components in the given order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the source component to use as the X component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis2">The index of the source component to use as the Y component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 Get(this Vector4 vector, int axis1, int axis2) => new Vector2(vector[axis1], vector[axis2]);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the X and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetXY(this Vector4 vector) => Get(vector, 0, 1);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the X and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetXZ(this Vector4 vector) => Get(vector, 0, 2);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the X and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetXW(this Vector4 vector) => Get(vector, 0, 3);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the Y and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetYX(this Vector4 vector) => Get(vector, 1, 0);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the Y and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetYZ(this Vector4 vector) => Get(vector, 1, 2);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the Y and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetYW(this Vector4 vector) => Get(vector, 1, 3);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the Z and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetZX(this Vector4 vector) => Get(vector, 2, 0);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the Z and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetZY(this Vector4 vector) => Get(vector, 2, 1);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the Z and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetZW(this Vector4 vector) => Get(vector, 2, 3);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the W and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetWX(this Vector4 vector) => Get(vector, 3, 0);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the W and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetWY(this Vector4 vector) => Get(vector, 3, 1);

        /// <summary>
        /// Creates a <see cref="Vector2"/> from the W and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector2"/> containing the selected components in the specified order.</returns>
        public static Vector2 GetWZ(this Vector4 vector) => Get(vector, 3, 2);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the specified components in the given order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the source component to use as the X component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis2">The index of the source component to use as the Y component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis3">The index of the source component to use as the Z component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 Get(this Vector4 vector, int axis1, int axis2, int axis3) => new Vector3(vector[axis1], vector[axis2], vector[axis3]);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the X, Y, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetXYZ(this Vector4 vector) => Get(vector, 0, 1, 2);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the X, Y, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetXYW(this Vector4 vector) => Get(vector, 0, 1, 3);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the X, Z, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetXZY(this Vector4 vector) => Get(vector, 0, 2, 1);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the X, Z, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetXZW(this Vector4 vector) => Get(vector, 0, 2, 3);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the X, W, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetXWY(this Vector4 vector) => Get(vector, 0, 3, 1);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the X, W, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetXWZ(this Vector4 vector) => Get(vector, 0, 3, 2);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Y, X, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetYXZ(this Vector4 vector) => Get(vector, 1, 0, 2);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Y, X, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetYXW(this Vector4 vector) => Get(vector, 1, 0, 3);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Y, Z, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetYZX(this Vector4 vector) => Get(vector, 1, 2, 0);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Y, Z, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetYZW(this Vector4 vector) => Get(vector, 1, 2, 3);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Y, W, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetYWX(this Vector4 vector) => Get(vector, 1, 3, 0);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Y, W, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetYWZ(this Vector4 vector) => Get(vector, 1, 3, 2);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Z, X, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetZXY(this Vector4 vector) => Get(vector, 2, 0, 1);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Z, X, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetZXW(this Vector4 vector) => Get(vector, 2, 0, 3);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Z, Y, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetZYX(this Vector4 vector) => Get(vector, 2, 1, 0);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Z, Y, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetZYW(this Vector4 vector) => Get(vector, 2, 1, 3);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Z, W, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetZWX(this Vector4 vector) => Get(vector, 2, 3, 0);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the Z, W, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetZWY(this Vector4 vector) => Get(vector, 2, 3, 1);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the W, X, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetWXY(this Vector4 vector) => Get(vector, 3, 0, 1);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the W, X, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetWXZ(this Vector4 vector) => Get(vector, 3, 0, 2);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the W, Y, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetWYX(this Vector4 vector) => Get(vector, 3, 1, 0);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the W, Y, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetWYZ(this Vector4 vector) => Get(vector, 3, 1, 2);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the W, Z, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetWZX(this Vector4 vector) => Get(vector, 3, 2, 0);

        /// <summary>
        /// Creates a <see cref="Vector3"/> from the W, Z, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector3"/> containing the selected components in the specified order.</returns>
        public static Vector3 GetWZY(this Vector4 vector) => Get(vector, 3, 2, 1);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the specified components in the given order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="axis1">The index of the source component to use as the X component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis2">The index of the source component to use as the Y component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis3">The index of the source component to use as the Z component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <param name="axis4">The index of the source component to use as the W component (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 Get(this Vector4 vector, int axis1, int axis2, int axis3, int axis4) => new Vector4(vector[axis1], vector[axis2], vector[axis3], vector[axis4]);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the X, Y, W, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetXYWZ(this Vector4 vector) => Get(vector, 0, 1, 3, 2);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the X, Z, Y, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetXZYW(this Vector4 vector) => Get(vector, 0, 2, 1, 3);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the X, Z, W, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetXZWY(this Vector4 vector) => Get(vector, 0, 2, 3, 1);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the X, W, Y, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetXWYZ(this Vector4 vector) => Get(vector, 0, 3, 1, 2);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the X, W, Z, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetXWZY(this Vector4 vector) => Get(vector, 0, 3, 2, 1);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Y, X, Z, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetYXZW(this Vector4 vector) => Get(vector, 1, 0, 2, 3);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Y, X, W, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetYXWZ(this Vector4 vector) => Get(vector, 1, 0, 3, 2);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Y, Z, X, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetYZXW(this Vector4 vector) => Get(vector, 1, 2, 0, 3);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Y, Z, W, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetYZWX(this Vector4 vector) => Get(vector, 1, 2, 3, 0);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Y, W, X, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetYWXZ(this Vector4 vector) => Get(vector, 1, 3, 0, 2);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Y, W, Z, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetYWZX(this Vector4 vector) => Get(vector, 1, 3, 2, 0);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Z, X, Y, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetZXYW(this Vector4 vector) => Get(vector, 2, 0, 1, 3);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Z, X, W, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetZXWY(this Vector4 vector) => Get(vector, 2, 0, 3, 1);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Z, Y, X, and W components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetZYXW(this Vector4 vector) => Get(vector, 2, 1, 0, 3);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Z, Y, W, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetZYWX(this Vector4 vector) => Get(vector, 2, 1, 3, 0);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Z, W, X, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetZWXY(this Vector4 vector) => Get(vector, 2, 3, 0, 1);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the Z, W, Y, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetZWYX(this Vector4 vector) => Get(vector, 2, 3, 1, 0);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the W, X, Y, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetWXYZ(this Vector4 vector) => Get(vector, 3, 0, 1, 2);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the W, X, Z, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetWXZY(this Vector4 vector) => Get(vector, 3, 0, 2, 1);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the W, Y, X, and Z components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetWYXZ(this Vector4 vector) => Get(vector, 3, 1, 0, 2);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the W, Y, Z, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetWYZX(this Vector4 vector) => Get(vector, 3, 1, 2, 0);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the W, Z, X, and Y components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetWZXY(this Vector4 vector) => Get(vector, 3, 2, 0, 1);

        /// <summary>
        /// Creates a <see cref="Vector4"/> from the W, Z, Y, and X components, in that order.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A <see cref="Vector4"/> containing the selected components in the specified order.</returns>
        public static Vector4 GetWZYX(this Vector4 vector) => Get(vector, 3, 2, 1, 0);

        private static void Compare(Vector4 vector, ref int index, int compareIndex, int result)
        {
            if (vector[compareIndex].CompareTo(vector[index]) == result)
                index = compareIndex;
        }

        private static int CompareAllComponents(Vector4 vector, int result)
        {
            var index = 0;

            Compare(vector, ref index, 1, result);
            Compare(vector, ref index, 2, result);
            Compare(vector, ref index, 3, result);

            return index;
        }

        /// <summary>
        /// Gets the index and value of the largest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The index of the first largest component and its value.</returns>
        public static (int index, float value) MaxComponent(this Vector4 vector)
        {
            var index = CompareAllComponents(vector, 1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Gets the index and value of the smallest component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>The index of the first smallest component and its value.</returns>
        public static (int index, float value) MinComponent(this Vector4 vector)
        {
            var index = CompareAllComponents(vector, -1);
            return (index, vector[index]);
        }

        /// <summary>
        /// Linearly remaps each component from the source range to the target range.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="min1">The lower bound of the source range.</param>
        /// <param name="max1">The upper bound of the source range.</param>
        /// <param name="min2">The lower bound of the target range.</param>
        /// <param name="max2">The upper bound of the target range.</param>
        /// <returns>A vector with remapped components. The result is not clamped to the target range.</returns>
        public static Vector4 Remap(this Vector4 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector4(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2), vector.z.Remap(min1, max1, min2, max2), vector.w.Remap(min1, max1, min2, max2));
        }

        /// <summary>
        /// Creates a vector containing the absolute value of each component.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A vector with the absolute component values.</returns>
        public static Vector4 Abs(this Vector4 vector) => new Vector4(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z), Mathf.Abs(vector.w));

        /// <summary>
        /// Creates a vector with each component clamped to the specified range.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="min">The minimum allowed component value.</param>
        /// <param name="max">The maximum allowed component value.</param>
        /// <returns>A vector with each component clamped to the range.</returns>
        public static Vector4 Clamp(this Vector4 vector, float min, float max)
        {
            return new Vector4(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), Mathf.Clamp(vector.z, min, max), Mathf.Clamp(vector.w, min, max));
        }

        /// <summary>
        /// Creates a vector with each component clamped to the range from zero to one.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns>A vector with each component clamped to the range from zero to one.</returns>
        public static Vector4 Clamp01(this Vector4 vector)
        {
            return new Vector4(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y), Mathf.Clamp01(vector.z), Mathf.Clamp01(vector.w));
        }

        /// <summary>
        /// Divides each component by the corresponding component of <paramref name="other"/>.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <param name="other">The vector containing the divisor for each component.</param>
        /// <returns>A vector containing the component-wise quotients.</returns>
        public static Vector4 Divide(this Vector4 vector, Vector4 other)
        {
            return new Vector4(vector.x / other.x, vector.y / other.y, vector.z / other.z, vector.w / other.w);
        }

        /// <summary>
        /// Checks whether any component is NaN.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns><see langword="true"/> if any component is NaN; otherwise, <see langword="false"/>.</returns>
        public static bool IsNaN(this Vector4 vector) => float.IsNaN(vector.x) || float.IsNaN(vector.y) || float.IsNaN(vector.z) || float.IsNaN(vector.w);

        /// <summary>
        /// Checks whether each pair of adjacent components is approximately equal.
        /// </summary>
        /// <param name="vector">The source vector.</param>
        /// <returns><see langword="true"/> if each pair of adjacent components is approximately equal; otherwise, <see langword="false"/>.</returns>
        public static bool IsUniform(this Vector4 vector)
        {
            return vector.x.Approx(vector.y) && vector.y.Approx(vector.z) && vector.z.Approx(vector.w);
        }
    }
}