using PT.StateMachine.Core;

namespace PT.Corporates.Flows.Reservations.States
{
	public class ExpiredReservationState : ReservationState
	{
		public ExpiredReservationState(IStateContext context) : base(context)
		{
		}

		public override void Reject()
		{
			var state = new CanceledReservationState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo
			};

			context.ChangeState(state);
		}
	}
}
