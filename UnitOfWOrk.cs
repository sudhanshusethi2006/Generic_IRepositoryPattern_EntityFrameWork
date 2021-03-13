using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConcpets
{
    class UnitOfWOrk : IUnitOfWork
    {
        EmployeeSystemEntities dbContext;
        public UnitOfWOrk()
        {
            dbContext = new EmployeeSystemEntities();

        }
        IRespository<EmployeeInfo> _employeeRepository;
        IRespository<Department> _departmentRepository;
        public IRespository<EmployeeInfo> EmployeeRespository
        {

            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new Repository<EmployeeInfo>(dbContext);
                }

                return _employeeRepository;
            }
        }
        public IRespository<Department> DepartmentRespository
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new Repository<Department>(dbContext);
                }

                return _departmentRepository;

            }
        }
        public void SaveChanged()
        {
            dbContext.SaveChanges();
        }
    }
}
