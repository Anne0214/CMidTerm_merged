using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd.Dtos
{
	public class MemberDto
	{
		public string Member_ID { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime Register_Time { get; set; }
		public string Nickname { get; set; }
		public string Profile_Photo { get; set; }//頭貼檔案名稱
		public string Self_Intro { get; set; }
		public string Received_Person_Name { get; set; }
		public string Received_Person_Phone { get; set; }
		public string Received_Person_Address { get; set; }
		//public int total_rows { get; set; }
	}
}
