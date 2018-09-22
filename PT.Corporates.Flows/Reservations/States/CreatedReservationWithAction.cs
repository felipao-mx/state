using PT.StateMachine.Core;
using System;

namespace PT.Corporates.Flows.Reservations.States
{
	public class CreatedReservationWithAction : ReservationState, IStateHook
	{
		protected CreatedReservationWithAction(IStateContext context) : base(context)
		{
		}

		public void OnEntry()
		{
			throw new NotImplementedException();
		}

		public void OnExit()
		{
			throw new NotImplementedException();
		}
	}
}
