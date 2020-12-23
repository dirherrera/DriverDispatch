using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverDispatch.Models
{

	public class DriverAssistance
	{

		public string DVRCODE { get; set; }
		public string DRVNAME { get; set; }
		public string DRVCLASS { get; set; }
		public string TRUCKID { get; set; }
		public string STATUS { get; set; }
		public DateTime DATEIN { get; set; }
		public DateTime DATEOUT { get; set; }
		public string INYARD { get; set; }
		public string GROUP { get; set; }
		public string EVENT { get; set; }
		public bool ISREGISTERED { get; set; }
		public bool ACCESSENABLED { get; set; }

	}

}

