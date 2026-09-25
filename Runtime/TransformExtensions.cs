using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityObject = UnityEngine.Object;

namespace Unixtensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Sets x position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetPositionX(this Transform transform, float x) => transform.position = transform.position.WithX(x);

        /// <summary>
        /// Sets y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPositionY(this Transform transform, float y) => transform.position = transform.position.WithY(y);

        /// <summary>
        /// Sets z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetPositionZ(this Transform transform, float z) => transform.position = transform.position.WithZ(z);

        /// <summary>
        /// Sets x and y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPositionXY(this Transform transform, float x, float y) => transform.position = transform.position.WithXY(x, y);

        /// <summary>
        /// Sets x and y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetPositionXY(this Transform transform, Vector2 position) => transform.position = transform.position.WithXY(position);

        /// <summary>
        /// Sets x and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetPositionXZ(this Transform transform, float x, float z) => transform.position = transform.position.WithXZ(x, z);

        /// <summary>
        /// Sets x and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetPositionXZ(this Transform transform, Vector2 position) => transform.position = transform.position.WithXZ(position);

        /// <summary>
        /// Sets y and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetPositionYZ(this Transform transform, float y, float z) => transform.position = transform.position.WithYZ(y, z);

        /// <summary>
        /// Sets y and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetPositionYZ(this Transform transform, Vector2 position) => transform.position = transform.position.WithYZ(position);

        /// <summary>
        /// Sets local x position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetLocalPositionX(this Transform transform, float x) => transform.localPosition = transform.localPosition.WithX(x);

        /// <summary>
        /// Sets local y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalPositionY(this Transform transform, float y) => transform.localPosition = transform.localPosition.WithY(y);

        /// <summary>
        /// Sets local z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalPositionZ(this Transform transform, float z) => transform.localPosition = transform.localPosition.WithZ(z);

        /// <summary>
        /// Sets local x and y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalPositionXY(this Transform transform, float x, float y) => transform.localPosition = transform.localPosition.WithXY(x, y);

        /// <summary>
        /// Sets local x and y position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        /// <remarks>The current implementation assigns the modified local position to world position.</remarks>
        public static void SetLocalPositionXY(this Transform transform, Vector2 position) => transform.localPosition = transform.localPosition.WithXY(position);

        /// <summary>
        /// Sets local x and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalPositionXZ(this Transform transform, float x, float z) => transform.localPosition = transform.localPosition.WithXZ(x, z);

        /// <summary>
        /// Sets local x and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        /// <remarks>The current implementation assigns the modified local position to world position.</remarks>
        public static void SetLocalPositionXZ(this Transform transform, Vector2 position) => transform.localPosition = transform.localPosition.WithXZ(position);

        /// <summary>
        /// Sets local y and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalPositionYZ(this Transform transform, float y, float z) => transform.localPosition = transform.localPosition.WithYZ(y, z);

        /// <summary>
        /// Sets local y and z position of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="position">Position to set.</param>
        /// <remarks>The current implementation assigns the modified local position to world position.</remarks>
        public static void SetLocalPositionYZ(this Transform transform, Vector2 position) => transform.localPosition = transform.localPosition.WithYZ(position);

        /// <summary>
        /// Sets Euler angles x value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetEulerAnglesX(this Transform transform, float x) => transform.eulerAngles = transform.eulerAngles.WithX(x);

        /// <summary>
        /// Sets Euler angles y value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetEulerAnglesY(this Transform transform, float y) => transform.eulerAngles = transform.eulerAngles.WithY(y);

        /// <summary>
        /// Sets Euler angles z value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetEulerAnglesZ(this Transform transform, float z) => transform.eulerAngles = transform.eulerAngles.WithZ(z);

        /// <summary>
        /// Sets Euler angles x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetEulerAnglesXY(this Transform transform, float x, float y) => transform.eulerAngles = transform.eulerAngles.WithXY(x, y);

        /// <summary>
        /// Sets Euler angles x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetEulerAnglesXY(this Transform transform, Vector2 eulers) => transform.eulerAngles = transform.eulerAngles.WithXY(eulers);

        /// <summary>
        /// Sets Euler angles x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetEulerAnglesXZ(this Transform transform, float x, float z) => transform.eulerAngles = transform.eulerAngles.WithXZ(x, z);

        /// <summary>
        /// Sets Euler angles x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetEulerAnglesXZ(this Transform transform, Vector2 eulers) => transform.eulerAngles = transform.eulerAngles.WithXZ(eulers);

        /// <summary>
        /// Sets Euler angles y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetEulerAnglesYZ(this Transform transform, float y, float z) => transform.eulerAngles = transform.eulerAngles.WithYZ(y, z);

        /// <summary>
        /// Sets Euler angles y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetEulerAnglesYZ(this Transform transform, Vector2 eulers) => transform.eulerAngles = transform.eulerAngles.WithYZ(eulers);

        /// <summary>
        /// Sets local Euler angles x value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetLocalEulerAnglesX(this Transform transform, float x) => transform.localEulerAngles = transform.localEulerAngles.WithX(x);

        /// <summary>
        /// Sets local Euler angles y value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalEulerAnglesY(this Transform transform, float y) => transform.localEulerAngles = transform.localEulerAngles.WithY(y);

        /// <summary>
        /// Sets local Euler angles z value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalEulerAnglesZ(this Transform transform, float z) => transform.localEulerAngles = transform.localEulerAngles.WithZ(z);

        /// <summary>
        /// Sets local Euler angles x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalEulerAnglesXY(this Transform transform, float x, float y) => transform.localEulerAngles = transform.localEulerAngles.WithXY(x, y);

        /// <summary>
        /// Sets local Euler angles x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetLocalEulerAnglesXY(this Transform transform, Vector2 eulers) => transform.localEulerAngles = transform.localEulerAngles.WithXY(eulers);

        /// <summary>
        /// Sets local Euler angles x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalEulerAnglesXZ(this Transform transform, float x, float z) => transform.localEulerAngles = transform.localEulerAngles.WithXZ(x, z);

        /// <summary>
        /// Sets local Euler angles x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetLocalEulerAnglesXZ(this Transform transform, Vector2 eulers) => transform.localEulerAngles = transform.localEulerAngles.WithXZ(eulers);

        /// <summary>
        /// Sets local Euler angles y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalEulerAnglesYZ(this Transform transform, float y, float z) => transform.localEulerAngles = transform.localEulerAngles.WithYZ(y, z);

        /// <summary>
        /// Sets local Euler angles y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="eulers">Angles to set.</param>
        public static void SetLocalEulerAnglesYZ(this Transform transform, Vector2 eulers) => transform.localEulerAngles = transform.localEulerAngles.WithYZ(eulers);

        /// <summary>
        /// Sets local scale x value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetLocalScaleX(this Transform transform, float x) => transform.localScale = transform.localScale.WithX(x);

        /// <summary>
        /// Sets local scale y value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalScaleY(this Transform transform, float y) => transform.localScale = transform.localScale.WithY(y);

        /// <summary>
        /// Sets local scale z value of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalScaleZ(this Transform transform, float z) => transform.localScale = transform.localScale.WithZ(z);

        /// <summary>
        /// Sets local scale x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetLocalScaleXY(this Transform transform, float x, float y) => transform.localScale = transform.localScale.WithXY(x, y);

        /// <summary>
        /// Sets local scale x and y values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="scale">Scale to set.</param>
        public static void SetLocalScaleXY(this Transform transform, Vector2 scale) => transform.localScale = transform.localScale.WithXY(scale);

        /// <summary>
        /// Sets local scale x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalScaleXZ(this Transform transform, float x, float z) => transform.localScale = transform.localScale.WithXZ(x, z);

        /// <summary>
        /// Sets local scale x and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="scale">Scale to set.</param>
        public static void SetLocalScaleXZ(this Transform transform, Vector2 scale) => transform.localScale = transform.localScale.WithXZ(scale);

        /// <summary>
        /// Sets local scale y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetLocalScaleYZ(this Transform transform, float y, float z) => transform.localScale = transform.localScale.WithYZ(y, z);

        /// <summary>
        /// Sets local scale y and z values of transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="scale">Scale to set.</param>
        public static void SetLocalScaleYZ(this Transform transform, Vector2 scale) => transform.localScale = transform.localScale.WithYZ(scale);

        /// <summary>
        /// Sets uniform local scale.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="scale">Uniform scale to set.</param>
        public static void SetLocalScale(this Transform transform, float scale) => transform.localScale = new Vector3(scale, scale, scale);

        /// <summary>
        /// Resets position and rotation to zero and identity, and local scale to one.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="useWorldSpace">Whether to reset position and rotation in world space instead of local space. Scale is always reset locally.</param>
        public static void Reset(this Transform transform, bool useWorldSpace = false)
        {
            if (useWorldSpace)
                transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            else
            {
#if UNITY_6000_0_OR_NEWER
                transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
#else
                transform.localPosition = Vector3.zero;
                transform.localRotation = Quaternion.identity;
#endif
            }

            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// Sets sibling index to previous.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void SetToPreviousSibling(this Transform transform) => transform.SetSiblingIndex(Mathf.Max(transform.GetSiblingIndex() - 1, 0));

        /// <summary>
        /// Sets sibling index to next.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void SetToNextSibling(this Transform transform)
        {
            var parent = transform.parent;
            var maxSiblingIndex = (parent != null ? parent.childCount : transform.gameObject.scene.rootCount) - 1;
            transform.SetSiblingIndex(Mathf.Min(transform.GetSiblingIndex() + 1, maxSiblingIndex));
        }

        /// <summary>
        /// Returns the previous sibling transform, or null if this is the first sibling.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>The previous sibling transform, or <see langword="null"/> if there is none.</returns>
        public static Transform GetPreviousSiblingTransform(this Transform transform)
        {
            var siblingIndex = transform.GetSiblingIndex();
            if (siblingIndex == 0)
                return null;

            var parent = transform.parent;
            if (parent)
                return parent.GetChild(siblingIndex - 1);

            using (ListPool<GameObject>.Get(out var roots))
            {
                transform.gameObject.scene.GetRootGameObjects(roots);
                return roots[siblingIndex - 1].transform;
            }
        }

        /// <summary>
        /// Returns the next sibling transform, or null if this is the last sibling.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>The next sibling transform, or <see langword="null"/> if there is none.</returns>
        public static Transform GetNextSiblingTransform(this Transform transform)
        {
            var parent = transform.parent;
            var siblingIndex = transform.GetSiblingIndex();
            if (parent)
            {
                if (siblingIndex == parent.childCount - 1)
                    return null;

                return parent.GetChild(siblingIndex + 1);
            }

            var scene = transform.gameObject.scene;
            if (siblingIndex == scene.rootCount - 1)
                return null;

            using (ListPool<GameObject>.Get(out var roots))
            {
                scene.GetRootGameObjects(roots);
                return roots[siblingIndex + 1].transform;
            }
        }

        /// <summary>
        /// Returns the transforms of all sibling objects.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="includeThis">Include this <paramref name="transform"/> object.</param>
        /// <returns>The sibling transforms, including this transform when requested.</returns>
        public static List<Transform> GetAllSiblingObjects(this Transform transform, bool includeThis = true)
        {
            var parent = transform.parent;
            if (parent)
            {
                var childCount = parent.childCount;
                var siblings = new List<Transform>(childCount);

                for (int i = 0; i < childCount; i++)
                {
                    var child = parent.GetChild(i);

                    if (includeThis || child != transform)
                        siblings.Add(child);
                }

                return siblings;
            }

            using (ListPool<GameObject>.Get(out var roots))
            {
                transform.gameObject.scene.GetRootGameObjects(roots);
                var siblings = new List<Transform>(roots.Count);

                for (int i = 0; i < roots.Count; i++)
                {
                    var child = roots[i].transform;

                    if (includeThis || child != transform)
                        siblings.Add(child);
                }

                return siblings;
            }
        }

        /// <summary>
        /// Gets a list of all direct children.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>A list of all direct child transforms.</returns>
        public static List<Transform> GetChilds(this Transform transform)
        {
            var childCount = transform.childCount;
            var childs = new List<Transform>(childCount);

            for (int i = 0; i < childCount; i++)
                childs.Add(transform.GetChild(i));

            return childs;
        }

        /// <summary>
        /// Gets a random child.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>Random child.</returns>
        public static Transform GetRandomChild(this Transform transform) => transform.GetChild(UnityEngine.Random.Range(0, transform.childCount));

        /// <summary>
        /// Reparents the supplied transforms to this transform.
        /// </summary>
        /// <param name="childs">Children to reparent.</param>
        /// <param name="transform">Target transform.</param>
        public static void AddChilds(this Transform transform, params Transform[] childs) => AddChilds(transform, (IEnumerable<Transform>)childs);

        /// <summary>
        /// Reparents the supplied transforms to this transform.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="childs">Children to reparent.</param>
        public static void AddChilds(this Transform transform, IEnumerable<Transform> childs)
        {
            using (ListPool<Transform>.Get(out var snapshot))
            {
                snapshot.AddRange(childs);

                foreach (var child in snapshot)
                    child.parent = transform;
            }
        }

        /// <summary>
        /// Destroys all direct child game objects.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyChilds(this Transform transform) => DestroyChilds(transform, 0);

        /// <summary>
        /// Destroys direct child game objects starting at <paramref name="index"/>.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="index">Zero-based index of the first child to destroy.</param>
        public static void DestroyChilds(this Transform transform, int index)
        {
            var childCount = transform.childCount;

            for (int i = Mathf.Max(index, 0); i < childCount; i++)
                UnityObject.Destroy(transform.GetChild(i).gameObject);
        }

        /// <summary>
        /// Destroys up to <paramref name="count"/> direct child game objects starting at <paramref name="index"/>.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="index">Zero-based index of the first child to destroy.</param>
        /// <param name="count">Maximum number of child game objects to destroy.</param>
        public static void DestroyChilds(this Transform transform, int index, int count)
        {
            var childCount = transform.childCount;
            var start = Mathf.Clamp(index, 0, childCount);
            var end = start + Mathf.Min(Mathf.Max(count, 0), childCount - start);

            for (int i = start; i < end; i++)
                UnityObject.Destroy(transform.GetChild(i).gameObject);
        }

        /// <summary>
        /// Destroys direct child game objects whose transforms satisfy the predicate.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="predicate">Condition.</param>
        public static void DestroyChildsWhere(this Transform transform, Predicate<Transform> predicate)
        {
            using (ListPool<Transform>.Get(out var snapshot))
            {
                var childCount = transform.childCount;

                for (int i = 0; i < childCount; i++)
                    snapshot.Add(transform.GetChild(i));

                foreach (var child in snapshot)
                {
                    if (predicate(child))
                        UnityObject.Destroy(child.gameObject);
                }
            }
        }

        /// <summary>
        /// Destroys the direct child game object at the specified index.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <param name="index">Zero-based index of the child to destroy.</param>
        public static void DestroyChild(this Transform transform, int index) => UnityObject.Destroy(transform.GetChild(index).gameObject);

        /// <summary>
        /// Destroys the first direct child game object.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyFirstChild(this Transform transform) => DestroyChild(transform, 0);

        /// <summary>
        /// Destroys the last direct child game object.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        public static void DestroyLastChild(this Transform transform) => DestroyChild(transform, transform.childCount - 1);

        /// <summary>
        /// Returns the transform as a RectTransform when the cast is valid.
        /// </summary>
        /// <param name="transform">Target transform.</param>
        /// <returns>The RectTransform, or <see langword="null"/> if the transform is not a RectTransform.</returns>
        public static RectTransform AsRect(this Transform transform) => transform as RectTransform;
    }
}