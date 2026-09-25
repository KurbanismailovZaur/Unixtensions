using UnityEngine;
using UnityEngine.UI;

namespace Codomaster.Extensions
{
    public static class CanvasScalerExtensions
    {
        /// <summary>
        /// Calculate the scale factor for <see cref="CanvasScaler.ScaleMode.ScaleWithScreenSize"/>
        /// using <see cref="CanvasScaler.ScreenMatchMode.MatchWidthOrHeight"/>.
        /// </summary>
        /// <param name="scaler">The canvas scaler.</param>
        /// <returns>Calculated scale factor.</returns>
        public static float GetScaleFactor(this CanvasScaler scaler)
        {
            const float logBase = 2f;
            var referenceResolution = scaler.referenceResolution;
            var logWidth = Mathf.Log(Screen.width / referenceResolution.x, logBase);
            var logHeight = Mathf.Log(Screen.height / referenceResolution.y, logBase);
            var logWeightedAverage = Mathf.Lerp(logWidth, logHeight, scaler.matchWidthOrHeight);

            return Mathf.Pow(logBase, logWeightedAverage);
        }
    }
}
