using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using morning.Models;

namespace morning.service
{
    public class messageDBService
    {
        //例項化實體資料 
        public morning.Models.messageEntities db = new Models.messageEntities();
        //讀取並返回messageEntity中的資料 
        public List<Table> GetData()
        {
            return db.Table.ToList();
        }
        //把從User接受的資料寫入messageEnitity
        public void DBCreate(string strTitle, string strContent,int score)
        { //例項化Artile物件 
            Table newData = new Table();
            //給Artile物件的屬性賦值
            newData.Name = strTitle;
            newData.Content = strContent;
            newData.Time = DateTime.Now;
            newData.score = score;
            //實體新增到Entity中 
            db.Table.Add(newData);
            //儲存到資料庫
            db.SaveChanges();
        }
    }
}
