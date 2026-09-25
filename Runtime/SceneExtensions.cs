using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.SceneManagement;

namespace Unixtensions
{
    public static class SceneExtensions
    {
        /// <summary>
        /// Finds the first component of type <typeparamref name="T"/> in the scene.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <param name="scene">Target scene.</param>
        /// <param name="includeInactive">Whether to include components on inactive game objects.</param>
        /// <returns>The first matching component, or <see langword="null"/> if none is found.</returns>
        public static T FindObjectOfType<T>(this Scene scene, bool includeInactive = false) where T : Component
        {
            using (ListPool<GameObject>.Get(out var roots))
            {
                scene.GetRootGameObjects(roots);

                foreach (var root in roots)
                {
                    if (!includeInactive && !root.activeSelf)
                        continue;

                    if (root.TryGetComponentInChildren<T>(out T component, includeInactive))
                        return component;
                }

                return null;
            }
        }

        /// <summary>
        /// Finds all components of type <typeparamref name="T"/> in the scene.
        /// </summary>
        /// <typeparam name="T">Component type.</typeparam>
        /// <param name="scene">Target scene.</param>
        /// <param name="includeInactive">Whether to include components on inactive game objects.</param>
        /// <returns>An array of matching components.</returns>
        public static T[] FindObjectsOfType<T>(this Scene scene, bool includeInactive = false)
        {
            using (ListPool<GameObject>.Get(out var roots))
            using (ListPool<T>.Get(out var components))
            using (ListPool<T>.Get(out var results))
            {
                scene.GetRootGameObjects(roots);

                foreach (var root in roots)
                {
                    if (!includeInactive && !root.activeSelf)
                        continue;

                    root.GetComponentsInChildren(includeInactive, components);
                    results.AddRange(components);
                }

                return results.ToArray();
            }
        }

        /// <summary>
        /// Counts game objects in the scene, including root objects and their descendants.
        /// </summary>
        /// <param name="scene">Target scene.</param>
        /// <param name="includeInactive">Whether to count inactive game objects.</param>
        /// <returns>The number of game objects included in the count.</returns>
        public static int ObjectsCount(this Scene scene, bool includeInactive = false)
        {
            using (ListPool<GameObject>.Get(out var roots))
            using (ListPool<Transform>.Get(out var transforms))
            {
                scene.GetRootGameObjects(roots);
                var count = 0;

                foreach (var root in roots)
                {
                    if (!includeInactive && !root.activeSelf)
                        continue;

                    root.GetComponentsInChildren(includeInactive, transforms);
                    count += transforms.Count;
                }

                return count;
            }
        }
    }
}
