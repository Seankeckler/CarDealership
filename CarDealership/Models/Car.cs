using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarDealership.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        
        public Car()
        {

        }

        public Car(string Make, string Model, int Year, string Color)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color;
        }
    }

    public class CarContext : DbContext
    {
        //DbSet<Car> Cars { get; set; }

        public System.Data.Entity.DbSet<CarDealership.Models.Car> Cars { get; set; }
    }
}