using PT.Corporates.Flows.Reservations.States;
using PT.StateMachine.Core;
using PT.StateMachine.Reactive;

namespace PT.Corporates.Flows.Reservations.Contexts
{
	public class ReservationContext : StateContextReactive
	{
		protected ReservationState ReservationState
		{
			get
			{
				return (ReservationState)State;
			}
		}

		public ReservationContext()
		{
			State = new CreatedReservationState(this);
		}

		public ReservationContext(IState state)
		{
			State = state;
		}

		public void RequestReview()
		{
			ReservationState.RequestReview();
		}

		public void Pay()
		{
			ReservationState.Pay();
		}

		public void Approve()
		{
			ReservationState.Approve();
		}

		public void Reject()
		{
			ReservationState.Reject();
		}

		public void Expire()
		{
			ReservationState.Expire();
		}

		public void Cancel()
		{
			ReservationState.Cancel();
		}

		public void RequestConfirmReservation()
		{
			ReservationState.RequestConfirmReservation();
		}

		public void ConfirmReservation()
		{
			ReservationState.ConfirmReservation();
		}
	}
}
