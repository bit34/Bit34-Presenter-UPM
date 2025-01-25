namespace Com.Bit34Games.Presenter.Models
{
    public interface IReadOnlyPresenterModel
    {
        //  MEMBERS
        int    ScreenCount   { get; }
        string TopScreenName { get; }
        int    PopupCount    { get; }
    }
}