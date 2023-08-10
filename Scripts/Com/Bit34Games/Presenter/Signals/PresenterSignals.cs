using Com.Bit34Games.Director.Signaling;

namespace Com.Bit34Games.Presenter.Signals
{
    public class PresenterSignals
    {
        public class ShowScreenAtTop : Signal<string/*screenName*/> { }
        public class CloseTopScreen  : Signal { }
    }
}
