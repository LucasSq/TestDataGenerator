using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRekt
{
    public class DataValidator
    {
        public string message = "";
        public string validateStringField(String field)
        {
            int minlength = 2;
            int maxlength = 10;
            
            if (field.Length < minlength)
            {
                message = "field length too short";
            }

            else if (field.Length > maxlength)
            {
                message = "field length too long";
            }

            else
            {
                message = "okidoki";
            }
            return message;
        }
    }
}
