using Com.Bit34Games.Presenter.VOs;
using DG.Tweening;

namespace Com.Bit34Games.Presenter.Unity
{
    public class BaseScreenView : BasePresenterView
    {
        //  METHODS
        virtual public ScreenTransitionVO CloseScreen(string nextScreenName)
        {
            Destroy(gameObject);
            return new ScreenTransitionVO(name, 0);
        }

        virtual public ScreenTransitionVO ShowScreen(ScreenTransitionVO previousCloseTransition)
        {
            float duration = 0;
            if (previousCloseTransition.duration > 0)
            {
                duration = previousCloseTransition.duration;
                gameObject.SetActive(false);
                DOVirtual.DelayedCall(duration, ()=>{gameObject.SetActive(true);});
            }
            return new ScreenTransitionVO(name, duration);
        }

    }
}