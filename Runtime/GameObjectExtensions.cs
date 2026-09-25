using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Unixtensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Gets a component of type <typeparamref name="T"/> from the GameObject, adding one if none is found.
        /// </summary>
        /// <typeparam name="T">The component type.</typeparam>
        /// <param name="gameObject">The GameObject to search.</param>
        /// <returns>The existing or newly added component.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (gameObject.TryGetComponent(out T component))
                return component;

            return gameObject.AddComponent<T>();
        }

        /// <summary>
        /// Tries to find a component on the GameObject or any of its descendants.
        /// </summary>
        /// <typeparam name="T">The component type.</typeparam>
        /// <param name="gameObject">The GameObject where the search starts.</param>
        /// <param name="component">The component found, or <see langword="null"/> if no component is found.</param>
        /// <param name="includeInactive">Whether to include inactive descendant GameObjects in the search.</param>
        /// <returns><see langword="true"/> if a component is found; otherwise, <see langword="false"/>.</returns>
        public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T component, bool includeInactive = false) where T : Component
        {
            return component = gameObject.GetComponentInChildren<T>(includeInactive);
        }

        /// <summary>
        /// Tries to find a component on the GameObject or one of its parents.
        /// </summary>
        /// <typeparam name="T">The component type.</typeparam>
        /// <param name="gameObject">The GameObject where the search starts.</param>
        /// <param name="component">The component found, or <see langword="null"/> if no component is found.</param>
        /// <param name="includeInactive">Whether to include inactive parent GameObjects in the search.</param>
        /// <returns><see langword="true"/> if a component is found; otherwise, <see langword="false"/>.</returns>
        public static bool TryGetComponentInParent<T>(this GameObject gameObject, out T component, bool includeInactive = false) where T : Component
        {
            return component = gameObject.GetComponentInParent<T>(includeInactive);
        }

        /// <summary>
        /// Checks whether the GameObject's layer is included in the layer mask.
        /// </summary>
        /// <param name="gameObject">The GameObject to check.</param>
        /// <param name="layerMask">The layer mask to check.</param>
        /// <returns><see langword="true"/> if the layer is included; otherwise, <see langword="false"/>.</returns>
        public static bool IsInLayerMask(this GameObject gameObject, LayerMask layerMask) => (layerMask.value & (1 << gameObject.layer)) != 0;

        /// <summary>
        /// Checks whether the GameObject's layer matches any of the named layers.
        /// </summary>
        /// <param name="gameObject">The GameObject to check.</param>
        /// <param name="layerNames">The names of the layers to check.</param>
        /// <returns><see langword="true"/> if the layer matches; otherwise, <see langword="false"/>.</returns>
        public static bool IsInLayers(this GameObject gameObject, params string[] layerNames) => IsInLayerMask(gameObject, LayerMask.GetMask(layerNames));

        /// <summary>
        /// Sets the layer of the GameObject and all its descendants.
        /// </summary>
        /// <param name="gameObject">The root GameObject.</param>
        /// <param name="layer">The name of the layer to assign.</param>
        public static void SetLayerRecursive(this GameObject gameObject, string layer) => SetLayerRecursive(gameObject, LayerMask.NameToLayer(layer));

        /// <summary>
        /// Sets the layer of the GameObject and all its descendants.
        /// </summary>
        /// <param name="gameObject">The root GameObject.</param>
        /// <param name="layer">The index of the layer to assign.</param>
        public static void SetLayerRecursive(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;
            
            var transform = gameObject.transform;
            for (int i = 0, count = transform.childCount; i < count; i++)
                SetLayerRecursive(transform.GetChild(i).gameObject, layer);
        }
    }
}