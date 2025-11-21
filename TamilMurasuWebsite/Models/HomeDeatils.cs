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
		public string News_head1_sport { get; set; }
		public string NT_Head_i { get; set; }
		public string NT_Head_c { get; set; }
		public string N_Description_i { get; set; }
		public string N_Description_c { get; set; }
		public string S_Image_i { get; set; }
		public string S_Image_c { get; set; }
		public string L_Image_i { get; set; }
		public string L_Image_c { get; set; }
		public string date_i { get; set; }
		public string date_c { get; set; }
		public string N_id { get; set; }



		public List<LatestNews> Latestlst;
		public List<Latestsports> Latestslst;
		public List<NewsFirst> NewsFirstlst;
		public List<IndiaNewsList> IndiaNewsListlst;
		public List<WorldNewsList> WorldNewsListlst;
		public List<HeadNews> HeadNewslist;
		public List<NewsLine> NewsLinelist;
		public List<SportsNews> SportsNewslist;
		public List<TopIndiaNews> TopIndiaNewslist;
		public List<TopCinimaNews> TopCinimaNewslist;
	}
	public class TopCinimaNews
	{
        public string N_id { get; set; }
        public string NT_Head_c { get; set; }
        public string N_Description_c { get; set; }
        public string S_Image_c { get; set; }
        public string L_Image_c { get; set; }
        public string date_c { get; set; }
    }

    public class TopIndiaNews
	{
        public string NT_Head_i { get; set; }
        public string N_Description_i { get; set; }
        public string S_Image_i { get; set; }
        public string L_Image_i { get; set; }
        public string date_i { get; set; }
        public string N_id { get; set; }
    }

    public class SportsNews
	{
        public string ID { get; set; }
        public string News_head1_sport { get; set; }
        public string News_des { get; set; }
        public string News_image { get; set; }
        public string News_Limage { get; set; }
        public string News_date { get; set; }
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
	public class IndiaNewsList
	{
		public string NT_Head_i { get; set; }
		public string N_Description_i { get; set; }
		public string S_Image_i { get; set; }
		public string L_Image_i { get; set; }
		public string date_i { get; set; }
		public string N_id { get; set; }
	}
	public class WorldNewsList
	{
		public string NT_Head_w { get; set; }
		public string N_Description_w { get; set; }
		public string S_Image_w { get; set; }
		public string L_Image_w { get; set; }
		public string date_w { get; set; }
		public string N_id { get; set; }
	}
	public class HeadNews
	{
        public string NT_head { get; set; }
        public string NT_date { get; set; }
        public string NT_Image { get; set; }
        public string ID { get; set; }
    }
	public class NewsLine
	{
        public string News_head1 { get; set; }
        public string News_des { get; set; }
        public string News_image { get; set; }
        public string News_date { get; set; }
        public string ID { get; set; }
    }
}
