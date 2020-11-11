using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudDemoAPI.EntityData;
using Microsoft.AspNetCore.Mvc;

namespace CloudDemoAPI.Controllers
{
    [ApiController]
    [Route("api/{WeatherForecast}/{new}/{CITIES}/{CityId}/[controller]")]
    public class PointOfInterestController : Controller
    {
        private SQLiteDBContext db;

        public PointOfInterestController(SQLiteDBContext _db) {


            db = _db;



        }



        [HttpGet]
        public IActionResult GetPointOfInterest(int CityId)
        {
            var res = CityDataStore.Current._cities.FirstOrDefault(c => c.Id == CityId);
            if (res == null)
            {
                return NotFound();
            }
            else
                return Ok(res);
        }

        //https://localhost:44317/api/weatherforecast/New/CITIES/3/PointOfInterest/1
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPointOfInterestById(int CityId, int id)
        {
            //var db = new SQLiteDBContext();
            //db.Employees.Add(new Employee { FirstName = "Johni", LastName = "Doe", Age = 55 });
            //db.SaveChanges();

            var employee = db.Employees
                    .OrderBy(b => b.Id)
                    .First();

            var res = CityDataStore.Current._cities.FirstOrDefault(c => c.Id == CityId);
            res.Name = employee.FirstName;
            if (res == null)
            {
                return NotFound();
            }
            if (res.PointsInts.FirstOrDefault(res => res.Id == id) == null)
            {
                return NotFound();
            }
            return Ok(res.PointsInts.FirstOrDefault(p => p.Id == id));
        }


        // Here DBContext test started.
        //https://localhost:44317/api/weatherforecast/New/CITIES/3/PointOfInterest/Records/employees
        [HttpGet]
        [Route("{Records}/{Employees}")]
        public IActionResult getAllEmployees(int CityId, int id)
        {
            return Ok( db.Employees
                      .OrderBy(b => b.Id)
                      //.First()
                      
                      
                      
                      
                      );

        }
           
        }

    }


