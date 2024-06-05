using Microsoft.AspNetCore.Mvc.Rendering;

namespace TamilMurasuWebsite.Models
{
	public class HomeDeatils
	{
		public string ID { get; set; }
		public string News_head1 { get; set; }
		public string News_des { get; set; }
		public string News_image { get; set; }
		public string News_date { get; set; }
		public string NT_head { get; set; }
		public string NT_date { get; set; }
		public string News_head1_s { get; set; }
		public string News_des_s { get; set; }
		public string News_image_s { get; set; }
		public string News_date_s { get; set; }

		public List<LatestNews> Latestlst;
		public List<Latestsports> Latestslst;
		public List<NewsFirst> NewsFirstlst;
	}
	public class LatestNews
	{
		public string ID { get; set; }
		public string NT_head { get; set; }
	}
	public class Latestsports
	{
		public string News_head1_s { get; set; }
		public string N_id { get; set; }
		public string News_des_s { get; set; }
		public string News_image_s { get; set; }
		public string News_date_s { get; set; }
	}
	public class NewsFirst
	{
		public string News_head1_N { get; set; }
		public string News_des_N { get; set; }
		public string News_image_N { get; set; }
		public string News_date_N { get; set; }
		public string N_id { get; set; }

	}
}
