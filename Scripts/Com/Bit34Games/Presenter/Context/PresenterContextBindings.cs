using Com.Bit34Games.Director.Mediation;
using Com.Bit34Games.Director.Signaling;
using Com.Bit34Games.Injector;
using Com.Bit34Games.Presenter.Commands;
using Com.Bit34Games.Presenter.Models;
using Com.Bit34Games.Presenter.Signals;
using Com.Bit34Games.Presenter.Utilities;


namespace Com.Bit34Games.Presenter.Context
{
    public static class PresenterContextBindings
    {
        public static void AddBindings(IInjector injector, MediationBinder mediationBinder, SignalCommandBinder signalCommandBinder)
        {
            injector.AddBinding<PresenterModel>()                           .ToType<PresenterModel>();
            injector.AddBinding<IReadOnlyPresenterModel>()                  .ToType<PresenterModel>();

            injector.AddBinding<PresenterOperations>()                      .ToType<PresenterOperations>();

            signalCommandBinder.BindSignal<PresenterScreenSignals.Open>()   .ToCommand<OpenScreenCommand>();
            signalCommandBinder.BindSignal<PresenterScreenSignals.Close>()  .ToCommand<CloseScreenCommand>();
            signalCommandBinder.BindSignal<PresenterPopupSignals.Open>()    .ToCommand<OpenPopupCommand>();
            signalCommandBinder.BindSignal<PresenterPopupSignals.Close>()   .ToCommand<ClosePopupCommand>();
        }

        public static void Initialize(IInjector injector, IPresenterSceneManager presenterSceneManager)
        {
            injector.GetInstance<PresenterOperations>().Initialize(presenterSceneManager);
        }
        
    }
}
