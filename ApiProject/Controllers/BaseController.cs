using ApiProject.Models.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiProject.Controllers
{
    public class BaseController : ApiController
    {
        protected ApiEntities Db;

        protected BaseController()
        {
            Db = new ApiEntities();

        }


        protected override void Dispose(bool disposing)
        {
            Db.Dispose();
            base.Dispose(disposing);
        }

    }
}
