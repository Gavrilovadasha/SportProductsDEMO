using SportProductsDEMO.tradeDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportProductsDEMO.Classes
{
	public class DataBaseManager
	{
		public string dbConnection = "Data Source=DASHA\\SQLEXPRESS;Initial Catalog=trade;Integrated Security=True;";
		/// <summary>
		/// Метод получения данных о пользователе из бд.
		/// </summary>
		public bool AuthenticateUser(string login, string password)
		{
			using (SqlConnection conn = new SqlConnection(dbConnection))
			{
				conn.Open();

				SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE login_user = @login AND password_user = @password", conn);
				cmd.Parameters.AddWithValue("@login", login);
				cmd.Parameters.AddWithValue("@password",password);

				int count = Convert.ToInt32(cmd.ExecuteScalar());
				return count > 0;
			}
		}
	}
}
