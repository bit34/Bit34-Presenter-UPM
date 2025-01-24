using Com.Bit34Games.Presenter.Signals;
using Com.Bit34Games.Presenter.Utilities;


namespace Com.Bit34Games.Presenter.Commands
{
    public class CloseTopScreenCommand : PresenterSignals.CloseTopScreen.Command
    {
        //  MEMBERS
        //      Utilities
        [Inject] private PresenterOperations _presenterOperations;


        //  METHODS
        protected override void ExecuteMethod()
        {
            _presenterOperations.CloseTopScreen();
        }
    }
}
