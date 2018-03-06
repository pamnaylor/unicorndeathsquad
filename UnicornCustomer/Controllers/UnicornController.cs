using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnicornCustomer.Database;

namespace UnicornCustomer.Controllers
{
    public class UnicornController : ApiController
    {
        // POST: api/Unicorn
        public string Post(DTO obj)
        {
            var s = "r";

            var db = new Database.Customer();
            //db.Save(obj.FirstName, obj.LastName, obj.Nationality, obj.Age);

            return "done";
        }       
    }
}
