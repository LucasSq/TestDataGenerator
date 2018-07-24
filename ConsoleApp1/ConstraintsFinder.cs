using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCode
{
    public class ConstraintsFinder
    {
        public Constraints FindConstraints(String fieldname)
        {
            Constraintslist constraintslist = new Constraintslist();
            Constraints constraints = new Constraints();
            constraints = constraintslist.constraints.Find(item => item.fieldname == fieldname);
            return constraints;
        }

    }
}
