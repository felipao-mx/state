using PT.StateMachine.Core;

namespace PT.Corporates.Flows.Reservations.States
{
	public class RejectedReservationState : ReservationState
	{
		public RejectedReservationState(IStateContext context) : base(context)
		{
		}

		public override void Cancel()
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
