using System.Net;
using System.Text.Json;
using Ora10;
var json = new WebClient().DownloadString("https://math.uni-pannon.hu/~lipovitsa/cs/data/crime.json");
//Console.WriteLine(json);
var Crimes = JsonSerializer.Deserialize<List<Object>>(json);
List<Crime> CrimesList = new List<Crime>();
foreach(var crime in Crimes)
{
    Console.WriteLine(crime);
}