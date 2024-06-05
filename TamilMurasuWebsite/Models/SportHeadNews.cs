using Microsoft.AspNetCore.Mvc.Rendering;

namespace TamilMurasuWebsite.Models
{
	public class SportHeadNews
	{
		public string ID { get; set; }

		public List<SportHead> SportHeadlst;
	}

	public class SportHead
	{
		public string News_head1_s { get; set; }
		public string N_id { get; set; }
		public string News_des_s { get; set; }
		public string News_image_s { get; set; }
		public string News_date_s { get; set; }
	}
}
