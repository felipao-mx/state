namespace PT.StateMachine.Core
{
	public interface IState
	{
		string Name { get; set; }

		StateInfo StateInfo { get; set; }
	}
}
