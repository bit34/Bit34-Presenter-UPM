using System.Collections.Generic;
using Com.Bit34Games.Presenter.VOs;

namespace Com.Bit34Games.Presenter.Models
{
    public class PresenterModel : IReadOnlyPresenterModel
    {
        //  MEMBERS
        public int    ScreenCount   { get { return _screens.Count; } }
        public string TopScreenName { get { return _screens.Peek().name; } }
        //      Private
        private Stack<ScreenVO> _screens;

        //  CONSTRUCTORS
        public PresenterModel()
        {
            _screens = new Stack<ScreenVO>();
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
    }
}