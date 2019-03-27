using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Model;

namespace Cleaner.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {


        public int Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllActiveEmployeeList()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllEmployeeList()
        {
            throw new NotImplementedException();
        }

        public int Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
