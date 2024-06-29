using Microsoft.AspNetCore.Mvc.Rendering;


namespace TamilMurasuWebsite.Models
{
	public class Cinima
	{
		public string ID { get; set; }

		public List<CinimaList> Cinimallst;

		public List<CinimaDeatils> CinimaDeatilslist;
	}
	public class CinimaList
	{
		public string News_head1 { get; set; }
		public string News_des { get; set; }
		public string News_image { get; set; }
		public string News_date { get; set; }
		public string N_id { get; set; }
	}
	public class CinimaDeatils
	{
		public string ID { get; set; }
		public string News_head1_d { get; set; }
		public string News_des_d { get; set; }
		public string News_image_d { get; set; }
		public string News_date_d { get; set; }
		public string N_id_d { get; set; }
	}
}
