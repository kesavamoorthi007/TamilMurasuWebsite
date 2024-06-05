using Microsoft.AspNetCore.Mvc.Rendering;

namespace TamilMurasuWebsite.Models
{
	public class News
	{
		public string ID { get; set; }

		public List<NewsHead> NewsHeadlst;
	}
	public class NewsHead
	{
		public string News_head1_N { get; set; }
		public string News_des_N { get; set; }
		public string News_image_N { get; set; }
		public string News_date_N { get; set; }
		public string N_id { get; set; }
	}
}
