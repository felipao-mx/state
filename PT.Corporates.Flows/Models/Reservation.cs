namespace PT.Corporates.Flows.Models
{
	public class Reservation
	{
		public int Id { get; set; }
		public int MasterLocatorId { get; set; }
		public int CorporateId { get; set; }
		public int TravelerId { get; set; }
		public int ArrangerId { get; set; }
		public int DtCreated { get; set; }
		public int DtExpiration { get; set; }

		public AuthorizationProcess AuthorizationProcess { get; set; }
	}
}
