using System.Collections.Generic;
using System.Collections;
using System.Data;
using TamilMurasuWebsite.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace TamilMurasuWebsite.Interface
{
	public interface IIndiaNewsService
	{
		DataTable GetIndiaNews();
		DataTable GetIndiaNewsDeatils(string id);
	}
}
