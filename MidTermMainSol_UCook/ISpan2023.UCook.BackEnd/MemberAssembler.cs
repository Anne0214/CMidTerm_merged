using ISpan2023.UCook.BackEnd.Dtos;
using System;
using Ado.Net.SqlDataLayer;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd
{
	public class MemberAssembler
	{

		public static Func<SqlDataReader, MemberDto> MemebrDtoAssembler
		{
			get
			{
				//宣告委派，傳入一個SqlDataReader, 傳回CategoryDto
				Func<SqlDataReader, MemberDto> func = (reader) =>
				{
					string member_id = reader.GetString("MEMBER_ID會員_PK");
					string email = reader.GetString("MEMBER_EMAIL");
					string password = reader.GetString("MEMBER_PASSWORD");
					DateTime register_time = reader.GetDateTime("REGISTER_TIME註冊時間");
					string nick_name = reader.GetString("NICK_NAME暱稱");
					string profile_photo = reader.GetString("PROFILE_PHOTO頭貼");
					string self_intro = reader.GetString("SELF_INTRO自介");
					string received_p_name = reader.GetString("RECEIVED_PERSON_NAME收件人姓名");
					string received_p_phone = reader.GetString("RECEIVED_PERSON_PHONE收件人電話");
					string received_p_address = reader.GetString("RECEIVED_PERSON_ADDRESS收件人地址");
					return new MemberDto
					{
						Member_ID = member_id,
						Email = email,
						Password = password,
						Register_Time = register_time,
						Nickname = nick_name,
						Profile_Photo = profile_photo,
						Self_Intro = self_intro,
						Received_Person_Name = received_p_name,
						Received_Person_Phone = received_p_phone,
						Received_Person_Address = received_p_address
					};
				};
				return func;
			}
		}
	}
}
