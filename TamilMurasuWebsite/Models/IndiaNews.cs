using Microsoft.AspNetCore.Mvc.Rendering;

namespace TamilMurasuWebsite.Models
{
	public class IndiaNews
	{
		public string ID { get; set; }

		public List<India> Indialst;

		public List<IndiaNewsDeatils> IndiaNewsDeatilslist;
	}
	public class India
	{
		public string News_head1 { get; set; }
		public string News_des { get; set; }
		public string News_image { get; set; }
		public string News_date { get; set; }
		public string L_News_image { get; set; }
		public string N_id { get; set; }
	}
	public class IndiaNewsDeatils
	{
		public string News_head1_d { get; set; }
		public string News_des_d { get; set; }
		public string News_image_d { get; set; }
		public string News_date_d { get; set; }
		public string L_News_image { get; set; }
		public string N_id_d { get; set; }
	}
}
