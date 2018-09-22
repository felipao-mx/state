using PT.Corporates.Flows.Models.Enums;
using PT.StateMachine.Core;

namespace PT.Corporates.Flows.Reservations.States
{
	public class CreatedReservationState : ReservationState
	{
		public CreatedReservationState(IStateContext context) : base(context)
		{
			Name = "Created Reservation";
		}

		public override void RequestReview()
		{
			var state = new InReviewReservationState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo
			};

			context.ChangeState(state);
		}

		public override void Pay()
		{
			if (AuthorizationProcess.AuthFlowType != AuthFlowType.None)
				return;

			var state = new PayedReservationState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo
			};

			context.ChangeState(state);
		}
	}
}
