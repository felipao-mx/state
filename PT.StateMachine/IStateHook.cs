namespace PT.StateMachine.Core
{
	public interface IStateHook
	{
		void OnEntry();
		void OnExit();
	}
}
