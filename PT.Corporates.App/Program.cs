using PT.Corporates.Flows.Models;
using PT.Corporates.Flows.Models.Enums;
using PT.Corporates.Flows.Reservations.Contexts;
using PT.Corporates.Flows.Reservations.States;
using PT.StateMachine.Core.Enums;
using System;
using System.Reactive.Linq;

namespace PT.Corporates.App
{
	class Program
	{
		static void Main(string[] args)
		{
			var reservationContext = new ReservationContext();
			var state = (ReservationState)reservationContext.State;

			state.AuthorizationProcess = new AuthorizationProcess
			{
				Id = 10000,
				MasterLocatorId = 393875,
				AuthFlowType = AuthFlowType.ByCorporate
			};

			reservationContext.StateSubject.Subscribe(rs =>
			{
				Console.WriteLine("OnNext: " + rs.Name);
			},
			ex => Console.WriteLine("OnError: " + ex),
			() => Console.WriteLine("OnComplete"));

			reservationContext.StateSubject
				.Where(rs => rs.StateInfo != null && rs.StateInfo.StateHook == StateHook.OnEntry)
				.Subscribe(rs =>
				{
					Console.WriteLine("OnNext: " + rs.Name);
					Console.WriteLine("OnNext Hook: " + rs.StateInfo.StateHook);
				},
				ex => Console.WriteLine("OnError: " + ex),
				() => Console.WriteLine("OnComplete"));

			reservationContext.StateSubject
				.Where(rs => rs.StateInfo != null && rs.StateInfo.StateHook == StateHook.OnExit)
				.Subscribe(rs =>
				{
					Console.WriteLine("OnNext: " + rs.Name);
					Console.WriteLine("OnNext Hook: " + rs.StateInfo.StateHook);
				},
				ex => Console.WriteLine("OnError: " + ex),
				() => Console.WriteLine("OnComplete"));

			reservationContext.TransitionSubject.Subscribe(st =>
			{
				Console.WriteLine("current: {0}, new: {1}", st.From, st.To);
			});

			reservationContext.RequestReview();
			reservationContext.Approve();
			reservationContext.Approve();
			reservationContext.Cancel();
			reservationContext.Pay();
			//reservationContext.EmitTicket();
			Console.ReadKey();
		}
	}
}
