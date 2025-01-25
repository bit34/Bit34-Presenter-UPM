using Com.Bit34Games.Presenter.Signals;
using Com.Bit34Games.Presenter.Utilities;


namespace Com.Bit34Games.Presenter.Commands
{
    public class CloseScreenCommand : PresenterScreenSignals.Close.Command
    {
        //  MEMBERS
        //      Utilities
        [Inject] private PresenterOperations _presenterOperations;


        //  METHODS
        protected override void ExecuteMethod()
        {
            _presenterOperations.CloseScreen();
        }
    }
}
