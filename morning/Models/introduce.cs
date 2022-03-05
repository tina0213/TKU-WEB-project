using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace morning.Models
{
    public class introduce
    {
        [Display(Name = "店家名稱")]
        public String Name { get; set; }

        [Display(Name = "綜合評價")]
        public String Level{ get; set; }

        [Display(Name = "地址")]
        public String Address { get; set; }

        [Display(Name = "營業時間")]
        public String Time { get; set; }

        [Display(Name = "電話")]
        public String Phone { get; set; }

        [Display(Name = "店家介紹")]
        public String introduce1 { get; set; }
    }
}