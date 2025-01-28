using UnityEngine;


namespace Com.Bit34Games.Presenter.Unity
{
    public class SafeAreaAdjuster : MonoBehaviour
    {
        private void Awake()
        {
            Rect          safeArea           = Screen.safeArea;
            RectTransform containerTransform = (RectTransform)transform;
            containerTransform.anchorMin = new Vector2(safeArea.xMin / Screen.width, safeArea.yMin / Screen.height);
            containerTransform.anchorMax = new Vector2(safeArea.xMax / Screen.width, safeArea.yMax / Screen.height);
        }
    }
}
