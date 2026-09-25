using UnityEngine;
using UnityEngine.UI;

namespace Unixtensions
{
    public static class CameraExtensions
    {
        /// <summary>
        /// Sets the red channel of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        public static void SetBackgroundColorR(this Camera camera, float r) => camera.backgroundColor = camera.backgroundColor.WithR(r);

        /// <summary>
        /// Sets the green channel of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="g">Value of the green channel.</param>
        public static void SetBackgroundColorG(this Camera camera, float g) => camera.backgroundColor = camera.backgroundColor.WithG(g);

        /// <summary>
        /// Sets the blue channel of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="b">Value of the blue channel.</param>
        public static void SetBackgroundColorB(this Camera camera, float b) => camera.backgroundColor = camera.backgroundColor.WithB(b);

        /// <summary>
        /// Sets the alpha channel of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorA(this Camera camera, float a) => camera.backgroundColor = camera.backgroundColor.WithA(a);

        /// <summary>
        /// Sets the red and green channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="g">Value of the green channel.</param>
        public static void SetBackgroundColorRG(this Camera camera, float r, float g) => camera.backgroundColor = camera.backgroundColor.WithRG(r, g);

        /// <summary>
        /// Sets the red and blue channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        public static void SetBackgroundColorRB(this Camera camera, float r, float b) => camera.backgroundColor = camera.backgroundColor.WithRB(r, b);

        /// <summary>
        /// Sets the red and alpha channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorRA(this Camera camera, float r, float a) => camera.backgroundColor = camera.backgroundColor.WithRA(r, a);

        /// <summary>
        /// Sets the green and blue channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        public static void SetBackgroundColorGB(this Camera camera, float g, float b) => camera.backgroundColor = camera.backgroundColor.WithGB(g, b);

        /// <summary>
        /// Sets the green and alpha channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorGA(this Camera camera, float g, float a) => camera.backgroundColor = camera.backgroundColor.WithGA(g, a);

        /// <summary>
        /// Sets the blue and alpha channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="b">Value of the blue channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorBA(this Camera camera, float b, float a) => camera.backgroundColor = camera.backgroundColor.WithBA(b, a);

        /// <summary>
        /// Sets the red, green, and blue channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        public static void SetBackgroundColorRGB(this Camera camera, float r, float g, float b) => camera.backgroundColor = camera.backgroundColor.WithRGB(r, g, b);

        /// <summary>
        /// Sets the red, green, and alpha channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorRGA(this Camera camera, float r, float g, float a) => camera.backgroundColor = camera.backgroundColor.WithRGA(r, g, a);

        /// <summary>
        /// Sets the red, blue, and alpha channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="r">Value of the red channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorRBA(this Camera camera, float r, float b, float a) => camera.backgroundColor = camera.backgroundColor.WithRBA(r, b, a);

        /// <summary>
        /// Sets the green, blue, and alpha channels of the camera's background color.
        /// </summary>
        /// <param name="camera">Target camera.</param>
        /// <param name="g">Value of the green channel.</param>
        /// <param name="b">Value of the blue channel.</param>
        /// <param name="a">Value of the alpha channel.</param>
        public static void SetBackgroundColorGBA(this Camera camera, float g, float b, float a) => camera.backgroundColor = camera.backgroundColor.WithGBA(g, b, a);
    }
}