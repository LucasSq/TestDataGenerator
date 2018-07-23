using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataGenerator
{
    public class DataValidator
    {
        public string message = "";
        public Boolean Ok;
        public ValidationResult ValidateStringField(String field, String fieldname)
        {
            ValidationResult validationResult = new ValidationResult();
            Constraintslist constraintslist = new Constraintslist();
            Constraints constraints = new Constraints();
            constraints = constraintslist.constraints.Find(item => item.fieldname == fieldname);

            int minlength = 3;
            int maxlength = constraints.maxlength;

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
