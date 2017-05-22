using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using NestedClass.Controllers;

namespace NestedClass
{
    public class ParentValidator : AbstractValidator<OuterClass>
    {
        public ParentValidator()
        {

        }
    }
}