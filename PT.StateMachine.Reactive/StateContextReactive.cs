using PT.StateMachine.Core;
using PT.StateMachine.Core.Enums;
using System.Reactive.Subjects;

namespace PT.StateMachine.Reactive
{
	public class StateContextReactive : StateContextHook
	{
		public Subject<IState> StateSubject { get; private set; }
		public Subject<StateTransition> TransitionSubject { get; private set; }
		protected IState newState;

		public StateContextReactive()
		{
			StateSubject = new Subject<IState>();
			TransitionSubject = new Subject<StateTransition>();
		}

		public override void OnStateEntry()
		{
			SetCurrentHook(StateHook.OnEntry);
			base.OnStateEntry();
			StateSubject.OnNext(State);
		}

		public override void OnStateExit()
		{
			SetCurrentHook(StateHook.OnExit);
			base.OnStateEntry();
			StateSubject.OnNext(State);
		}

		public override void OnStateChange(IState nextState)
		{
			var transition = new StateTransition
			{
				From = State,
				To = nextState
			};

			TransitionSubject.OnNext(transition);
		}

		private void SetCurrentHook(StateHook hook)
		{
			if (State.StateInfo != null)
			{
				State.StateInfo.StateHook = hook;
			}
			else
			{
				State.StateInfo = new StateInfo
				{
					StateHook = hook
				};
			}
		}
	}
}
