using PT.StateMachine.Core;
using System;

namespace PT.Corporates.Flows.Reservations.States
{
	public class InReviewReservationState : ReservationState
	{
		public InReviewReservationState(IStateContext context) : base(context)
		{
			Name = "InReview";
		}

		public override void Approve()
		{
			var state = new ApprovedReservationState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo
			};

			context.ChangeState(state);
		}

		public override void Reject()
		{
			var state = new RejectedReservationState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo
			};

			context.ChangeState(state);
		}

		public override void Expire()
		{
			if (AuthorizationProcess.ExpirationDate > DateTime.Now)
				return;

			var state = new ExpiredReservationState(context)
			{
				AuthorizationProcess = AuthorizationProcess,
				StateInfo = StateInfo
			};

			context.ChangeState(state);
		}
	}
}
