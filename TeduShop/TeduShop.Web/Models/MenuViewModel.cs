﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class MenuViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public string URL { set; get; }

        public int? DisplayOrder { get; set; }

        public int GroupID { set; get; }

        public virtual MenuGroupViewModel MenuGroup { set; get; }

        public string Target { set; get; }

        public bool Status { set; get; }
    }
}