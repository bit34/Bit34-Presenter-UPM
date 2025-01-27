using Com.Bit34Games.Presenter.Models;
using Com.Bit34Games.Presenter.VOs;


namespace Com.Bit34Games.Presenter.Utilities
{
    public class PresenterOperations
    {
        //  MEMBERS
#pragma warning disable 0649
        //      Models
        [Inject] private PresenterModel _presenterModel;
#pragma warning restore 0649
        //      Private
        private IPresenterSceneManager _sceneManager;


        //  METHODS
        public void Initialize(IPresenterSceneManager sceneManager)
        {
            if (_sceneManager == null)
            {
                _sceneManager = sceneManager;
            }
        }

        public void OpenScreen(string screenName)
        {
            ScreenTransitionVO previousCloseTransition = null;
            if (_presenterModel.ScreenCount > 0)
            {
                previousCloseTransition = _sceneManager.CloseScreen(screenName);
            }
            _presenterModel.AddScreen(screenName);
            _sceneManager.OpenScreen(previousCloseTransition, screenName);
        }

        public void CloseScreen()
        {
            _presenterModel.RemoveScreen();

            if (_presenterModel.ScreenCount > 0)
            {
                ScreenTransitionVO previousCloseTransition = _sceneManager.CloseScreen(_presenterModel.TopScreenName);
                _sceneManager.OpenScreen(previousCloseTransition, _presenterModel.TopScreenName);
            }
            else
            {
                _sceneManager.CloseScreen("");
            }
        }

        public void CreateOverlay(string overlayName)
        {
            _sceneManager.CreateOverlay(overlayName);
        }

        public void OpenPopup(string popupName)
        {
            if (_presenterModel.PopupCount == 0)
            {
                _sceneManager.ShowPopupBlocker();
            }
            else
            {
                _sceneManager.HidePopup();
            }

            _presenterModel.AddPopup(popupName);
            _sceneManager.OpenPopup(popupName);
        }

        public void ClosePopup()
        {
            _presenterModel.RemovePopup();
            _sceneManager.ClosePopup();

            if (_presenterModel.PopupCount == 0)
            {
                _sceneManager.HidePopupBlocker();
            }
            else
            {
                _sceneManager.RevealPopup();
            }

        }

    }
}
