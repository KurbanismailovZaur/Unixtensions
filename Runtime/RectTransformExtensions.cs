using UnityEngine;

namespace Unixtensions
{
    public static class RectTransformExtensions
    {
        /// <summary>
        /// Sets size delta x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetSizeDeltaX(this RectTransform rectTransform, float x) => rectTransform.sizeDelta = rectTransform.sizeDelta.WithX(x);

        /// <summary>
        /// Sets size delta y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetSizeDeltaY(this RectTransform rectTransform, float y) => rectTransform.sizeDelta = rectTransform.sizeDelta.WithY(y);

        /// <summary>
        /// Sets anchor min x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchorMinX(this RectTransform rectTransform, float x) => rectTransform.anchorMin = rectTransform.anchorMin.WithX(x);

        /// <summary>
        /// Sets anchor min y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchorMinY(this RectTransform rectTransform, float y) => rectTransform.anchorMin = rectTransform.anchorMin.WithY(y);

        /// <summary>
        /// Sets anchor max x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchorMaxX(this RectTransform rectTransform, float x) => rectTransform.anchorMax = rectTransform.anchorMax.WithX(x);

        /// <summary>
        /// Sets anchor max y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchorMaxY(this RectTransform rectTransform, float y) => rectTransform.anchorMax = rectTransform.anchorMax.WithY(y);

        /// <summary>
        /// Sets offset min x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetOffsetMinX(this RectTransform rectTransform, float x) => rectTransform.offsetMin = rectTransform.offsetMin.WithX(x);

        /// <summary>
        /// Sets the left edge offset from the minimum anchor using <see cref="SetOffsetMinX"/>.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Offset value.</param>
        public static void SetLeft(this RectTransform rectTransform, float x) => SetOffsetMinX(rectTransform, x);

        /// <summary>
        /// Sets offset min y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetOffsetMinY(this RectTransform rectTransform, float y) => rectTransform.offsetMin = rectTransform.offsetMin.WithY(y);

        /// <summary>
        /// Sets the bottom edge offset from the minimum anchor using <see cref="SetOffsetMinY"/>.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Offset value.</param>
        public static void SetBottom(this RectTransform rectTransform, float y) => SetOffsetMinY(rectTransform, y);

        /// <summary>
        /// Sets offset max x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetOffsetMaxX(this RectTransform rectTransform, float x) => rectTransform.offsetMax = rectTransform.offsetMax.WithX(x);

        /// <summary>
        /// Sets the right edge offset from the maximum anchor using <see cref="SetOffsetMaxX"/>. A positive value moves the edge to the right.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Offset value.</param>
        public static void SetRight(this RectTransform rectTransform, float x) => SetOffsetMaxX(rectTransform, x);

        /// <summary>
        /// Sets offset max y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetOffsetMaxY(this RectTransform rectTransform, float y) => rectTransform.offsetMax = rectTransform.offsetMax.WithY(y);

        /// <summary>
        /// Sets the top edge offset from the maximum anchor using <see cref="SetOffsetMaxY"/>. A positive value moves the edge up.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Offset value.</param>
        public static void SetTop(this RectTransform rectTransform, float y) => SetOffsetMaxY(rectTransform, y);

        /// <summary>
        /// Sets anchored position x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchoredPositionX(this RectTransform rectTransform, float x) => rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithX(x);

        /// <summary>
        /// Sets anchored position y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchoredPositionY(this RectTransform rectTransform, float y) => rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithY(y);

        /// <summary>
        /// Sets anchored position 3D x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetAnchoredPosition3DX(this RectTransform rectTransform, float x) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithX(x);

        /// <summary>
        /// Sets anchored position 3D y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchoredPosition3DY(this RectTransform rectTransform, float y) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithY(y);

        /// <summary>
        /// Sets anchored position 3D z value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="z">Value to set.</param>
        public static void SetAnchoredPosition3DZ(this RectTransform rectTransform, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithZ(z);

        /// <summary>
        /// Sets anchored position 3D x and y values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetAnchoredPosition3DXY(this RectTransform rectTransform, float x, float y) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXY(x, y);

        /// <summary>
        /// Sets anchored position 3D x and y values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetAnchoredPosition3DXY(this RectTransform rectTransform, Vector2 position) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXY(position.x, position.y);

        /// <summary>
        /// Sets anchored position 3D x and z values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetAnchoredPosition3DXZ(this RectTransform rectTransform, float x, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXZ(x, z);

        /// <summary>
        /// Sets anchored position 3D x and z values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetAnchoredPosition3DXZ(this RectTransform rectTransform, Vector2 position) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXZ(position.x, position.y);

        /// <summary>
        /// Sets anchored position 3D y and z values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        /// <param name="z">Value to set.</param>
        public static void SetAnchoredPosition3DYZ(this RectTransform rectTransform, float y, float z) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithYZ(y, z);

        /// <summary>
        /// Sets anchored position 3D y and z values of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="position">Position to set.</param>
        public static void SetAnchoredPosition3DYZ(this RectTransform rectTransform, Vector2 position) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithYZ(position.x, position.y);

        /// <summary>
        /// Sets pivot x value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetPivotX(this RectTransform rectTransform, float x) => rectTransform.pivot = rectTransform.pivot.WithX(x);

        /// <summary>
        /// Sets pivot y value of the rectTransform.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPivotY(this RectTransform rectTransform, float y) => rectTransform.pivot = rectTransform.pivot.WithY(y);

        /// <summary>
        /// Sets the pivot x component without moving the rectangle in world space.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        public static void SetPivotOnlyX(this RectTransform rectTransform, float x) => SetPivotOnly(rectTransform, new Vector2(x, rectTransform.pivot.y));

        /// <summary>
        /// Sets the pivot y component without moving the rectangle in world space.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPivotOnlyY(this RectTransform rectTransform, float y) => SetPivotOnly(rectTransform, new Vector2(rectTransform.pivot.x, y));

        /// <summary>
        /// Sets the pivot without moving the rectangle in world space, accounting for local rotation and scale.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="pivot">Value to set.</param>
        public static void SetPivotOnly(this RectTransform rectTransform, Vector2 pivot)
        {
            var rect = rectTransform.rect;
            var deltaPivot = pivot - rectTransform.pivot;
            var offset = new Vector3(deltaPivot.x * rect.width, deltaPivot.y * rect.height, 0f);
            var localPosition = rectTransform.localPosition
                + rectTransform.localRotation * Vector3.Scale(offset, rectTransform.localScale);

            rectTransform.pivot = pivot;
            rectTransform.localPosition = localPosition;
        }

        /// <summary>
        /// Sets the pivot x and y components without moving the rectangle in world space.
        /// </summary>
        /// <param name="rectTransform">Target rectTransform.</param>
        /// <param name="x">Value to set.</param>
        /// <param name="y">Value to set.</param>
        public static void SetPivotOnly(this RectTransform rectTransform, float x, float y) => SetPivotOnly(rectTransform, new Vector2(x, y));
    }
}