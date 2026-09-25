using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unixtensions
{
    public static class ComponentExtensions
    {
        /// <summary>
        /// Gets a component of type <typeparamref name="T"/> from <paramref name="component"/>'s GameObject,
        /// or adds one if none exists.
        /// </summary>
        /// <typeparam name="T">The type of component to get or add.</typeparam>
        /// <param name="component">The component whose GameObject is searched or receives the new component.</param>
        /// <returns>The existing or newly added component of type <typeparamref name="T"/>.</returns>
        public static T GetOrAddComponent<T>(this Component component) where T : Component
        {
            return component.gameObject.GetOrAddComponent<T>();
        }

        /// <summary>
        /// Attempts to find a component of type <typeparamref name="T"/> on <paramref name="sourceComponent"/>'s GameObject
        /// or any of its descendants.
        /// </summary>
        /// <typeparam name="T">The type of component to find.</typeparam>
        /// <param name="sourceComponent">The component whose GameObject is searched first.</param>
        /// <param name="component">The component found, or <see langword="null"/> if no component was found.</param>
        /// <param name="includeInactive">Whether to include inactive child GameObjects in the search.</param>
        /// <returns><see langword="true"/> if a component was found; otherwise, <see langword="false"/>.</returns>
        public static bool TryGetComponentInChildren<T>(this Component sourceComponent, out T component, bool includeInactive = false) where T : Component
        {
            return component = sourceComponent.gameObject.GetComponentInChildren<T>(includeInactive);
        }

        /// <summary>
        /// Attempts to find a component of type <typeparamref name="T"/> on <paramref name="sourceComponent"/>'s GameObject
        /// or any of its ancestors.
        /// </summary>
        /// <typeparam name="T">The type of component to find.</typeparam>
        /// <param name="sourceComponent">The component whose GameObject is searched first.</param>
        /// <param name="component">The component found, or <see langword="null"/> if no component was found.</param>
        /// <param name="includeInactive">Whether to include inactive parent GameObjects in the search.</param>
        /// <returns><see langword="true"/> if a component was found; otherwise, <see langword="false"/>.</returns>
        public static bool TryGetComponentInParent<T>(this Component sourceComponent, out T component, bool includeInactive = false) where T : Component
        {
            return component = sourceComponent.gameObject.GetComponentInParent<T>(includeInactive);
        }
    }
}
