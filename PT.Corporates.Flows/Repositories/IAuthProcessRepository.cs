using PT.Corporates.Flows.Models;
using System.Collections.Generic;

namespace PT.Corporates.Flows.Repositories
{
	public interface IAuthProcessRepository
	{
		void Save(AuthorizationProcess authorizationProcess);

		void Update(AuthorizationProcess authorizationProcess);

		AuthorizationProcess GetById(int id);
	}
}
