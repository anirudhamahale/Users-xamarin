using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UserXamarin.Models;

namespace UserXamarin.services
{
	public interface IUserService
	{
		Task<Root> getUsers(int page);
	}
}

