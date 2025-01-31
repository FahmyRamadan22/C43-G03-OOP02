namespace OOp_Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 1.	Design and implement a Class for the employees in a company:
            //Employee emp;



            //emp = new Employee(100, "Fahmy", 20000f, (SecurityPrevileges)8, Gender.Male, new HiringDate(12, 5, 2025));

            //Console.WriteLine($"GetType(): {emp.GetType()}");
            //Console.WriteLine(emp);
            //Console.WriteLine("===========================================================");

            #endregion
            #region  2.Develop a Class to represent the Hiring Date Data:




            #endregion
            #region 3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //   Employee[] employees =
            //[
            //   new(100, "Fahmy", 80000f, (SecurityPrevileges) 8, Gender.Male, new HiringDate(12, 5, 2025)),
            //          new(101, "Ahmed", 50000f, (SecurityPrevileges) 1, Gender.Male, new HiringDate(1, 10, 2023)),
            //          new(102, "Sara", 90000f, (SecurityPrevileges) 15, Gender.Female, new HiringDate(15, 3, 2020))
            //];

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].HiringDate);

            //}

            Console.WriteLine("===========================================================");



            #endregion
            #region 4.Sort the employees based on their hire date then Print the sorted array.

            //         Employee[] employees =
            //[
            //   new(100, "Fahmy", 80000f, (SecurityPrevileges) 8, Gender.Male, new HiringDate(12, 5, 2025)),
            //                new(101, "Ahmed", 50000f, (SecurityPrevileges) 1, Gender.Male, new HiringDate(1, 10, 2023)),
            //                new(102, "Sara", 90000f, (SecurityPrevileges) 15, Gender.Female, new HiringDate(15, 3, 2020))
            //];

            //         Array.Sort(employees);

            //         Console.WriteLine("Sorted Employees");

            //         for (int i = 0; i < employees.Length; i++)
            //         {
            //             Console.WriteLine(employees[i]);
            //         }
            #endregion
            #region 5-Design a program for a library management system where:
            Book eBook = new EBook("Rich Dad Poor Dad", "Robert Kiyosaki", "1211", 500f);
            Console.WriteLine(eBook.ToString());

            Console.WriteLine();

            Book printedBook = new PrintedBook("Rich Dad Poor Dad", "Robert Kiyosaki", "1211", 600);
            Console.WriteLine(printedBook.ToString());
            #endregion
        }
    }
}


   
        
