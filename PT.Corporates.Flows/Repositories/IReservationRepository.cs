using PT.Corporates.Flows.Models;

namespace PT.Corporates.Flows.Repositories
{
	public interface IReservationRepository
	{
		void Save(Reservation reservation);

		Reservation GetById(int id);

		Reservation GetByMasterLocatorId(int masterLocatorId);
	}
}
