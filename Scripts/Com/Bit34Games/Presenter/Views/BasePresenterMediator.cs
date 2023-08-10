using Com.Bit34Games.Director.Mediation;

namespace Com.Bit34Games.Presenter.Views
{
    public abstract class BasePresenterMediator : IMediator
    {
        //  METHODS
        public void OnRegister()
        {
            Initialize();
        }

        public void OnRemove()
        {
            Uninitialize();
        }

        protected abstract void Initialize();
        protected abstract void Uninitialize();
       
    }
}