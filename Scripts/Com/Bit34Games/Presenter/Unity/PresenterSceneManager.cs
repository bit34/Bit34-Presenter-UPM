using System.Collections.Generic;
using Com.Bit34Games.Presenter.Utilities;
using UnityEngine;

namespace Com.Bit34Games.Presenter.Unity
{
    public class PresenterSceneManager : MonoBehaviour,
                                         IPresenterSceneManager
    {
        //  MEMBERS
#pragma warning disable 0649
        //      For Editor
        [SerializeField] private Canvas        _canvas;
        [SerializeField] private RectTransform _container;
        [SerializeField] private RectTransform _screenContainer;
        [SerializeField] private RectTransform _overlayContainer;
#pragma warning restore 0649
        //      Private
        private Dictionary<string, GameObject> _screenPrefabs;
        private GameObject                     _screen;
        private Dictionary<string, GameObject> _overlayPrefabs;
        private List<GameObject>               _overlays;

        //  METHODS
        public void AddScreenPrefab(string name, GameObject prefab)
        {
            _screenPrefabs.Add(name, prefab);
        }
        
        public void AddOverlayPrefab(string name, GameObject prefab)
        {
            _overlayPrefabs.Add(name, prefab);
        }

#region IPresenterSceneManager implementations
    
        public void CreateScreen(string screenName)
        {
            if (_screen != null)
            {
                Destroy(_screen);
            }

            _screen = Instantiate(_screenPrefabs[screenName], _screenContainer);
            _screen.name = screenName;
        }

        public void CreateOverlay(string overlayName)
        {
            GameObject overlayObject = Instantiate(_overlayPrefabs[overlayName], _overlayContainer);
            overlayObject.name = overlayName;
            _overlays.Add(overlayObject);
        }

#endregion

        private void Awake()
        {
            _screenPrefabs  = new Dictionary<string, GameObject>();
            _overlayPrefabs = new Dictionary<string, GameObject>();
            _overlays       = new List<GameObject>();
        }
    }
}
