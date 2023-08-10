using System.Collections.Generic;
using Com.Bit34Games.Presenter.VOs;

namespace Com.Bit34Games.Presenter.Models
{
    public interface IReadOnlyPresenterModel
    {
        //  MEMBERS
        int    ScreenCount   { get; }
        string TopScreenName { get; }

        //  METHODS
    }
}