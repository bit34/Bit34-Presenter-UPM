namespace Com.Bit34Games.Presenter.Unity
{
    public class PopupView : PresenterView
    {
        //  METHODS
        virtual public void Open()
        {
            gameObject.SetActive(true);
        }

        virtual public void Close()
        {
            Destroy(gameObject);
        }

        virtual public void Reveal()
        {
            gameObject.SetActive(true);
        }

        virtual public void Hide()
        {
            Destroy(gameObject);
        }
    }
}