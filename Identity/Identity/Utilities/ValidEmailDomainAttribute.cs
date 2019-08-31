using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Utilities
{
    public class ValidEmailDomainAttribute : ValidationAttribute
    {
        private readonly string alloweDomain;

        public ValidEmailDomainAttribute(string alloweDomain)
        {
            this.alloweDomain = alloweDomain;
        }

        public override bool IsValid(object value)
        {
           string[] strings=  value.ToString().Split('@');
           return  strings[1].ToUpper() == alloweDomain.ToUpper();
        }
    }
}
