using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineAccountBook.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckDateValidAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime target = (DateTime)value;
            if(target > DateTime.Now)
            {
                return false;
            }

            return true;
        }
    }
}