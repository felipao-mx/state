using PT.StateMachine.Core;

namespace PT.Corporates.Flows.Reservations.States
{
	class InConfirmationProcessState : ReservationState
	{
		public InConfirmationProcessState(IStateContext context) : base(context)
		{
		}

		public override void ConfirmReservation()
		{
			var state = new ConfirmedReservationState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo,
			};

			context.ChangeState(state);
		}
	}
}
