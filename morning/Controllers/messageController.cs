using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using morning.Models;
using morning.service;

namespace morning.Controllers
{
    public class messageController : Controller
    {
        //例項化Service 
        messageDBService data = new messageDBService();     // GET: /message/ 
        public ActionResult Index()
        { //Article列表 
            return View(data.GetData());
        }
        public ActionResult Create()
        {
            return View();
        }
  
    [HttpPost]
        public ActionResult Create(string strAtricle, string strContent,int score)
        { //呼叫Service中的Create方法,把資料寫到資料庫中
            data.DBCreate(strAtricle, strContent,score);
            //重導向到Action 
            return RedirectToAction("Index");
        }
       
    }
}