using Com.Bit34Games.Presenter.Constants;


namespace Com.Bit34Games.Presenter.Utilities
{
    public interface IPresenterSceneAsset
    {
        //  MEMBERS
        PresenterViews View { get; }
        string         Name { get; }
    }
}
