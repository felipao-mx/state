using System;
using System.Collections.Generic;
using System.Text;

namespace PT.Corporates.Flows.Models
{
	public class Expense
	{
		public int Id { get; set; }
		public int CorporateId { get; set; }
		public int TravelerId { get; set; }
	}
}
