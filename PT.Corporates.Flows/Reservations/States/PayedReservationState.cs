using PT.StateMachine.Core;

namespace PT.Corporates.Flows.Reservations.States
{
	public class PayedReservationState : ReservationState
	{
		public PayedReservationState(IStateContext context) : base(context)
		{
		}

		public override void RequestConfirmReservation()
		{
			var state = new InConfirmationProcessState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo
			};

			context.ChangeState(state);
		}
	}
}
