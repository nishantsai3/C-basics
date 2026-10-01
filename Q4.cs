/*
4 Employee directory
Create an Employee class with Name, Department and Salary. Hold several in a List, then build
a Dictionary mapping each department to the total salary paid in it. Print each department
total and the highest-paying department.

EXPECTED OUTPUT
IT: 195000
HR: 85000
Sales: 120000
Highest paying: IT
*/

using System;
using System.Collections.Generic;

class Employee
{
    public string Name;
    public string Department;
    public int Salary;

    public Employee(string name, string department, int salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Q4
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter department: ");
            string dept = Console.ReadLine();
            Console.Write("Enter salary: ");
            int salary = int.Parse(Console.ReadLine());
            employees.Add(new Employee(name, dept, salary));
        }

        Dictionary<string, int> deptSalary = new Dictionary<string, int>();
        foreach (Employee emp in employees)
        {
            if (deptSalary.ContainsKey(emp.Department))
            {
                deptSalary[emp.Department] += emp.Salary;
            }
            else
            {
                deptSalary[emp.Department] = emp.Salary;
            }
        }
        string highDept = "";
        int highSalary = 0;
        foreach (KeyValuePair<string, int> item in deptSalary)
        {
            Console.WriteLine(item.Key + ": " + item.Value);

            if (item.Value > highSalary)
            {
                highSalary = item.Value;
                highDept = item.Key;
            }
        }
        Console.WriteLine("Highest paying: " + highDept);
    }
}