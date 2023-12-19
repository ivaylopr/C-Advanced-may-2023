﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{

	public class Car
	{
		private Engine engine;
		private Tire[] tires;
		public Car() 
		{
			Make = "VW";
			Model = "Golf";
			Year = 2025;
			FuelQuantity = 200;
			FuelConsumption = 10;

        }
        public Car(string make, string model, int year) : this()
		{
			Make = make;
			Model = model;
			Year = year;
		}
		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
		{
			FuelQuantity = fuelQuantity;
			FuelConsumption = fuelConsumption;

		}
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine,
			Tire[]tires) : this(make, model, year,fuelQuantity,fuelConsumption)
		{
			Engine=engine;
			Tires = tires;
		}

        private string make;

		public string Make
		{
			get { return make; }
			set { make = value; }
		}
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		private double fuelQuantity;

		public double FuelQuantity
		{
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}
		private double fuelConsumption;

		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}



        public Engine Engine { get; set; }

      public Car(Engine engine)
        {
            Engine = engine;
        }

        public void Drive(double distance)
		{
			double neededFuel = distance * fuelConsumption;
			if (FuelQuantity - neededFuel >= 0)
			{
				FuelQuantity -= neededFuel;
			}
			else
			{
				Console.WriteLine("Not enough fuel to perform this trip!");
			}
		}
		public string WhoAmI()
		{
			StringBuilder result = new StringBuilder();
			result.AppendLine($"Make: {this.Make}");
			result.AppendLine($"Model: {this.Model}");
			result.AppendLine($"Year: {this.Year}");
			result.AppendLine($"Fuel: {this.FuelQuantity:f2}");
			return result.ToString().Trim();
		}


	
	} 
}

