using UnityEngine;


namespace Com.Bit34Games.Presenter.Unity
{
    public class PopupBlocker : MonoBehaviour
    {
        //  METHODS
        virtual public void Show()
        {
            gameObject.SetActive(true);
        }

        virtual public void Hide()
        {
            gameObject.SetActive(false);
        }
        
        private void Awake()
        {
            gameObject.SetActive(false);
        }
    }
}