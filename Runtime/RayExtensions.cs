using UnityEngine;

namespace Unixtensions
{
    public static class RayExtensions
	{
        /// <summary>
        /// Creates a ray starting at the specified distance along the original ray and pointing in the opposite direction.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="maxDistance">Distance along the original ray to the origin of the reversed ray.</param>
        /// <returns>Reversed ray.</returns>
		public static Ray Reversed(this Ray ray, float maxDistance) => new Ray(ray.GetPoint(maxDistance), -ray.direction);

        /// <summary>
        /// Randomly deflects the ray direction using <paramref name="angle"/> as the horizontal and vertical angular limit.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angle">Maximum horizontal and vertical angular deviation, in degrees.</param>
        /// <returns>A ray with the same origin and a randomly deflected direction.</returns>
        public static Ray WithRandomDeflection(this Ray ray, float angle) => WithRandomDeflection(ray, new Vector2(angle, angle), Vector3.up);

        /// <summary>
        /// Randomly deflects the ray direction using <paramref name="angle"/> as the horizontal and vertical angular limit and <paramref name="up"/> to orient the local frame.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angle">Maximum horizontal and vertical angular deviation, in degrees.</param>
        /// <param name="up">Up direction used to orient the ray's local frame.</param>
        /// <returns>A ray with the same origin and a randomly deflected direction.</returns>
        public static Ray WithRandomDeflection(this Ray ray, float angle, Vector3 up) => WithRandomDeflection(ray, new Vector2(angle, angle), up);

        /// <summary>
        /// Randomly deflects the ray direction using the horizontal limit <paramref name="angleX"/> and vertical limit <paramref name="angleY"/>.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angleX">Maximum horizontal angular deviation about the local y axis, in degrees.</param>
        /// <param name="angleY">Maximum vertical angular deviation about the local x axis, in degrees.</param>
        /// <returns>A ray with the same origin and a randomly deflected direction.</returns>
        public static Ray WithRandomDeflection(this Ray ray, float angleX, float angleY) => WithRandomDeflection(ray, new Vector2(angleX, angleY), Vector3.up);

        /// <summary>
        /// Randomly deflects the ray direction using the specified angular limits and <paramref name="up"/> to orient the local frame.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angleX">Maximum horizontal angular deviation about the local y axis, in degrees.</param>
        /// <param name="angleY">Maximum vertical angular deviation about the local x axis, in degrees.</param>
        /// <param name="up">Up direction used to orient the ray's local frame.</param>
        /// <returns>A ray with the same origin and a randomly deflected direction.</returns>
        public static Ray WithRandomDeflection(this Ray ray, float angleX, float angleY, Vector3 up) => WithRandomDeflection(ray, new Vector2(angleX, angleY), up);

        /// <summary>
        /// Randomly deflects the ray direction using the horizontal and vertical angular limits in <paramref name="angles"/>.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angles">Maximum horizontal (x) and vertical (y) angular deviations, in degrees.</param>
        /// <returns>A ray with the same origin and a randomly deflected direction.</returns>
        public static Ray WithRandomDeflection(this Ray ray, Vector2 angles) => WithRandomDeflection(ray, angles, Vector3.up);

        /// <summary>
        /// Randomly deflects the ray direction using the angular limits in <paramref name="angles"/> and <paramref name="up"/> to orient the local frame.
        /// </summary>
        /// <param name="ray">Target ray.</param>
        /// <param name="angles">Maximum horizontal (x) and vertical (y) angular deviations, in degrees.</param>
        /// <param name="up">Up direction used to orient the ray's local frame.</param>
        /// <returns>A ray with the same origin and a randomly deflected direction.</returns>
        public static Ray WithRandomDeflection(this Ray ray, Vector2 angles, Vector3 up)
        {
            return new Ray(ray.origin, ray.direction.WithRandomDeflection(angles, up));
        }
    }
}