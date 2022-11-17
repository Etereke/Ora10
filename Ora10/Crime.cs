using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ora10
{
    public class Crime
    {
        public string Type;
        public int Year;
        public int Month;
        public int Day;
        public int Hour;
        public int Minute;
        public string HundredBlock;
        public string Neighbourhood;
        public float X;
        public float Y;
        public float Latitude;
        public float Longitude;


        public Crime() { }
        [JsonConstructor]
        public Crime(string type, int year, int month, int day, int hour, int minute,
            string hundred_Block, string neighbourhood, float x, float y, float latitude,
            float longitude)
        {
            Type = type;
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            HundredBlock = hundred_Block;
            Neighbourhood = neighbourhood;
            X = x;
            Y = y;
            Latitude = latitude;
            Longitude = longitude;
        }
        //[JsonConstructor]
        //public Crime() { }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Year: {Year}\n" +
                   $"Month: {Month}\n" +
                   $"Day: {Type}\n" +
                   $"Hour: {Type}\n" +
                   $"Minute: {Type}\n" +
                   $"HundredBlock: {HundredBlock}\n" +
                   $"Neighbourhood: {Neighbourhood}\n" +
                   $"X: {X}\n" +
                   $"Y: {Y}\n" +
                   $"Latitude: {Latitude}\n" +
                   $"Longitude: {Longitude}\n\n";
        }
    }
    public class CrimeList
    {
        public List<Crime> Crimes { get; set; }
    }
}
