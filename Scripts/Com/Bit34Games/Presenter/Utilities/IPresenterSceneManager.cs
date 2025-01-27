using Com.Bit34Games.Presenter.VOs;


namespace Com.Bit34Games.Presenter.Utilities
{
    public interface IPresenterSceneManager
    {
        //  METHODS
        ScreenTransitionVO OpenScreen(ScreenTransitionVO previousCloseTransition, string newScreenName);
        ScreenTransitionVO CloseScreen(string nextScreenName);
        
        void CreateOverlay(string overlayName);

        void ShowPopupBlocker();
        void HidePopupBlocker();
        void OpenPopup(string popupName);
        void ClosePopup();
        void HidePopup();
        void RevealPopup();
    }
}
