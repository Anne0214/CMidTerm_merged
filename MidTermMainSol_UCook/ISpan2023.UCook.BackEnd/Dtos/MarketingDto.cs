using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd.Dtos
{
	public class MarketingDto
	{
		public string CAMPAIGN活動_PK { get; set; }  //C1XXXXX 查詢頁隱藏
		public int AD_SPACE廣告版面_PK { get; set; } //板面1~7 
		public DateTime START_TIME開始時間 { get; set; }
		public DateTime END_TIME結束時間 { get; set; }
		public string CAMPAIGN_NAME活動名稱 { get; set; }

		public string URL連結 { get; set; }

		public int Impression曝光數 { get; set; }

		public int Click點擊數 { get; set; }

		public int CTR點擊率 { get; set; }

	}
}
