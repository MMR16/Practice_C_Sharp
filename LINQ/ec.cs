using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class EC : IEqualityComparer<Employees>
    {
        bool IEqualityComparer<Employees>.Equals(Employees x, Employees y)
        {
            return x.EmployeeID==y.EmployeeID && x.FirstName ==y.FirstName;
        }

        int IEqualityComparer<Employees>.GetHashCode(Employees obj)
        {
            return obj.EmployeeID;
        }
    }
}
