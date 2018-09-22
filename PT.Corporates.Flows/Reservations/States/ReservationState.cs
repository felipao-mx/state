using PT.Corporates.Flows.Models;
using PT.StateMachine.Core;

namespace PT.Corporates.Flows.Reservations.States
{
	public abstract class ReservationState : State
	{
		public AuthorizationProcess AuthorizationProcess { get; set; }

		protected ReservationState(IStateContext context) : base(context)
		{
		}

		public virtual void RequestReview()
		{
		}

		public virtual void Pay()
		{
		}

		public virtual void Approve()
		{
		}

		public virtual void Reject()
		{
		}

		public virtual void Expire()
		{
		}

		public virtual void Cancel()
		{
		}

		public virtual void RequestConfirmReservation()
		{
		}

		public virtual void ConfirmReservation()
		{
		}
	}
}
