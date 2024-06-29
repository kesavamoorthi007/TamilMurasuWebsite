using System.Data;
using System.Collections.Generic;
using System.Collections;
using TamilMurasuWebsite.Models;

namespace TamilMurasuWebsite.Interface
{
	public interface IWorldNewsService
	{
		DataTable GetWorldNews();
		DataTable GetWorldNewsService(string id);
	}
}
