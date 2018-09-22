namespace PT.StateMachine.Core
{
	public abstract class StateContext : IStateContext
	{
		public IState State { get; set; }

		public virtual void ChangeState(IState state)
		{
			State = state;
		}
	}
}
