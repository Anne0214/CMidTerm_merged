using Ado.Net.SqlDataLayer;
using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd
{
    public class MemberRepository
    {
        List<MemberDto> data;
        public List<MemberDto> Search(string _nickname, string _email, string _pk, string _phone, string _registerStart, string _orderbyinfo)
        {
            string sql = $"SELECT * FROM MEMBER_會員";
            # region 建立Where條件式
            var builder = new SqlParameterBuilder();
            string where = string.Empty;
            if (string.IsNullOrEmpty(_nickname) == false)
            {
                where += $" AND NICK_NAME暱稱 LIKE '%' + @nick_name + '%'";
                builder.AddNVarchar("@nick_name", 400, _nickname);
            }
            if (string.IsNullOrEmpty(_email) == false)
            {
                where += $" AND MEMBER_EMAIL  LIKE '%' + @member_email + '%'";
                builder.AddNVarchar("@member_email", 400, _email);
            }
            if (string.IsNullOrEmpty(_pk) == false)
            {
                where += $" AND MEMBER_ID會員_PK  LIKE '%' + @member_id + '%'";
                builder.AddNVarchar("@member_id", 50, _pk);
            }
            if (string.IsNullOrEmpty(_phone) == false)
            {
                where += $" AND RECEIVED_PERSON_PHONE收件人電話  LIKE '%' + @phone + '%'";
                builder.AddNVarchar("@phone", 200, _phone);
            }
            if (string.IsNullOrEmpty(_registerStart) == false)
            {
                where += $" AND REGISTER_TIME註冊時間 <= @registerStart ";//預設會是今天
                builder.AddNVarchar("@registerStart", 50, _registerStart);//**格式轉換
            }
            if (string.IsNullOrEmpty(where) == false)
            {
                where = " WHERE " + where.Substring(5);//如果where有條件，where = " WHERE " + 把前面5個字_AND_刪掉
                sql += where;
            }
            #endregion
            //builder.AddIntOut("@totalrows");//**
            var parameters = builder.Build();
            //sql += " ORDER BY MEMBER_ID會員_PK";
            if (_orderbyinfo == "註冊時間由遠至近") 
            {
                sql += " ORDER BY REGISTER_TIME註冊時間 ASC";
            }
            if(_orderbyinfo == "註冊時間由近至遠")
            {
                sql += " ORDER BY REGISTER_TIME註冊時間 DESC";
            }

            using (var conn = SqlDb.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;

                    if (parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);//加入上方建立Where條件式
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<MemberDto> data = new List<MemberDto>();

                    while (reader.Read() == true)
                    {   //先全部傳回來
                        data.Add(MemberAssembler.MemebrDtoAssembler(reader));
                    }
                    return data;
                }
            }
        }
        public MemberDto Get(string _member_id) 
        {
            string sql = $"SELECT * FROM MEMBER_會員 WHERE MEMBER_ID會員_PK = {_member_id}";
            
            using (var conn = SqlDb.GetConnection()) 
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand()) 
                {
                    cmd.CommandText = sql;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read() == true) 
                    {
                        return MemberAssembler.MemebrDtoAssembler(reader);
                    }
                    return null;
                }
            }
        }
        //*6個可能修改欄位Nickname, SelfIntro, Received_Person_Name, Received_Person_Address,Received_Person_Phone(Phone & Received_Person_Phone must be the same)
        public int Update(string _member_id, string _nickname, string _selfintro, string _rpn, string _rpa, string _rpp, string _profile_photo) 
        {
            string sql = $"UPDATE MEMBER_會員 SET ";//WHERE MEMBER_ID會員_PK = {_member_id}加在最後
            var builder = new SqlParameterBuilder();
            #region
            if (string.IsNullOrEmpty(_nickname) == false) 
            {
                sql += " NICK_NAME暱稱 = @nickname,";
                builder.AddNVarchar("@nickname", 50, _nickname);
            }
            if (string.IsNullOrEmpty(_selfintro) == false)
            {
                sql += " SELF_INTRO自介 = @selfintro,";
                builder.AddNVarchar("@selfintro", 400, _selfintro);
            }
            if (string.IsNullOrEmpty(_rpn) == false)
            {
                sql += " RECEIVED_PERSON_NAME收件人姓名 = @rpn,";
                builder.AddNVarchar("@rpn", 200, _rpn);
            }
            if (string.IsNullOrEmpty(_rpa) == false)
            {
                sql += $" RECEIVED_PERSON_ADDRESS收件人地址= @rpa,";
                builder.AddNVarchar("@rpa", 200, _rpa);
            }
            if (string.IsNullOrEmpty(_rpp) == false)
            {
                sql += $" RECEIVED_PERSON_PHONE收件人電話 = @rpp,";
                builder.AddNVarchar("@rpp", 200, _rpp);
            }
            if (string.IsNullOrEmpty(_profile_photo) == false) 
            {
                sql += $" PROFILE_PHOTO頭貼 = @profile_photo,";
                builder.AddNVarchar("@profile_photo", 400, _profile_photo);
            }

            int startIndex = 0;//第一個字
            int endIndex = sql.Length - 1;//最後一個字 - 1(拿掉最後一個SET的逗號)
            sql = sql.Substring(startIndex, endIndex);
            sql += $" WHERE MEMBER_ID會員_PK = @member_id";
            builder.AddNVarchar("@member_id", 50, _member_id);
            #endregion

            var parameters = builder.Build();

            using (var conn = SqlDb.GetConnection()) //使用靜態方法，不用new
            {
                conn.Open();//連線開啟
                using (SqlCommand cmd = conn.CreateCommand())//連線後，建立指令
                {
                    cmd.CommandText = sql;//建立指令內容

                    if (parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
