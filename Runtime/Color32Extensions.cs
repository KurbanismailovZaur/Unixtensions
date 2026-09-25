using UnityEngine;

namespace Unixtensions
{
    public static class Color32Extensions
    {
        /// <summary>
        /// Returns a copy of the color with the specified red channel value.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The value to assign to the red channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithR(this Color32 color, byte r)
        {
            color.r = r;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified green channel value.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The value to assign to the green channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithG(this Color32 color, byte g)
        {
            color.g = g;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified blue channel value.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="b">The value to assign to the blue channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithB(this Color32 color, byte b)
        {
            color.b = b;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified alpha channel value.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="a">The value to assign to the alpha channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithA(this Color32 color, byte a)
        {
            color.a = a;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified red and green channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The value to assign to the red channel.</param>
        /// <param name="g">The value to assign to the green channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithRG(this Color32 color, byte r, byte g)
        {
            color.r = r;
            color.g = g;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified red and blue channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The value to assign to the red channel.</param>
        /// <param name="b">The value to assign to the blue channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithRB(this Color32 color, byte r, byte b)
        {
            color.r = r;
            color.b = b;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified red and alpha channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The value to assign to the red channel.</param>
        /// <param name="a">The value to assign to the alpha channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithRA(this Color32 color, byte r, byte a)
        {
            color.r = r;
            color.a = a;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified green and blue channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The value to assign to the green channel.</param>
        /// <param name="b">The value to assign to the blue channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithGB(this Color32 color, byte g, byte b)
        {
            color.g = g;
            color.b = b;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified green and alpha channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The value to assign to the green channel.</param>
        /// <param name="a">The value to assign to the alpha channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithGA(this Color32 color, byte g, byte a)
        {
            color.g = g;
            color.a = a;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified blue and alpha channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="b">The value to assign to the blue channel.</param>
        /// <param name="a">The value to assign to the alpha channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithBA(this Color32 color, byte b, byte a)
        {
            color.b = b;
            color.a = a;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified red, green, and blue channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The value to assign to the red channel.</param>
        /// <param name="g">The value to assign to the green channel.</param>
        /// <param name="b">The value to assign to the blue channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithRGB(this Color32 color, byte r, byte g, byte b)
        {
            color.r = r;
            color.g = g;
            color.b = b;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified red, green, and alpha channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The value to assign to the red channel.</param>
        /// <param name="g">The value to assign to the green channel.</param>
        /// <param name="a">The value to assign to the alpha channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithRGA(this Color32 color, byte r, byte g, byte a)
        {
            color.r = r;
            color.g = g;
            color.a = a;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified red, blue, and alpha channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The value to assign to the red channel.</param>
        /// <param name="b">The value to assign to the blue channel.</param>
        /// <param name="a">The value to assign to the alpha channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithRBA(this Color32 color, byte r, byte b, byte a)
        {
            color.r = r;
            color.b = b;
            color.a = a;
            return color;
        }

        /// <summary>
        /// Returns a copy of the color with the specified green, blue, and alpha channel values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The value to assign to the green channel.</param>
        /// <param name="b">The value to assign to the blue channel.</param>
        /// <param name="a">The value to assign to the alpha channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color32 WithGBA(this Color32 color, byte g, byte b, byte a)
        {
            color.g = g;
            color.b = b;
            color.a = a;
            return color;
        }
    }
}