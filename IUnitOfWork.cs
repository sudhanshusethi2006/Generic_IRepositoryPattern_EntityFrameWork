using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConcpets
{
    interface IUnitOfWork
    {
        IRespository<EmployeeInfo> EmployeeRespository { get; }

        IRespository<Department> DepartmentRespository { get; }

        void SaveChanged();


    }
}
