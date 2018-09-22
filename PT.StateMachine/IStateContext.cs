namespace PT.StateMachine.Core
{
	public interface IStateContext
	{
		IState State { get; set; }
		void ChangeState(IState state);
	}
}
