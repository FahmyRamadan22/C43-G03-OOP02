using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOp_Assignment02
{
    internal class Employee : IComparable
    {
        private int id;
        private string name;
        private double salary;
        private SecurityPrevileges securityPrevileges;
        private Gender gender;
        private HiringDate hiringDate;

        public Employee(int id, string name, double salary, SecurityPrevileges securityPrevileges, Gender gender, HiringDate hiringDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.securityPrevileges = securityPrevileges;
            this.gender = gender;
            this.hiringDate = hiringDate;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public HiringDate HiringDate
        {
            get { return hiringDate; }
            set { hiringDate = value; }
        }


        public SecurityPrevileges SecurityPrevileges
        {
            get { return securityPrevileges; }
            set { securityPrevileges = value; }
        }




        public int GetId() => Id;
        public string GetName() => Name;
        public Gender GetGender() => Gender;
        public HiringDate GetHiringDate() => HiringDate;
        public SecurityPrevileges GetSecurityPrevileges() => SecurityPrevileges;

        public override string ToString()
        {
            return $"Employee Details:\n" +
                   $"ID: {id}\n" +
                   $"Name: {name}\n" +
                   $"Salary: {salary:C}\n" +
                   $"Security Privileges: {securityPrevileges}\n" +
                   $"Gender: {gender}\n" +
                   $"Hiring Date: {hiringDate}\n";
        }
        public int CompareTo(object? obj)
        {

            Employee employee = (Employee)obj!;

            if (employee is { })
            {
                if (hiringDate.Year != employee.HiringDate.Year)
                    return hiringDate.Year.CompareTo(employee.HiringDate.Year);

                if (hiringDate.Month != employee.HiringDate.Month)
                    return hiringDate.Month.CompareTo(employee.HiringDate.Month);

                return hiringDate.Day.CompareTo(employee.HiringDate.Day);
            }
            else return 0;
        }
    }

}
