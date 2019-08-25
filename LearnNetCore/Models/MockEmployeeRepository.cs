﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnNetCore.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _EmployeList;
        public  MockEmployeeRepository()
        {
            _EmployeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name ="Mary" ,Department="HR",Email="Mary@gmail.com"},
                new Employee() { Id = 1, Name = "John", Department = "IT", Email = "John@gmail.com" },
                new Employee() { Id = 1, Name = "Sam" ,Department="IT",Email="Sam@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _EmployeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}