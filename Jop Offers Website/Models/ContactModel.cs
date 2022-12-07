using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jop_Offers_Website.Models
{
    public class ContactModel
    {
        [Required]
        [DisplayName("الاسم")]
        public string Name { get; set; }
        [Required]
        [DisplayName("الايميل")]
        public string Email { get; set; }
        [Required]
        [DisplayName("الموضوع")]
        public string Subject { get; set; }
        [Required]
        [DisplayName("الرسالة")]
        public string Message { get; set; }
    }
}