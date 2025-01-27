using System.Collections.Generic;
using Com.Bit34Games.Presenter.Utilities;
using Com.Bit34Games.Presenter.VOs;
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
        [SerializeField] private PopupBlocker  _popupBlocker;
        [SerializeField] private RectTransform _popupContainer;
#pragma warning restore 0649
        //      Private
        private Dictionary<string, GameObject> _screenPrefabs;
        private ScreenView                     _screen;
        private Dictionary<string, GameObject> _overlayPrefabs;
        private List<OverlayView>               _overlays;
        private Dictionary<string, GameObject> _popupPrefabs;
        private Stack<PopupView>               _popups;


        //  METHODS
        public void AddScreenPrefab(string name, GameObject prefab)
        {
            _screenPrefabs.Add(name, prefab);
        }
        
        public void AddOverlayPrefab(string name, GameObject prefab)
        {
            _overlayPrefabs.Add(name, prefab);
        }
        
        public void AddPopupPrefab(string name, GameObject prefab)
        {
            _popupPrefabs.Add(name, prefab);
        }

#region IPresenterSceneManager implementations

        public ScreenTransitionVO OpenScreen(ScreenTransitionVO previousCloseTransition, string newScreenName)
        {
            GameObject screenGO = Instantiate(_screenPrefabs[newScreenName], _screenContainer);
            _screen = screenGO.GetComponent<ScreenView>();
            _screen.name = newScreenName;
            return _screen.ShowScreen(previousCloseTransition);
        }

        public ScreenTransitionVO CloseScreen(string nextScreenName)
        {
            ScreenTransitionVO previousCloseTransition = _screen.CloseScreen(nextScreenName);
            _screen = null;
            return previousCloseTransition;
        }

        public void CreateOverlay(string overlayName)
        {
            GameObject  overlayGO = Instantiate(_overlayPrefabs[overlayName], _overlayContainer);
            OverlayView overlay   = overlayGO.GetComponent<OverlayView>();
            overlayGO.name = overlayName;
            _overlays.Add(overlay);
        }

        public void ShowPopupBlocker()
        {
            _popupBlocker.Show();
        }

        public void HidePopupBlocker()
        {
            _popupBlocker.Hide();
        }

        public void OpenPopup(string popupName)
        {
            GameObject popupGO = Instantiate(_popupPrefabs[popupName], _popupContainer);
            PopupView  popup   = popupGO.GetComponent<PopupView>();
            _popups.Push(popup);
            popup.Open();
        }

        public void ClosePopup()
        {
            PopupView popup = _popups.Pop();
            popup.Close();
        }

        public void HidePopup()
        {
            _popups.Peek().Hide();
        }

        public void RevealPopup()
        {
            _popups.Peek().Reveal();
        }

#endregion

        private void Awake()
        {
            _screenPrefabs  = new Dictionary<string, GameObject>();
            _overlayPrefabs = new Dictionary<string, GameObject>();
            _overlays       = new List<OverlayView>();
            _popupPrefabs   = new Dictionary<string, GameObject>();
            _popups         = new Stack<PopupView>();
        }
    }
}
