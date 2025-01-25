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
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        virtual public void Hide()
        {
            gameObject.SetActive(false);
        }

        virtual public void Reveal()
        {
            gameObject.SetActive(true);
        }
    }
}