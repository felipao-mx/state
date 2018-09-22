using PT.StateMachine.Core;

namespace PT.Corporates.Flows.Reservations.States
{
	public class CanceledReservationState : ReservationState
	{
		public CanceledReservationState(IStateContext context) : base(context)
		{
		}
	}
}
