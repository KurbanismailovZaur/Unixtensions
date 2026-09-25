using UnityEngine;

namespace Unixtensions
{
    public static class QuaternionExtensions
    {
        /// <summary>
        /// Sets <paramref name="x"/> value to the x component.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithX(this Quaternion quaternion, float x)
        {
            quaternion.x = x;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="y"/> value to the y component.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithY(this Quaternion quaternion, float y)
        {
            quaternion.y = y;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="z"/> value to the z component.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithZ(this Quaternion quaternion, float z)
        {
            quaternion.z = z;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="w"/> value to the w component.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithW(this Quaternion quaternion, float w)
        {
            quaternion.w = w;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/> and <paramref name="y"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXY(this Quaternion quaternion, float x, float y)
        {
            quaternion.x = x;
            quaternion.y = y;
            return quaternion;
        }

        /// <summary>
        /// Sets the x and y quaternion components from the x and y components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXY(this Quaternion quaternion, Vector2 values)
        {
            quaternion.x = values.x;
            quaternion.y = values.y;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/> and <paramref name="z"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXZ(this Quaternion quaternion, float x, float z)
        {
            quaternion.x = x;
            quaternion.z = z;
            return quaternion;
        }

        /// <summary>
        /// Sets the x and z quaternion components from the x and y components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXZ(this Quaternion quaternion, Vector2 values)
        {
            quaternion.x = values.x;
            quaternion.z = values.y;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="y"/> and <paramref name="z"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithYZ(this Quaternion quaternion, float y, float z)
        {
            quaternion.y = y;
            quaternion.z = z;
            return quaternion;
        }

        /// <summary>
        /// Sets the y and z quaternion components from the x and y components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithYZ(this Quaternion quaternion, Vector2 values)
        {
            quaternion.y = values.x;
            quaternion.z = values.y;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/> and <paramref name="w"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXW(this Quaternion quaternion, float x, float w)
        {
            quaternion.x = x;
            quaternion.w = w;
            return quaternion;
        }

        /// <summary>
        /// Sets the x and w quaternion components from the x and y components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXW(this Quaternion quaternion, Vector2 values)
        {
            quaternion.x = values.x;
            quaternion.w = values.y;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="y"/> and <paramref name="w"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithYW(this Quaternion quaternion, float y, float w)
        {
            quaternion.y = y;
            quaternion.w = w;
            return quaternion;
        }

        /// <summary>
        /// Sets the y and w quaternion components from the x and y components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithYW(this Quaternion quaternion, Vector2 values)
        {
            quaternion.y = values.x;
            quaternion.w = values.y;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="z"/> and <paramref name="w"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithZW(this Quaternion quaternion, float z, float w)
        {
            quaternion.z = z;
            quaternion.w = w;
            return quaternion;
        }

        /// <summary>
        /// Sets the z and w quaternion components from the x and y components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithZW(this Quaternion quaternion, Vector2 values)
        {
            quaternion.z = values.x;
            quaternion.w = values.y;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/>, <paramref name="y"/> and <paramref name="z"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXYZ(this Quaternion quaternion, float x, float y, float z)
        {
            quaternion.x = x;
            quaternion.y = y;
            quaternion.z = z;
            return quaternion;
        }

        /// <summary>
        /// Sets the x, y and z quaternion components from the x, y and z components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXYZ(this Quaternion quaternion, Vector3 values)
        {
            quaternion.x = values.x;
            quaternion.y = values.y;
            quaternion.z = values.z;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/>, <paramref name="y"/> and <paramref name="w"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXYW(this Quaternion quaternion, float x, float y, float w)
        {
            quaternion.x = x;
            quaternion.y = y;
            quaternion.w = w;
            return quaternion;
        }

        /// <summary>
        /// Sets the x, y and w quaternion components from the x, y and z components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXYW(this Quaternion quaternion, Vector3 values)
        {
            quaternion.x = values.x;
            quaternion.y = values.y;
            quaternion.w = values.z;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="x"/>, <paramref name="z"/> and <paramref name="w"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXZW(this Quaternion quaternion, float x, float z, float w)
        {
            quaternion.x = x;
            quaternion.z = z;
            quaternion.w = w;
            return quaternion;
        }

        /// <summary>
        /// Sets the x, z and w quaternion components from the x, y and z components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithXZW(this Quaternion quaternion, Vector3 values)
        {
            quaternion.x = values.x;
            quaternion.z = values.y;
            quaternion.w = values.z;
            return quaternion;
        }

        /// <summary>
        /// Sets <paramref name="y"/>, <paramref name="z"/> and <paramref name="w"/> values to the corresponding components.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        /// <param name="w">Value to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithYZW(this Quaternion quaternion, float y, float z, float w)
        {
            quaternion.y = y;
            quaternion.z = z;
            quaternion.w = w;
            return quaternion;
        }

        /// <summary>
        /// Sets the y, z and w quaternion components from the x, y and z components of <paramref name="values"/>, respectively.
        /// </summary>
        /// <param name="quaternion">Target quaternion.</param>
        /// <param name="values">Component values to set.</param>
        /// <returns>Changed copy of the <paramref name="quaternion"/>.</returns>
        public static Quaternion WithYZW(this Quaternion quaternion, Vector3 values)
        {
            quaternion.y = values.x;
            quaternion.z = values.y;
            quaternion.w = values.z;
            return quaternion;
        }
    }
}