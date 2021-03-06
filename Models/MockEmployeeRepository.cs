﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSIS.ViewModels;

namespace MSIS.Models
{
    public class MockEmployeeRepository : IEmployeeRepository

    {
        private List<Employee> _EmployeList;
        public  MockEmployeeRepository()
        {
            _EmployeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name ="Mary" ,Department=Dept.HR,Email="Mary@gmail.com"},
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "John@gmail.com" },
                new Employee() { Id = 3, Name = "Sam" ,Department=Dept.IT,Email="Sam@gmail.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _EmployeList;
        }


        public Employee GetEmployee(int Id)
        {
            return _EmployeList.FirstOrDefault(e => e.Id == Id);
        }
        public Employee Add(Employee employee)
        {
            employee.Id = _EmployeList.Max(e => e.Id) + 1;
            _EmployeList.Add(employee);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _EmployeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Department = employeeChanges.Department;
                employee.Email = employeeChanges.Email;               
            }
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee= _EmployeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _EmployeList.Remove(employee);
            }
            return employee;            
        }

        public string ValidateDeletEmployee(int Id)
        {
            throw new NotImplementedException();
        }

        public UserPermissionsViewModel GetUserParentMenuPermission(string userId, string PageName)
        {
            throw new NotImplementedException();
        }

        public ListEmployeesViewModel ListEmployees()
        {
            throw new NotImplementedException();
        }

        public bool IsEmployeeHasUser(string UserName, int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public ListEmployeesViewModel ListActiveEmployees()
        {
            throw new NotImplementedException();
        }

        public bool IsEmployeeExists(int EmployeeId, string EmployeeNo)
        {
            throw new NotImplementedException();
        }

        public ListEmployeesViewModel ListInActiveEmployees()
        {
            throw new NotImplementedException();
        }

        public AppDBContext getContext()
        {
            throw new NotImplementedException();
        }
    }
}
