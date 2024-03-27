using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public City(int id,string name, double latitude, double longitude)
        {
            Id = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
        public City(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    internal class Weather
    {
        public int Id { get; set; }
        public string City { get; set; }
        public double Temperature {  get; set; }
        public DateTime DateTime { get; set; }

        public Weather (string city,double temperature , string dateTime)
        {
            string format = "yyyy-MM-ddTHH:mm";
            City = city;
            Temperature = temperature;
            if (DateTime.TryParseExact(dateTime, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime result))
            {
                DateTime = result;
            }
            else
            {
                DateTime = DateTime.MinValue;
            }
        }
        public Weather(int id,string city, double temperature, DateTime dateTime)
        {
            Id = id;
            City = city;
            Temperature = temperature;
            DateTime = dateTime;
        }
        public override string ToString()
        {
            return $"{DateTime}: {Temperature.ToString()}\n";
        }
    }
}
