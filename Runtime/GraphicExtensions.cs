using UnityEngine;
using UnityEngine.UI;

namespace Unixtensions
{
    public static class GraphicExtensions
    {
        /// <summary>
        /// Sets the red channel of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="r">The red channel value to set.</param>
        public static void SetColorR(this Graphic graphic, float r) => graphic.color = graphic.color.WithR(r);

        /// <summary>
        /// Sets the green channel of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="g">The green channel value to set.</param>
        public static void SetColorG(this Graphic graphic, float g) => graphic.color = graphic.color.WithG(g);

        /// <summary>
        /// Sets the blue channel of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="b">The blue channel value to set.</param>
        public static void SetColorB(this Graphic graphic, float b) => graphic.color = graphic.color.WithB(b);

        /// <summary>
        /// Sets the alpha channel of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="a">The alpha channel value to set.</param>
        public static void SetColorA(this Graphic graphic, float a) => graphic.color = graphic.color.WithA(a);

        /// <summary>
        /// Sets the red and green channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="r">The red channel value to set.</param>
        /// <param name="g">The green channel value to set.</param>
        public static void SetColorRG(this Graphic graphic, float r, float g) => graphic.color = graphic.color.WithRG(r, g);

        /// <summary>
        /// Sets the red and blue channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="r">The red channel value to set.</param>
        /// <param name="b">The blue channel value to set.</param>
        public static void SetColorRB(this Graphic graphic, float r, float b) => graphic.color = graphic.color.WithRB(r, b);

        /// <summary>
        /// Sets the red and alpha channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="r">The red channel value to set.</param>
        /// <param name="a">The alpha channel value to set.</param>
        public static void SetColorRA(this Graphic graphic, float r, float a) => graphic.color = graphic.color.WithRA(r, a);

        /// <summary>
        /// Sets the green and blue channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="g">The green channel value to set.</param>
        /// <param name="b">The blue channel value to set.</param>
        public static void SetColorGB(this Graphic graphic, float g, float b) => graphic.color = graphic.color.WithGB(g, b);

        /// <summary>
        /// Sets the green and alpha channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="g">The green channel value to set.</param>
        /// <param name="a">The alpha channel value to set.</param>
        public static void SetColorGA(this Graphic graphic, float g, float a) => graphic.color = graphic.color.WithGA(g, a);

        /// <summary>
        /// Sets the blue and alpha channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="b">The blue channel value to set.</param>
        /// <param name="a">The alpha channel value to set.</param>
        public static void SetColorBA(this Graphic graphic, float b, float a) => graphic.color = graphic.color.WithBA(b, a);

        /// <summary>
        /// Sets the red, green and blue channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="r">The red channel value to set.</param>
        /// <param name="g">The green channel value to set.</param>
        /// <param name="b">The blue channel value to set.</param>
        public static void SetColorRGB(this Graphic graphic, float r, float g, float b) => graphic.color = graphic.color.WithRGB(r, g, b);

        /// <summary>
        /// Sets the red, green and blue channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="color">The source of the red, green and blue channel values; its alpha is ignored.</param>
        public static void SetColorRGB(this Graphic graphic, Color color) => graphic.color = color.WithA(graphic.color.a);

        /// <summary>
        /// Sets the red, green and alpha channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="r">The red channel value to set.</param>
        /// <param name="g">The green channel value to set.</param>
        /// <param name="a">The alpha channel value to set.</param>
        public static void SetColorRGA(this Graphic graphic, float r, float g, float a) => graphic.color = graphic.color.WithRGA(r, g, a);

        /// <summary>
        /// Sets the red, blue and alpha channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="r">The red channel value to set.</param>
        /// <param name="b">The blue channel value to set.</param>
        /// <param name="a">The alpha channel value to set.</param>
        public static void SetColorRBA(this Graphic graphic, float r, float b, float a) => graphic.color = graphic.color.WithRBA(r, b, a);

        /// <summary>
        /// Sets the green, blue and alpha channels of the graphic's color, preserving the other channels.
        /// </summary>
        /// <param name="graphic">The graphic to modify.</param>
        /// <param name="g">The green channel value to set.</param>
        /// <param name="b">The blue channel value to set.</param>
        /// <param name="a">The alpha channel value to set.</param>
        public static void SetColorGBA(this Graphic graphic, float g, float b, float a) => graphic.color = graphic.color.WithGBA(g, b, a);
    }
}