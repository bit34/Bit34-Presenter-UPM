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

        public void ShowScreenAtTop(string screenName)
        {
            ScreenTransitionVO previousCloseTransition = null;
            if (_presenterModel.ScreenCount>0)
            {
                previousCloseTransition = _sceneManager.CloseScreen(screenName);
            }
            _presenterModel.AddScreen(screenName);
            _sceneManager.ShowScreen(previousCloseTransition, screenName);
        }

        public void CloseTopScreen()
        {
            _presenterModel.RemoveScreen();

            if (_presenterModel.ScreenCount>0)
            {
                ScreenTransitionVO previousCloseTransition = _sceneManager.CloseScreen(_presenterModel.TopScreenName);
                _sceneManager.ShowScreen(previousCloseTransition, _presenterModel.TopScreenName);
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
        
    }
}
