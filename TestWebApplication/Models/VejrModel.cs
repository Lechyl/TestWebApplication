using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApplication.Models
{
    public class VejrModel
    {
        public string LocationName { get; set; }
        public CurrentData CurrentData { get; set; }



    }

    public class CurrentData
    {
        public string Temperature { get; set; }
        public string SkyText { get; set; }
        public string Humidity { get; set; }
        public string WindText { get; set; }
    }
}
