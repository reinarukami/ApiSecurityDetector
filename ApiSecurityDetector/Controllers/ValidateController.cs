using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSecurityDetector.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiSecurityDetector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<bool> Get()
        {
			var result = ValidateFlashDrive._GetFlashDrives();
			return result;
        }

		[HttpPost]
		public ActionResult<bool> Post()
		{
			//Validate[FromBody] USB Serial and Settings if it is Registered in the record

			return true;
		}


    }
}
