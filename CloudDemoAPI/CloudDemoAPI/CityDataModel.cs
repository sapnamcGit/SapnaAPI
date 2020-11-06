using CloudDemoAPI.Model;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CloudDemoAPI
{
    public class CityDataStore
    {
        public  List<City> _cities;

        public CityDataStore()
        {
            _cities = new List<City>() 
            { new City { Id = 1, Name = "New York" , Description="NY",
            
             PointsInts=new List<PointsOfInterest>(){
                 new PointsOfInterest() {  Id=1 , Name="p1",Description="test"},
             new PointsOfInterest() {  Id=1 , Name="p1",Description="test"},
             new PointsOfInterest() {  Id=1 , Name="p1",Description="test"}}
            
            },
                new City { Id = 2, Name = "CT",
                 PointsInts=new List<PointsOfInterest>(){
                 new PointsOfInterest() {  Id=1 , Name="p1",Description="test"},
             new PointsOfInterest() {  Id=1 , Name="p1",Description="test"},
             new PointsOfInterest() {  Id=1 , Name="p1",Description="test"}}
            },
                new City { Id = 3, Name = "NJ" ,
                 PointsInts=new List<PointsOfInterest>(){
                 new PointsOfInterest() {  Id=1 , Name="p1",Description="test"},
             new PointsOfInterest() {  Id=1 , Name="p1",Description="test"}
             }
            } };

        }
        public  static CityDataStore Current { get { return new CityDataStore(); }  }

    }
}
