using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using morning.Models;

namespace morning.Controllers
{
    public class phoneController : Controller
    {
        // GET: 店家資料
        public ActionResult phonelist()
        {
            List<introduce> phones = new List<introduce>
            {
                new introduce{Name="佳佳",Phone="02-26283222",Time="06:00-13:30(星期日休息)"},
                new introduce{Name="晨之美",Phone=" 02-2620-3556",Time=" 07:00–14:00"},
                new introduce{Name="亞米香蛋餅屋",Phone="02-8631-7816",Time="07:00-14:00(假日休息)"},
                new introduce{Name="早安早鳥",Phone=" 02-2622-0210",Time="07:00–16:00" },
                new introduce{Name="德芳美",Phone="02-2623-0284",Time="24 小時營業" },
                new introduce{Name="麥德多",Phone="02-2623-8947",Time=" 07:30–23:00(星期六休息)" },
                new introduce{Name="麥軒",Phone="02-2622-7516",Time=" 07:30–14:00(星期日08:00–14:00)" },
                new introduce{Name="小品屋",Phone=" 02-2628-3222",Time="06:00–13:30(星期日休息)" },
                new introduce{Name="拉雅",Phone="02-2626-0602",Time="06:30–13:30(假日07:00–14:00)" },
                new introduce{Name="麥味登",Phone=" 02-2623-5211",Time="04:00–13:30" },
                new introduce{Name="姐妹",Phone=" 02-2621-3765",Time="06:00–13:00" },
                new introduce{Name="多朗克",Phone="02-2626-3238",Time="07:00–14:30" },
                new introduce{Name="貞珍",Phone="02-2622-8289",Time=" 07:00–18:00(星期一休息)" },
                new introduce{Name="早安兔寶堡",Phone="0913-757-365",Time="08:00–15:00(假日09:00–15:00 星期一休息)" },
                new introduce{Name="小小麥",Phone="無",Time="06:00–16:00(假日休息)" },
                new introduce{Name="肥喵喵早午餐",Phone="02-2623-3390",Time=" 07:30–14:00(假日09:30–14:00)" },
                new introduce{Name="藍與白",Phone=" 02-2626-7080",Time="07:30–14:00(假日08:30–14:30)" },

            };
            return View(phones);
        }
    }
}