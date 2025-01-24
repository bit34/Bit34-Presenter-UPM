namespace Com.Bit34Games.Presenter.VOs
{
    public class ScreenTransitionVO
    {
        //  MEMBERS
        public readonly string name;
        public readonly float duration;


        //  CONSTRUCTORS
        public ScreenTransitionVO(string name, float duration)
        {
            this.name     = name;
            this.duration = duration;
        }

    }
}