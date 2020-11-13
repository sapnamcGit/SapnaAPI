using CloudDemoAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDemoAPI.Controllers
{
    [ApiController]
    [Route("api/{Home}")]
    public class HomeController: Controller
    {
        private ISqlLiteRepository_Home _rep;

        public HomeController(ISqlLiteRepository_Home rep)
        {
            _rep = rep;
        }

        // Here DBContext test started.
        //https://localhost:44317/api/weatherforecast/New/CITIES/3/PointOfInterest/Records/employees   //Old URL

        // https://localhost:44317/api/Home/Records/employees
        [HttpGet]
        [Route("{Records}/{Employees}")]
        public IActionResult GetAllEmployees(int CityId, int id)
        {
            return Ok(_rep.ShowALLEmployees()); 
        }
             
        }
    }

