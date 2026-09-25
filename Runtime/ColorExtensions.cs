using UnityEngine;

namespace Unixtensions
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Returns a copy of the color with the specified red channel value.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The value to assign to the red channel.</param>
        /// <returns>A copy of the color with the specified changes.</returns>
        public static Color WithR(this Color color, float r)
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
        public static Color WithG(this Color color, float g)
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
        public static Color WithB(this Color color, float b)
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
        public static Color WithA(this Color color, float a)
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
        public static Color WithRG(this Color color, float r, float g)
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
        public static Color WithRB(this Color color, float r, float b)
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
        public static Color WithRA(this Color color, float r, float a)
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
        public static Color WithGB(this Color color, float g, float b)
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
        public static Color WithGA(this Color color, float g, float a)
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
        public static Color WithBA(this Color color, float b, float a)
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
        public static Color WithRGB(this Color color, float r, float g, float b)
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
        public static Color WithRGA(this Color color, float r, float g, float a)
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
        public static Color WithRBA(this Color color, float r, float b, float a)
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
        public static Color WithGBA(this Color color, float g, float b, float a)
        {
            color.g = g;
            color.b = b;
            color.a = a;
            return color;
        }
    }
}