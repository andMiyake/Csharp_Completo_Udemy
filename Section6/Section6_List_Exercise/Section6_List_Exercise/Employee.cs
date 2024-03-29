﻿using System.Globalization;

namespace Section6_List_Exercise
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return string.Format($"{Id}, {Name}, ${Salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
