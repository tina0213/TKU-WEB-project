using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcHtmlHelpers.Models;
using System.Web.Mvc;
using morning.Models;
using morning.service;

namespace MvcHtmlHelpers.Models
{
    public class CmsContext : DbContext
    {
        public CmsContext() : base("CmsDbConnection") { }

        public DbSet Table { get; set; }
    }
 }
