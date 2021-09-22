using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;

namespace TP4.Logic
{
    public class EmployeesLogic: BaseLogic, IABMLogic<Employees>
    {
        public void Add(Employees employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Employees employee = context.Employees.Find(id);
            context.Employees.Remove(employee);
            context.SaveChanges();
        }

        public Employees Get(int id)
        {
            Employees employee = context.Employees.Find(id);
            return employee;
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Update(Employees employee)
        {
            Employees employeeUpdate = context.Employees.Find(employee.EmployeeID);
        }
    }
}
