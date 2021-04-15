using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    public class CreationDate
    {
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime? DateCreated { get; set; }

        public string UserCreated { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime? DateModified { get; set; }
        public string UserModified { get; set; }
    }
}