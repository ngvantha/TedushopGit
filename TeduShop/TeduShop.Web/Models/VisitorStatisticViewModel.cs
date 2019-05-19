using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class VisitorStatisticViewModel
    {
        public int ID { set; get; }

        public DateTime VisiteDate { set; get; }

        public string IPAddress { set; get; }
    }
}