using System.Collections.Generic;
using Com.Bit34Games.Presenter.VOs;


namespace Com.Bit34Games.Presenter.Models
{
    public class PresenterModel : IReadOnlyPresenterModel
    {
        //  MEMBERS
        public int    ScreenCount   { get { return _screens.Count; } }
        public string TopScreenName { get { return _screens.Peek().name; } }
        public int    PopupCount    { get { return _popups.Count; } }
        //      Private
        private Stack<ScreenVO> _screens;
        private Stack<PopupVO>  _popups;


        //  CONSTRUCTORS
        public PresenterModel()
        {
            _screens = new Stack<ScreenVO>();
            _popups  = new Stack<PopupVO>();
        }

        public void AddScreen(string name)
        {
            ScreenVO screen = new ScreenVO(name);
            _screens.Push(screen);
        }

        public string RemoveScreen()
        {
            return _screens.Pop().name;
        }
        
        public void AddPopup(string name)
        {
            PopupVO popup = new PopupVO(name);
            _popups.Push(popup);
        }

        public string RemovePopup()
        {
            return _popups.Pop().name;
        }
    }
}