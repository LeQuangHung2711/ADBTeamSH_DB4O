using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeamSH_DB4O
{
    public class Plane
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public string ID { get; set; }
        public string Capacity { get; set; }
        public int Weight { get; set; }

        public Plane(string model = null, string year = null, string id = null, string capacity = null, int weight = 0)
        {
            Model = model;
            Year = year;
            ID = id;
            Capacity = capacity;

        }

        public override string ToString()
        {
            return $" {Model} : {Year} : {ID} : {Capacity} : {Weight} ";
        }
    }


}
