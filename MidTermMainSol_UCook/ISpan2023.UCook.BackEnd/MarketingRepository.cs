using ISpan2023.UCook.BackEnd.Dtos;
using Ado.Net.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;




namespace ISpan2023.UCook.BackEnd.Repositories
{
    public class MarketingRepository
    { /// <summary>
      /// 取得一筆商品分類記錄
      /// </summary>
      /// <param name="marketingId">廣告</param>
      /// <returns></returns>
        public (List<MarketingDto>,MarketingDetailDto) GetById (string marketingId)
        {
            string sql = @"SELECT [AD_SPACE廣告版面_PK],[CAMPAIGN活動_PK],[CAMPAIGN_NAME活動名稱],[URL連結]
,[START_TIME開始時間],[END_TIME結束時間],[AD_IMG廣告圖]
FROM CAMPAIGN_廣告活動 
WHERE CAMPAIGN活動_PK = @marketingId ";

            Func<SqlDataReader, MarketingDetailDto> func = MarketingAssembler.MarketingDetailDtoAssembler;
            
            SqlParameter parameter=new SqlParameter("@marketingId", SqlDbType.NVarChar, 20) { Value = marketingId };

            Func<SqlConnection> connGetter = SqlDb.GetConnection;

            var MarketingDetailDto = SqlDb.Get<MarketingDetailDto>(connGetter, sql, func, parameter);
            var MarketingDto = SqlDb.Search<MarketingDto>(connGetter, sql, MarketingAssembler.MarketingDtoAssembler, parameter).ToList();
            return (MarketingDto,MarketingDetailDto);

        }

        public MarketingDetailDto GetByPKId (string _marketingId)
        {
            string sql= @"SELECT [AD_SPACE廣告版面_PK],[CAMPAIGN活動_PK],[CAMPAIGN_NAME活動名稱],[URL連結]
,[START_TIME開始時間],[END_TIME結束時間],[AD_IMG廣告圖]
FROM [CAMPAIGN_廣告活動]
WHERE CAMPAIGN活動_PK = @_marketingId ";
            SqlParameter[] parameters = new SqlParameterBuilder()
                                .AddNVarchar("@_marketingId", 20, _marketingId)
                                .Build();
            Func<SqlDataReader, MarketingDetailDto> func = MarketingAssembler.MarketingDetailDtoAssembler;
            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            return SqlDb.Get<MarketingDetailDto>(connGetter, sql, func, parameters);

        }

        public List<MarketingDto> GetPageData(int _page)
        {
            string sql = @"SELECT [AD_SPACE廣告版面_PK],[CAMPAIGN活動_PK],[CAMPAIGN_NAME活動名稱],[URL連結]
,[START_TIME開始時間],[END_TIME結束時間],[Impression曝光數],[Click點擊數],[CTR點擊率]
FROM [CAMPAIGN_廣告活動]
WHERE [AD_SPACE廣告版面_PK] = @_page ";
            SqlParameter[] parameters = new SqlParameterBuilder()
                                .AddInt("@_page", _page)
                                .Build();
            Func<SqlDataReader, MarketingDto> func = MarketingAssembler.MarketingDtoAssembler;
            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            return SqlDb.Search(connGetter, sql, func, parameters).ToList();

        }


        public List<MarketingDto> Search(int pageId,string marketingName,string marketingId)
        {
            string sql = @"SELECT [CAMPAIGN活動_PK],[AD_SPACE廣告版面_PK],[CAMPAIGN_NAME活動名稱],[URL連結]
,[START_TIME開始時間],[END_TIME結束時間],[Impression曝光數],[Click點擊數],[CTR點擊率] 
FROM CAMPAIGN_廣告活動";

            var builder = new SqlParameterBuilder();

            # region 建立條件式
            string where = string.Empty;

            if (!string.IsNullOrEmpty(marketingName))
            {
                sql += @" WHERE [CAMPAIGN_NAME活動名稱] LIKE '%' + @CAMPAIGN_NAME活動名稱 + '%'";
                builder.AddNVarchar("@CAMPAIGN_NAME活動名稱", 100, marketingName);
            }

            if (!string.IsNullOrEmpty(marketingId))
            {
                sql += @" WHERE [CAMPAIGN活動_PK] LIKE '%' + @CAMPAIGN活動_PK + '%'";
                builder.AddNVarchar("@CAMPAIGN活動_PK", 20, marketingId);
            }

            if(!string.IsNullOrEmpty(marketingName)|| !string.IsNullOrEmpty(marketingId))
            {
                sql += $" AND [AD_SPACE廣告版面_PK]=@AD_SPACE廣告版面_PK";
                builder.AddInt("@AD_SPACE廣告版面_PK", pageId);
            }

            if (string.IsNullOrEmpty(marketingName) && string.IsNullOrEmpty(marketingId))
            {
                sql += $" WHERE [AD_SPACE廣告版面_PK]=@AD_SPACE廣告版面_PK";
                builder.AddInt("@AD_SPACE廣告版面_PK", pageId);
            }

            var parameters=builder.Build().ToArray();

            #endregion  
            sql += @" ORDER BY START_TIME開始時間";

            Func<SqlConnection> connGetter=SqlDb.GetConnection;
            Func<SqlDataReader, MarketingDto> func = MarketingAssembler.MarketingDtoAssembler;
            
            return SqlDb.Search(connGetter, sql, func, parameters).ToList();

        }



        public int Update(MarketingDetailDto dto)
        {
            string sql = @"UPDATE CAMPAIGN_廣告活動 
SET [CAMPAIGN_NAME活動名稱] = @CAMPAIGN_NAME活動名稱
,[AD_SPACE廣告版面_PK] = @AD_SPACE廣告版面_PK
,[URL連結] = @URL連結
,[START_TIME開始時間] = @START_TIME開始時間
,[END_TIME結束時間] = @END_TIME結束時間
,[AD_IMG廣告圖] = @AD_IMG廣告圖
WHERE [CAMPAIGN活動_PK] = @CAMPAIGN活動_PK ";

            SqlParameter[] parameters = new SqlParameterBuilder()

                    .AddInt("@AD_SPACE廣告版面_PK", dto.AD_SPACE廣告版面_PK)
                    .AddNVarchar("@CAMPAIGN活動_PK", 20, dto.CAMPAIGN活動_PK)
                    .AddNVarchar("@CAMPAIGN_NAME活動名稱", 100, dto.CAMPAIGN_NAME活動名稱)
                    .AddNVarchar("@URL連結", 5000, dto.URL連結)
                    .AddDateTime("@START_TIME開始時間", dto.START_TIME開始時間)
                    .AddDateTime("@END_TIME結束時間", dto.END_TIME結束時間)
                    .AddNVarchar("@AD_IMG廣告圖", 5000, dto.AD_IMG廣告圖)
                    .Build();


            Func<SqlConnection> connGetter = SqlDb.GetConnection;

            return SqlDb.UpdateOrDelete(connGetter, sql, parameters);

        }

        public int Create(MarketingDetailDto dto)
        {
            string sql = @"INSERT INTO [CAMPAIGN_廣告活動]
(CAMPAIGN活動_PK,AD_SPACE廣告版面_PK,CAMPAIGN_NAME活動名稱
,URL連結,START_TIME開始時間,END_TIME結束時間,AD_IMG廣告圖)
VALUES
(@CAMPAIGN活動_PK,@AD_SPACE廣告版面_PK,@CAMPAIGN_NAME活動名稱
,@URL連結,@START_TIME開始時間,@END_TIME結束時間,@AD_IMG廣告圖)";

            var parameters = new SqlParameterBuilder()
                    .AddNVarchar("@CAMPAIGN活動_PK", 20, dto.CAMPAIGN活動_PK)
                    .AddInt("@AD_SPACE廣告版面_PK", dto.AD_SPACE廣告版面_PK)
                    .AddNVarchar("@CAMPAIGN_NAME活動名稱", 100, dto.CAMPAIGN_NAME活動名稱)
                    .AddNVarchar("@URL連結", 5000, dto.URL連結)
                    .AddDateTime("@START_TIME開始時間", dto.START_TIME開始時間)
                    .AddDateTime("@END_TIME結束時間", dto.END_TIME結束時間)
                    .AddNVarchar("@AD_IMG廣告圖", 5000, dto.AD_IMG廣告圖)
                    .Build();

            return SqlDb.Create(SqlDb.GetConnection, sql, parameters);
        }
    }
}