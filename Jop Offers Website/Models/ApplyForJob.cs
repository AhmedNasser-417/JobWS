using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace Jop_Offers_Website.Models
{
    public class ApplyForJob
    {
        public int Id { get; set; }
        [DisplayName("الرسالة")]
        public string Message { get; set; }
        [DisplayName(" التاريخ")]
        public DateTime ApplyDate { get; set; }
        public int JobId { get; set; }
        public string UserId { get; set; }

        public virtual Job job { get; set; }
        public virtual ApplicationUser user { get; set; }
    }
}