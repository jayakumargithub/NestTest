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

        public IHttpActionResult Get(OuterClass parent)
        {
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;
            OuterClass.NestedClass  d = new OuterClass.NestedClass();
          var output =  d.Method();


            return Ok(output);
        }
    }
}
