using System.Collections.Generic;
using System.Collections;
using System.Data;
using TamilMurasuWebsite.Models;


namespace TamilMurasuWebsite.Interface
{
	public interface IHomeDeatilsService
	{
		DataTable GetHeadNews();
		DataTable GetHomeDeatils();
		DataTable GetLatestNews();
		DataTable GetNewsFirstLine();
		DataTable GetNewsLine();
        DataTable GetSportLine();
        DataTable GetSportNews();
        DataTable GetIndiaNews();
        DataTable GetWorldNews();
        DataTable GetTopIndiaNews();
        DataTable GetTopCinimaNews();
	}
}
