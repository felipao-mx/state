using PT.Corporates.Flows.Models.Enums;
using System;

namespace PT.Corporates.Flows.Models
{
	public class AuthorizationProcess
	{
		public int Id { get; set; }
		public int MasterLocatorId { get; set; }
		public int CorporateId { get; set; }
		public int TravelerId { get; set; }
		public int ArrangerTravelerId { get; set; }
		public DateTime RequestDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public AuthFlowType AuthFlowType { get; set; }
	}
}
