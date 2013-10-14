using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class ShouldNotContainEmailAttribute : ValidationAttribute
    {
        

        public override bool IsValid(object value)
        {
            int MinimumLength = 6;
            int MaximumLength = 1000;

            string valueAsString = value as string;
            if (valueAsString == null)
            {
                return true;
            }

            if (Regex.IsMatch(valueAsString, @"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,4}"))
            {
                return false;
            }

            if (valueAsString.Length < MinimumLength || valueAsString.Length > MaximumLength)
            {
                return false;
            }

            return true;

            
        }

        
    }
}
