using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CloudDemoAPI.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Description  { get; set; }

        public ICollection<PointsOfInterest> PointsInts { get; set; }
        = new List<PointsOfInterest>();

    }
}
