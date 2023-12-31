using Com.Bit34Games.Presenter.Models;

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
            _presenterModel.AddScreen(screenName);
            _sceneManager.CreateScreen(screenName);
        }

        public void CloseTopScreen()
        {
            _presenterModel.RemoveScreen();
            if (_presenterModel.ScreenCount>0)
            {
                _sceneManager.CreateScreen(_presenterModel.TopScreenName);
            }
        }

        public void CreateOverlay(string overlayName)
        {
            _sceneManager.CreateOverlay(overlayName);
        }
        
    }
}
