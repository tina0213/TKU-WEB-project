using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace morning.Models
{
    public class phone
    {
        [Display(Name="店家名稱")]
        public String Name { get; set; }
        [Display(Name = "店家電話")]
        public String Phone { get; set; }
        [Display(Name = "營業時間")]
        public String Time { get; set; }
    }
}