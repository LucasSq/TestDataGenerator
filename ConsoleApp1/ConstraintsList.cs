using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCode
{
    public class Constraintslist
    {
        public List<Constraints> constraints = new List<Constraints>
        {
           new Constraints(){ fieldname = "Naam",                      minlength=3,      maxlength=10 },
           new Constraints(){ fieldname = "Telefoonnummer",            minlength=10,     maxlength=20 }
        };
    }
}
