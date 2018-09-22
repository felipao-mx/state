namespace PT.StateMachine.Core
{
	public abstract class State : IState
	{
		public string Name { get; set; }

		public StateInfo StateInfo { get; set; }

		protected IStateContext context;

		protected State(IStateContext context)
		{
			this.context = context;
		}

		public override string ToString()
		{
			return Name ?? GetType().Name;
		}
	}
}
