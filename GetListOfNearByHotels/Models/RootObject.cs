using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetListOfNearByHotels.Models
{
        public class RootObject
        {
            public List<Prediction> predictions { get; set; }
              //public List<Hotels> Hotels { get; set; }
            public string status { get; set; }
        }
}