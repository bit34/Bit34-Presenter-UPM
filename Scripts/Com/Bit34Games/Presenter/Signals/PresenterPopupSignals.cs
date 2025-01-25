using Com.Bit34Games.Director.Signaling;


namespace Com.Bit34Games.Presenter.Signals
{
    public class PresenterPopupSignals
    {
        public class Open  : Signal<string/*popupName*/> { }
        public class Close : Signal { }
    }
}
