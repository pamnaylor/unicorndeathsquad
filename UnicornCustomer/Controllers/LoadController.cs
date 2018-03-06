using System.Collections.Generic;
using System.Web.Http;
using UnicornCustomer.Database;

namespace UnicornCustomer.Controllers
{
    public class LoadController : ApiController
    {
        // POST: api/Load
        public List<DTO> Post(object obj)
        {
            var l = new List<DTO>();

            l.Add(new DTO { Age = 21, FirstName = "Mike1", LastName = "Smith1", Nationality = "British1" });
            l.Add(new DTO { Age = 22, FirstName = "Mike2", LastName = "Smith2", Nationality = "British2" });
            l.Add(new DTO { Age = 23, FirstName = "Mike3", LastName = "Smith3", Nationality = "British3" });
            l.Add(new DTO { Age = 24, FirstName = "Mike4", LastName = "Smith4", Nationality = "British4" });
            
            return l;
        }
    }
}
