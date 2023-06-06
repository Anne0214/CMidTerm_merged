﻿using Ado.Net.SqlDataLayer;
using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.UCook.BackEnd
{
    public class ProductRepositories
    {
        /// <summary>
        /// 查詢多筆商品資料
        /// </summary>
        /// <param name="productName">查詢的產品名稱</param>
        /// <param name="spu">查詢的SPU號</param>
        /// <param name="sku">查詢的Sku號</param>
        /// <returns></returns>
        public List<ProductSearchDto> Search(string productName, string spu,string sku)
        {

            #region 組成sql語法
            string sql = @"Select a.SPU,[ON_SHELF上架狀態],[CATEGORY商品分類名稱],[PRODUCT_NAME商品名稱],[SALE_PRICE銷售價],SKU,STOCK_NUMBER庫存數量,SOLD_NUMBER售出數量
From [dbo].[PRODUCT_SPU_商品] as a
Join PRODUCT_SEARCH as b  
On a.SPU = b.SPU";

            string target = String.Empty;

            if (!string.IsNullOrEmpty(productName))
            {
                sql += @"
Where [PRODUCT_NAME商品名稱] Like @target""";
                target = @"%" + productName + @"%";
            }
            if (!string.IsNullOrEmpty(spu))
            {
                sql += @"
Where a.SPU = @target";
                target = spu;
            }
            if(!string.IsNullOrEmpty(sku))
            {
                sql += @"
Where SKU Like @target";
                target = @"%"+sku+@"%";
            }

            sql += @"
Group By a.SPU,[ON_SHELF上架狀態],[CATEGORY商品分類名稱],[PRODUCT_NAME商品名稱],[SALE_PRICE銷售價],SKU,STOCK_NUMBER庫存數量,SOLD_NUMBER售出數量";
            #endregion

            Func<SqlConnection> conn = SqlDb.GetConnection;
            SqlParameter parameter = new SqlParameter("@target", target);
            Func<SqlDataReader, ProductSearchDto> func = ProductAssembler.ProducSearchDtoAssembler;

            return SqlDb.Search<ProductSearchDto>(conn, sql, func, parameter).ToList();
            
        }
        public IEnumerable<ProductCSVDto> GetDetailBySpu(List<string> spus)
        {
            StringBuilder sqlBuild = new StringBuilder(@"Select a.[SPU]
      ,[img]
      ,[ON_SHELF上架狀態]
      ,[CATEGORY商品分類名稱]
      ,[PRODUCT_NAME商品名稱]
      ,[PRODUCT_DESCRIPTION簡短商品說明]
      ,[FULL_PRODUCT_DESCRIPTION完整說明圖片]
      ,[PURCHASE_PRICE採購價]
      ,[TAG_PRICE吊牌價]
      ,[SALE_PRICE銷售價]
      ,[SKU]
      ,[TYPE_NAME型號]
      ,[STOCK_NUMBER庫存數量]
      ,[SOLD_NUMBER已售出數量]
From [dbo].[PRODUCT_SPU_商品] as a
Join [dbo].[PRODUCT_SKU_商品] as b
on a.[SPU] = b.SPU
Where a.[SPU] in (");


            foreach(var i in spus)
            {
                sqlBuild.Append(@"'");
                sqlBuild.Append(i);
                sqlBuild.Append(@"'");
                sqlBuild.Append(@",");
            }
            string sql = sqlBuild.ToString();
            sql = sql.Substring(0, sql.Length - 1);
            sql += @")"; 

            using (SqlConnection conn = SqlDb.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;

                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read() == true)
                    {
                        yield return ProductAssembler.ProductCSVDtoAssembler(reader);
                    }

                }
            }

        }
        public (List<SkuDto>,ProductDetailDto) GetBySpu(string spu)
        {
            Func < SqlConnection > conn = SqlDb.GetConnection;
            string sql_product = @"Select [SPU],[img],[ON_SHELF上架狀態],[CATEGORY商品分類名稱],[PRODUCT_NAME商品名稱],[PRODUCT_DESCRIPTION簡短商品說明],[FULL_PRODUCT_DESCRIPTION完整說明圖片],[PURCHASE_PRICE採購價],[TAG_PRICE吊牌價],[SALE_PRICE銷售價]
From [dbo].[PRODUCT_SPU_商品]
Where [SPU] = @target";
            Func<SqlDataReader, ProductDetailDto> productAssembler = ProductAssembler.ProductDetailDtoAssembler;

            SqlParameter[] parameters = new SqlParameterBuilder()
                                                    .AddNVarchar("@target",100,spu)
                                                    .Build();
            string sql_sku = @"Select [SKU],[TYPE_NAME型號],[STOCK_NUMBER庫存數量],[SOLD_NUMBER已售出數量]
From [dbo].[PRODUCT_SKU_商品]
Where [SPU] = @target";
            Func<SqlDataReader, SkuDto> skuAssembler = ProductAssembler.SkuDtoAssembler;
            SqlParameter[] parameters_2 = new SqlParameterBuilder()
                                                    .AddNVarchar("@target", 100, spu)
                                                    .Build();
            var productDetailDto = SqlDb.Get<ProductDetailDto>(conn, sql_product, productAssembler, parameters);
            var skuDto = SqlDb.Search<SkuDto>(conn, sql_sku, skuAssembler,parameters_2).ToList();
            return (skuDto, productDetailDto);
        }
    
        public void Create(ProductDetailDto prodDto,List<SkuDto> skuDtos)
        {
            string sql_prod = @"Insert into [dbo].[PRODUCT_SPU_商品_TMP]
Values('20',@img,@onShelf,@category,@name,@shortIntro,@fullIntro,@purchasePrice,@tagPrice,@salePrice)
Select @newSPU = [SPU] 
From [iSpanDataBaseICook].[dbo].[PRODUCT_SPU_商品_TMP]
Where [PRODUCT_NAME商品名稱]= @name and [CATEGORY商品分類名稱]=@category";
            SqlParameter[] param_prod = new SqlParameterBuilder()
                                                .AddNVarchar("@img", 5000, prodDto.Cover)
                                                .AddNVarchar("@onShelf", 2, prodDto.OnShelf)
                                                .AddNVarchar("@category", 10, prodDto.Category)
                                                .AddNVarchar("@name", 30, prodDto.ProductName)
                                                .AddNVarchar("@shortIntro", 500, prodDto.ProductDescription)
                                                .AddNVarchar("@fullIntro", 5000, prodDto.FullProductDescription)
                                                .AddInt("@purchasePrice", prodDto.PurchasePrice)
                                                .AddInt("@tagPrice", prodDto.TagPrice)
                                                .AddInt("@salePrice", prodDto.SalePrice)                                 
                                                .Build();

            string sql_sku = @"Insert into [dbo].[PRODUCT_SKU_商品_TMP]
Values (@spu,@sku,@typeName,@stockNumber,@soldNumber)";
            
            using (SqlConnection sqlConnection = SqlDb.GetConnection())
            {
                sqlConnection.Open();
                SqlTransaction tran = sqlConnection.BeginTransaction();

                try
                {
                    SqlCommand cmd = sqlConnection.CreateCommand();

                    cmd.Connection = sqlConnection;
                    cmd.Transaction = tran;

                    cmd.CommandText = sql_prod;
                    cmd.Parameters.AddRange(param_prod);
                    cmd.Parameters.Add(new SqlParameter("@newSPU", System.Data.SqlDbType.NVarChar,100) { Direction = ParameterDirection.Output });
                    cmd.ExecuteNonQuery();
                    string spu =cmd.Parameters["@newSPU"].Value.ToString();

                    int g = 1; //用來做sku編號的數字
                    //遍歷每一個sku
                    foreach (var i in skuDtos)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = sql_sku;
                        SqlParameter[] params_sku = new SqlParameterBuilder()
                                            .AddNVarchar("@spu", 100,spu)
                                            .AddNVarchar("@sku", 100,spu+"-"+g.ToString())
                                            .AddNVarchar("@typeName", 100, i.TypeName)
                                            .AddInt("@stockNumber", i.StockNumber)
                                            .AddInt("@soldNumber", i.SoldNumber)
                                            .Build();
                        cmd.Parameters.AddRange(params_sku);
                        cmd.ExecuteNonQuery();
                        g++;
                    }

                    tran.Commit();

                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    throw new Exception($"更新失敗，原因:{ex.Message}");
                }
            }
            MessageBox.Show("成功");
                
        }

        public void Update(ProductDetailDto prodDto,List<SkuDto> skuDtos)
        {   //交易 : 修改product資料，刪除sku資料後再創建

			#region 修改product的準備
			string sql_prod = @"Update [dbo].[PRODUCT_SPU_商品_TMP]
Set [img]=@img, [ON_SHELF上架狀態] = @onShelf
,[CATEGORY商品分類名稱]= @category
,[PRODUCT_NAME商品名稱] = @prodName
,[PRODUCT_DESCRIPTION簡短商品說明] = @shortIntro
,[FULL_PRODUCT_DESCRIPTION完整說明圖片] = @fullIntro
,[PURCHASE_PRICE採購價] = @purchasePrice
,[TAG_PRICE吊牌價] = @tagPrice
,[SALE_PRICE銷售價] = @salePrice
Where [SPU] = @spu";
			SqlParameter[] param_prod = new SqlParameterBuilder()
												.AddNVarchar("@img", 5000, prodDto.Cover)
												.AddNVarchar("@onShelf", 2, prodDto.OnShelf)
												.AddNVarchar("@category", 10, prodDto.Category)
												.AddNVarchar("@prodName", 30, prodDto.ProductName)
												.AddNVarchar("@shortIntro", 500, prodDto.ProductDescription)
												.AddNVarchar("@fullIntro", 5000, prodDto.FullProductDescription)
												.AddInt("@purchasePrice", prodDto.PurchasePrice)
												.AddInt("@tagPrice", prodDto.TagPrice)
												.AddInt("@salePrice", prodDto.SalePrice)
                                                .AddNVarchar("@spu",100,prodDto.Spu)
												.Build();
#endregion

            //刪除sku的準備
			string sql_sku_delete = @"Delete From [dbo].[PRODUCT_SKU_商品_TMP]
Where SPU = @spu";



            //建立sku的準備
            string sql_sku_create = @"Insert into [dbo].[PRODUCT_SKU_商品_TMP]
Values (@spu,@sku,@typeName,@stockNumber,@soldNumber)";

			//連線、交易開始
			using (SqlConnection sqlConnection = SqlDb.GetConnection())
			{
				sqlConnection.Open();
				SqlTransaction tran = sqlConnection.BeginTransaction();

				try
				{
					SqlCommand cmd = sqlConnection.CreateCommand();

					cmd.Connection = sqlConnection;
					cmd.Transaction = tran;

                    //修改product
					cmd.CommandText = sql_prod;
					cmd.Parameters.AddRange(param_prod);
					cmd.ExecuteNonQuery();

                    //刪除該spu的所有sku
                    cmd.Parameters.Clear();
                    cmd.CommandText = sql_sku_delete;
                    SqlParameter param_sku_delete = new SqlParameter("@spu", prodDto.Spu);
                    cmd.Parameters.Add(param_sku_delete);
                    cmd.ExecuteNonQuery();


                    //創sku
                    int g = 1; //用來做sku編號的數字
							   //遍歷每一個sku
					foreach (var i in skuDtos)
					{
						cmd.Parameters.Clear();
						cmd.CommandText = sql_sku_create;
						SqlParameter[] params_sku = new SqlParameterBuilder()
											.AddNVarchar("@spu", 100, prodDto.Spu)
											.AddNVarchar("@sku", 100, prodDto.Spu + "-" + g.ToString())
											.AddNVarchar("@typeName", 100, i.TypeName)
											.AddInt("@stockNumber", i.StockNumber)
											.AddInt("@soldNumber", i.SoldNumber)
											.Build();
						cmd.Parameters.AddRange(params_sku);
						cmd.ExecuteNonQuery();
						g++;
					}

					tran.Commit();

				}
				catch (Exception ex)
				{
					tran.Rollback();
					throw new Exception(ex.Message);
				}
			}



		}
        public ProductDetailDto GetByName(string productName)
        {
			string sql = @"Select [SPU],[img],[ON_SHELF上架狀態],[CATEGORY商品分類名稱],[PRODUCT_NAME商品名稱],[PRODUCT_DESCRIPTION簡短商品說明],[FULL_PRODUCT_DESCRIPTION完整說明圖片],[PURCHASE_PRICE採購價],[TAG_PRICE吊牌價],[SALE_PRICE銷售價]
From [dbo].[PRODUCT_SPU_商品]
Where [PRODUCT_NAME商品名稱] = @name"; 
			SqlParameter[] parameters = new SqlParameterBuilder()
											.AddNVarchar("@name", 100, productName)
											.Build();
			Func<SqlDataReader, ProductDetailDto> productAssembler = ProductAssembler.ProductDetailDtoAssembler;
			Func<SqlConnection> conn = SqlDb.GetConnection;
            return SqlDb.Get<ProductDetailDto>(conn, sql, productAssembler, parameters);
		}
    }
}
