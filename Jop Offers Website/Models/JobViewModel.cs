﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jop_Offers_Website.Models
{
    public class JobViewModel
    {
        public string JobTitle { get; set; }
        public IEnumerable<ApplyForJob> Items { get; set;}
    }
}