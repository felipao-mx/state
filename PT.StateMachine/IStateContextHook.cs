namespace PT.StateMachine.Core
{
	public interface IStateContextHook
	{
		void OnStateEntry();

		void OnStateExit();

		void OnStateChange(IState state);
	}
}
