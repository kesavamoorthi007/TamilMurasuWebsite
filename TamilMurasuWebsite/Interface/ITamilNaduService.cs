using System.Collections.Generic;
using System.Collections;
using System.Data;
using TamilMurasuWebsite.Models;

namespace TamilMurasuWebsite.Interface
{
	public interface ITamilNaduService
	{
		DataTable GetTamilNadu();
		DataTable GetTamilNaduDeatils(string id);
	}
}
