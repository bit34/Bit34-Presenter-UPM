using Com.Bit34Games.Presenter.VOs;
using DG.Tweening;


namespace Com.Bit34Games.Presenter.Unity
{
    public class ScreenView : PresenterView
    {
        //  MEMBERS
        public bool IsInteractable { get { return !_isInTransition; } }
        //      Private
        protected bool _isInTransition;


        //  METHODS
        virtual public ScreenTransitionVO CloseScreen(string nextScreenName)
        {
            Destroy(gameObject);
            _isInTransition = false;
            return new ScreenTransitionVO(name, 0);
        }

        virtual public ScreenTransitionVO ShowScreen(ScreenTransitionVO previousCloseTransition)
        {
            float duration = 0;
            if (previousCloseTransition != null && previousCloseTransition.duration > 0)
            {
                _isInTransition = true;
                duration        = previousCloseTransition.duration;
                gameObject.SetActive(false);
                DOVirtual.DelayedCall(duration, ()=>
                {
                    _isInTransition = false;
                    gameObject.SetActive(true);
                });
            }
            else
            {
                _isInTransition = false;
            }
            return new ScreenTransitionVO(name, duration);
        }

    }
}
