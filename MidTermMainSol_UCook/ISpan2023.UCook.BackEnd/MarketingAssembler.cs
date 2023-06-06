using ISpan2023.UCook.BackEnd.Dtos;
using Ado.Net.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd
{
	public class MarketingAssembler
	{

		public static Func<SqlDataReader, MarketingDto> MarketingDtoAssembler
		{
			get
			{
				Func<SqlDataReader, MarketingDto> func = (reader) =>
				{
					string campaignPK = reader.GetString("CAMPAIGN活動_PK");
					int spacePK = reader.GetInt("AD_SPACE廣告版面_PK");
					DateTime startDate = reader.GetDateTime("START_TIME開始時間");
					DateTime endDate = reader.GetDateTime("END_TIME結束時間");
					string campaignName = reader.GetString("CAMPAIGN_NAME活動名稱");
					string url = reader.GetString("URL連結");
					int impression = reader.GetInt("Impression曝光數");
					int click = reader.GetInt("Click點擊數");
					int ctr = reader.GetInt("CTR點擊率");

					return new MarketingDto
					{
						CAMPAIGN活動_PK = campaignPK,
						AD_SPACE廣告版面_PK = spacePK,
						START_TIME開始時間 = startDate,
						END_TIME結束時間 = endDate,
						CAMPAIGN_NAME活動名稱 = campaignName,
						URL連結 = url,
						Impression曝光數 = impression,
						Click點擊數 = click,
						CTR點擊率 = ctr,
					};
				};

				return func;
			}

		}

		public static Func<SqlDataReader, MarketingDetailDto> MarketingDetailDtoAssembler
		{
			get
			{
				Func<SqlDataReader, MarketingDetailDto> func = (reader) =>
				{
					int spacePK = reader.GetInt("AD_SPACE廣告版面_PK");
					string campaignPK = reader.GetString("CAMPAIGN活動_PK");
					string campaignName = reader.GetString("CAMPAIGN_NAME活動名稱");
					string url = reader.GetString("URL連結");
					DateTime startDate = reader.GetDateTime("START_TIME開始時間");
					DateTime endDate = reader.GetDateTime("END_TIME結束時間");
					string photo = reader.GetString("AD_IMG廣告圖");


					return new MarketingDetailDto
					{
						AD_SPACE廣告版面_PK = spacePK,
						CAMPAIGN活動_PK = campaignPK,
						CAMPAIGN_NAME活動名稱 = campaignName,
						URL連結 = url,
						START_TIME開始時間 = startDate,
						END_TIME結束時間 = endDate,
						AD_IMG廣告圖 = photo,

					};
				};

				return func;
			}

		}
	}
}
