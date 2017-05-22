using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NestedClass.Controllers
{
    public class OuterClass
    {
        public OuterClass()
        {
            System.Console.WriteLine("OuterClass");
        }

        public class NestedClass
        {
            public NestedClass()
            {
                System.Console.WriteLine("NestedClass");
            }

            public string Method()
            {
                return "Method class";
            }
        }
    }
}