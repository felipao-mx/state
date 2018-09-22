namespace PT.StateMachine.Core
{
	public abstract class StateContextHook : StateContext, IStateContextHook
	{
		public override void ChangeState(IState state)
		{
			OnStateExit();
			OnStateChange(state);
			base.ChangeState(state);
			OnStateEntry();
		}

		public virtual void OnStateChange(IState state)
		{
		}

		public virtual void OnStateEntry()
		{
			if (State is IStateHook stateEventHandler)
			{
				stateEventHandler.OnEntry();
			}
		}

		public virtual void OnStateExit()
		{
			if (State is IStateHook stateEventHandler)
			{
				stateEventHandler.OnExit();
			}
		}
	}
}
