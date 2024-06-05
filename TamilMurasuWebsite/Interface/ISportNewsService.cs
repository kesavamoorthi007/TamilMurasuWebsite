using System.Collections.Generic;
using System.Collections;
using System.Data;
using TamilMurasuWebsite.Models;

namespace TamilMurasuWebsite.Interface
{
	public interface ISportNewsService
	{
		DataTable GetSportNews(string id);
		DataTable SportNewsDetails(string id);

	}
}
