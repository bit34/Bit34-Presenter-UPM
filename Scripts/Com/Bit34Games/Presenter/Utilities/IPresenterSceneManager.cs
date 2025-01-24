using Com.Bit34Games.Presenter.VOs;

namespace Com.Bit34Games.Presenter.Utilities
{
    public interface IPresenterSceneManager
    {
        //  METHODS
        ScreenTransitionVO ShowScreen(ScreenTransitionVO previousCloseTransition, string newScreenName);
        ScreenTransitionVO CloseScreen(string nextScreenName);
        void CreateOverlay(string overlayName);
    }
}
