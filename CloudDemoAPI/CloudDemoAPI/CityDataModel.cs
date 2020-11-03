using CloudDemoAPI.Model;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CloudDemoAPI
{
    public class CityDataModel
    {
        private static List<City> _cities;
        public CityDataModel()
        {
            _cities = new List<City>() 
            { new City { Id = 1, Name = "New York" },
                new City { Id = 2, Name = "CT" },
                new City { Id = 3, Name = "NJ" } };

        }
        public    List<City>  Current { get { return _cities; }  }

    }
}
