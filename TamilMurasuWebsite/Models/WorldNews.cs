using Microsoft.AspNetCore.Mvc.Rendering;

namespace TamilMurasuWebsite.Models
{
	public class WorldNews
	{
		public List<World> Worldlst;

		public List<WorldDeatils> WorldDeatilslist;
	}
	public class World
	{
		public string News_head1 { get; set; }
		public string News_des { get; set; }
		public string News_image { get; set; }
		public string L_News_image { get; set; }
		public string News_date { get; set; }
		public string N_id { get; set; }
	}
	public class WorldDeatils
	{
		public string News_head1_d { get; set; }
		public string News_des_d { get; set; }
		public string News_image_d { get; set; }
		public string L_News_image { get; set; }
		public string News_date_d { get; set; }
		public string N_id_d { get; set; }
	}
}
