using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_AssignmentDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================Assignment 1=========================");
            List<Food> foods = new List<Food>();
            Food f1 = new Food("Samosa", 20);
            Food f2 = new Food("VadaPaav", 10);
            Food f3 = new Food("Pizza", 100);
            Food f4 = new Food("Burger", 50);
            Food f5 = new Food("Sandwich", 30);

            foods.Add(f1);
            foods.Add(f2);
            foods.Add(f3);
            foods.Add(f4);
            foods.Add(f5);

            Console.WriteLine("\n-------------Foods available at Cafe-------------");
            foreach (Food item in foods)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("\n\n===========================Assignment 2=========================");
            //ArrayList Category = new ArrayList();





            Console.WriteLine("\n\n===========================Assignment 3=========================");
            Console.WriteLine("\n---------------Employee Names----------------");
            string[] empname = { "Mrunali", "Shriya", "Ayushi", "Riyaa", "Pranali" };
            foreach (string emp in empname)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("\n\n===========================Assignment 4=========================");
            Console.WriteLine("\n------------------Product Names-------------------");
            Product product = new Product();
            product.ProductId = 101;
            product.ProductName = "HP Laptop";
            product.ProductPrize = 45000;
            Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.ProductPrize);

            product.ProductId = 102;
            product.ProductName = "Dell Laptop";
            product.ProductPrize = 50000;
            Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.ProductPrize);

            product.ProductId = 103;
            product.ProductName = "Lenovo Laptop";
            product.ProductPrize = 55000;
            Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.ProductPrize);

            product.ProductId = 104;
            product.ProductName = "MI Laptop";
            product.ProductPrize = 65000;
            Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.ProductPrize);

            product.ProductId = 105;
            product.ProductName = "MAC Laptop";
            product.ProductPrize = 155000;
            Console.WriteLine(product.ProductId + " " + product.ProductName + " " + product.ProductPrize);

            Console.WriteLine("\n\n===========================Assignment 5=========================");
            Console.WriteLine("\n---------------------Students---------------------");

            Student students = new Student { StudentId = 1, StudentName = "Seema", StudentPercentage = 89.63 };
            Student students1 = new Student { StudentId = 2, StudentName = "Anjali", StudentPercentage = 93.53 };
            Student students2 = new Student { StudentId = 3, StudentName = "Prathiba", StudentPercentage = 76.19 };
            Student students3 = new Student { StudentId = 4, StudentName = "Hirkani", StudentPercentage = 67.95 };
            Student students4 = new Student { StudentId = 5, StudentName = "Joyti", StudentPercentage = 86.55 };

            Console.WriteLine(students.StudentId + " " + students.StudentName + " " + students.StudentPercentage);
            Console.WriteLine(students1.StudentId + " " + students1.StudentName + " " + students1.StudentPercentage);
            Console.WriteLine(students2.StudentId + " " + students2.StudentName + " " + students2.StudentPercentage);
            Console.WriteLine(students3.StudentId + " " + students3.StudentName + " " + students3.StudentPercentage);
            Console.WriteLine(students4.StudentId + " " + students4.StudentName + " " + students4.StudentPercentage);


            Console.WriteLine("\n\n===========================Assignment 6=========================");
            Console.WriteLine("\n---------------------Product Discount---------------------");
            Product1 prod = new Product1();
            prod.discount();
            Console.WriteLine(prod);

            Console.ReadLine();



        }
    }
}
