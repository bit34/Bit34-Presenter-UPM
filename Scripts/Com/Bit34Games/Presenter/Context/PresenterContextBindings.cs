using Com.Bit34Games.Director.Mediation;
using Com.Bit34Games.Director.Signaling;
using Com.Bit34Games.Injector;
using Com.Bit34Games.Presenter.Models;
using Com.Bit34Games.Presenter.Signals;
using Com.Bit34Games.Presenter.Utilities;

namespace Com.Bit34Games.Presenter.Commands
{
    public static class PresenterContextBindings
    {
        public static void AddBindings(IInjector injector, MediationBinder mediationBinder, SignalCommandBinder signalCommandBinder)
        {
            injector.AddBinding<PresenterModel>()                                       .ToType<PresenterModel>();
            injector.AddBinding<IReadOnlyPresenterModel>()                              .ToType<PresenterModel>();

            injector.AddBinding<PresenterOperations>()                                  .ToType<PresenterOperations>();

            signalCommandBinder.BindSignal<PresenterSignals.ShowScreenAtTop>()          .ToCommand<PresenterCommands.ShowScreenAtTop>();
            signalCommandBinder.BindSignal<PresenterSignals.CloseTopScreen>()           .ToCommand<PresenterCommands.CloseTopScreen>();
        }

        public static void Initialize(IInjector injector, IPresenterSceneManager presenterSceneManager)
        {
            injector.GetInstance<PresenterOperations>().Initialize(presenterSceneManager);
        }
        
    }
}
