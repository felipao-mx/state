namespace PT.StateMachine.Core
{
	public class StateTransition
	{
		public IState From { get; set; }
		public IState To { get; set; }
	}
}
