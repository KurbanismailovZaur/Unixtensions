using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unixtensions
{
    public static class RenderTextureExtensions
    {
        /// <summary>
        /// Creates a texture and copies the pixels of <paramref name="renderTexture"/> into it.
        /// </summary>
        /// <param name="renderTexture">The render texture.</param>
        /// <param name="format">Pixel format of the created texture.</param>
        /// <returns>The created texture.</returns>
        public static Texture2D ToTexture2D(this RenderTexture renderTexture, TextureFormat format)
        {
            var texture = new Texture2D(renderTexture.width, renderTexture.height, format, false);
            renderTexture.WriteToTexture2D(texture);

            return texture;
        }

        /// <summary>
        /// Copies the pixels of <paramref name="renderTexture"/> into <paramref name="texture"/>.
        /// </summary>
        /// <param name="renderTexture">The render texture.</param>
        /// <param name="texture">Destination texture for the copied pixels.</param>
        public static void WriteToTexture2D(this RenderTexture renderTexture, Texture2D texture)
        {
            var oldRenderTexture = RenderTexture.active;

            try
            {
                RenderTexture.active = renderTexture;
                texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
                texture.Apply();
            }
            finally
            {
                RenderTexture.active = oldRenderTexture;
            }
        }

        /// <summary>
        /// Creates a sprite backed by a new texture containing the pixels of <paramref name="renderTexture"/>.
        /// </summary>
        /// <param name="renderTexture">The render texture.</param>
        /// <param name="format">Pixel format of the sprite's created texture.</param>
        /// <returns>The created sprite.</returns>
        public static Sprite ToSprite(this RenderTexture renderTexture, TextureFormat format)
        {
            var texture = renderTexture.ToTexture2D(format);
            return Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }

        /// <summary>
        /// Copies the pixels of <paramref name="renderTexture"/> into the texture backing <paramref name="sprite"/>.
        /// </summary>
        /// <param name="renderTexture">The render texture.</param>
        /// <param name="sprite">Sprite whose backing texture receives the copied pixels.</param>
        public static void WriteToSprite(this RenderTexture renderTexture, Sprite sprite)
        {
            renderTexture.WriteToTexture2D(sprite.texture);
        }
    }
}