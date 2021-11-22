using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeamSH_DB4O
{
    public class City
    {
        public string CityID { get; set; }
        public string CityName { get; set; }
        public string CityCountry{ get; set; }
        
        public City(string cityID = null, string cityName = null, string cityCountry = null)
        {
            CityID = cityID;
            CityName = cityName;
            CityCountry = cityCountry;
        }

        public override string ToString()
        {
            return $"{CityID} : {CityName} : {CityCountry} ";
        }

    }
}
    
