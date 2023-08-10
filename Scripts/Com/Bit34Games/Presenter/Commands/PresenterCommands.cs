using Com.Bit34Games.Presenter.Signals;
using Com.Bit34Games.Presenter.Utilities;

namespace Com.Bit34Games.Presenter.Commands
{
    public class PresenterCommands
    {
        public class ShowScreenAtTop : PresenterSignals.ShowScreenAtTop.Command
        {
        //  MEMBERS
#pragma warning disable 0649
        //      Utilities
        [Inject] private PresenterOperations _presenterOperations;
#pragma warning restore 0649

        //  METHODS
            protected override void ExecuteMethod(string screenName)
            {
                _presenterOperations.ShowScreenAtTop(screenName);
            }
        }
        
        
        public class CloseTopScreen : PresenterSignals.CloseTopScreen.Command
        {
        //  MEMBERS
#pragma warning disable 0649
        //      Utilities
        [Inject] private PresenterOperations _presenterOperations;
#pragma warning restore 0649

        //  METHODS
            protected override void ExecuteMethod()
            {
                _presenterOperations.CloseTopScreen();
            }
        }
        
    }
}
