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
        public Boolean Ok;
        public ValidationResult ValidateStringField(String field)
        {
            ValidationResult validationResult = new ValidationResult();
            int minlength = 2;
            int maxlength = 10;
            
            if (field.Length < minlength)
            {
                validationResult.Message = "field length too short";
                validationResult.OK = false;
            }

            else if (field.Length > maxlength)
            {
                validationResult.Message = "field length too long";
                validationResult.OK = false;
            }

            else
            {
                validationResult.Message = "okidoki";
                validationResult.OK = true;
            }
            return validationResult;
        }
    }
}
