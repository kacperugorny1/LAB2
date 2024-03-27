using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Hourly
    {
        public List<string> time { get; set; }
        public List<double> temperature_2m { get; set; }
        public override string ToString()
        {
            string res = "";
            
            foreach(var tp in time.Zip(temperature_2m)) 
            {
                res += $"Temp: {tp.Second}, Time: {tp.First}\n";
            }
            return res;
        }
    }

    public class HourlyUnits
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }

        public override string ToString()
        {
            return $"Time_format: {time}, Temperature_unit: {temperature_2m}\n";
        }
    }

    public class JsonFull
    {
        public int Id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public HourlyUnits hourly_units { get; set; }
        public Hourly hourly { get; set; }

        public override string ToString()
        {
            string res = $"Temp for {latitude},{longitude}, timezone: {timezone}\n";
            res += hourly_units.ToString();
            res += hourly.ToString();
            return res;
        }
        internal IEnumerable<Weather> ToWeather(string city)
        {
            List<Weather> result = new List<Weather>();
            foreach(var val in Enumerable.Zip(hourly.temperature_2m,hourly.time))
            {
                result.Add(new(city,val.First ,val.Second));
            }
            return result;
        }
    }


}
