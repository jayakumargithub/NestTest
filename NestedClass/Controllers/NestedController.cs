using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace NestedClass.Controllers
{
    public class NestedController : ApiController
    {

        public IHttpActionResult Get(ParentClass parent)
        {
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;


            var c = new ParentClass.AnotherChild();
            c.AnotherChildName = "Assigned at controller";
            var a = new ParentClass.ChildClass();
            a.ChildName = "Child name";
            object[] obj  = new object[2];
            obj[0] = c;
            obj[1] = a;
            return Ok(obj);
        }
    }


    public class ParentClass
    {
        public ParentClass()
        {
            ParentName = "My Name is Parent";
        }
        public string ParentName { get; set; }
        public class ChildClass
        {
            public ChildClass()
            {
                ChildName = "My Name is Child";
            }
            public string ChildName { get; set; }
            
        }

        public class AnotherChild
        {
            public AnotherChild()
            {
                AnotherChildName = "My Name is another Child";
            }
            public string AnotherChildName { get; set; }
        }
    }
}
