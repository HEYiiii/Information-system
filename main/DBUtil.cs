
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace main
{
	class DBUtil
	{
	
			public static SqlConnection GetConn()
			{
            try
            {
				string strConn = "Data Source=DESKTOP-DMOU63U;Initial Catalog=c#;User Id=wmg;Password=wu000414mg";
				SqlConnection conn = new SqlConnection(strConn);
				return conn;

            }catch(Exception e)
            {
				throw e;
            }
				
			}
			//***执行查询并返回DataTable对象
			public static DataTable ExecuteDataSet(string sql)
			{
				try
				{
					DataTable dt = new DataTable();
					SqlConnection con = GetConn();
					SqlDataAdapter da = new SqlDataAdapter(sql, con);
					da.Fill(dt);
					return dt;
				}
				catch (Exception e)
				{
					throw e;
				}
			}
			// 执行Insert into、Delete、Update等操作，返回本次操作受影响的行数
			public static int ExecuteSql(string sql)
			{
			
				try
				{
					SqlConnection con = GetConn();
					SqlCommand cmd = new SqlCommand(sql, con);
					if (con.State != ConnectionState.Open)
						con.Open();
					int count = cmd.ExecuteNonQuery();
					con.Close();
					return count;
				}
				catch (Exception e)
				{
					throw e;
				}
			}
	}
}
