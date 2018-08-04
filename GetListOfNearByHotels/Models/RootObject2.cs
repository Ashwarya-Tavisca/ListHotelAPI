using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetListOfNearByHotels.Models
{
    public class RootObject2
    {
        public List<Result> Results { get; set; }

        public string status { get; set; }
    }
}