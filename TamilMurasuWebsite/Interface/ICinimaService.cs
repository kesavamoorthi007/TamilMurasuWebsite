using System.Collections.Generic;
using System.Collections;
using System.Data;
using TamilMurasuWebsite.Models;


namespace TamilMurasuWebsite.Interface
{
	public interface ICinimaService
	{
		DataTable GetCinima();
		DataTable GetCinimaDeatils(string id);
	}
}
