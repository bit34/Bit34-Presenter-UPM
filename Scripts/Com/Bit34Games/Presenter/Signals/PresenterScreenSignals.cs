using Com.Bit34Games.Director.Signaling;


namespace Com.Bit34Games.Presenter.Signals
{
    public class PresenterScreenSignals
    {
        public class Open  : Signal<string/*screenName*/> { }
        public class Close : Signal { }
    }
}
