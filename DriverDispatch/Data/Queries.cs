using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DriverDispatch.Models;
using System.Text.Json;


namespace DriverDispatch.Data
{
	public class Queries
	{

		public static string DriverDispatchResult()
		{
			string result = "";

			string query = $"SELECT * FROM DriverAssistance WHERE [Status] = 1";
			DataTable table = DBContext.Fill(query);

			List<DriverAssistance> drivers = ModelAdapter.Fill<DriverAssistance>(table);

			result = JsonSerializer.Serialize(drivers);

			return result;
		}

	}
}
