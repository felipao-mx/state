using PT.StateMachine.Core;

namespace PT.Corporates.Flows.Reservations.States
{
	public class ApprovedReservationState : ReservationState
	{
		public ApprovedReservationState(IStateContext context) : base(context)
		{
		}

		public override void Pay()
		{
			var state = new PayedReservationState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo
			};

			context.ChangeState(state);
		}
	}
}
