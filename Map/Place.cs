using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class Place
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AreaName { get; set; }
        public int AreaID { get; set; }
        public double GeoLat { get; set; }
        public double GeoLng { get; set; }
        public string Description { get; set; }
    }
}
