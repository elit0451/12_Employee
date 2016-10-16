using System;
using System.Collections.Generic;
using System.IO;

namespace _12_Employee
{
    internal class EmployeeRepository
    {
        List<Employee> listOfEmployees = new List<Employee>();
        private int id = 0;
        internal void Clear()
        {
            listOfEmployees.Clear();
        }

        internal int CountEmployees()
        {
            return listOfEmployees.Count;
        }

        internal Employee CreateEmployee(string name, string type)
        {
            
            Employee newEmployee = new Employee(name, type);
            id++;
            newEmployee.Id = id;
            listOfEmployees.Add(newEmployee);

            return newEmployee;
        }

        internal void SaveEmployee(Employee employeeObj)
        {
            FileInfo file = new FileInfo("Employee" + employeeObj.Id + ".txt");
            FileStream fs = file.Create();
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(employeeObj.Name);
            sw.WriteLine(employeeObj.Type);
            sw.WriteLine(employeeObj.Id);
            sw.Close();
            fs.Close();
        }

        internal Employee LoadEmployee(int id)
        {
           return listOfEmployees[id-1];
        }

        internal List<Employee> FindAllEmployees()
        {
            return listOfEmployees;
        }
    }
}