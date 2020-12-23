using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DriverDispatch.Data;

namespace DriverDispatch.API
{

	[Route("api/[controller]")]
	[ApiController]
	public class DriverAssistanceController : ControllerBase
	{

		[HttpPost("Get")]
		public ActionResult<string> Get()
		{
			return Queries.DriverDispatchResult();
		}

	}

}
