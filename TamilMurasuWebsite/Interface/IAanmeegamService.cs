using System.Collections.Generic;
using System.Collections;
using System.Data;
using TamilMurasuWebsite.Models;

namespace TamilMurasuWebsite.Interface
{
	public interface IAanmeegamService
	{
		DataTable GetAanmeegamService();
		DataTable GetAanmeegamDeatils(string id);
	}
}
