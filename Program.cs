using System;

namespace c_sharp_odev_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student();
            student.FirstName = "John";
            student.LastName = "Doe";
            student.Number = 110;
            student.StudentClass = 3;

            student.PrintStudentInformation();

            student.IncreaseStudentClass();
            student.PrintStudentInformation();


            Student student2 = new Student("Legolas", "Mirkwood", 111, 1);
            student2.DecreaseStudentClass();
            student2.DecreaseStudentClass();
            student2.PrintStudentInformation();






        }
    }





    class Student
    {

        private string firstName;
        private string lastName;
        private int number;
        private int studentClass;

        public string FirstName { 
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName { get => lastName; set => lastName = value; }
        public int Number { get => number; set => number = value; }
        public int StudentClass { 
            get => studentClass; 
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("1 is minimum value");
                    studentClass = 1;
                }
                else
                {
                    studentClass = value;
                }
            }
        }


        public Student()
        {

        }

        public Student(string firstName, string lastName, int number, int studentClass)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            StudentClass = studentClass;

        }


        public void PrintStudentInformation()
        {
            Console.WriteLine($"Student Name: {firstName} {lastName}");
            Console.WriteLine($"Student Number: {number}");
            Console.WriteLine($"Student Class: {studentClass}");
        }

        public void IncreaseStudentClass()
        {
            this.StudentClass = this.StudentClass + 1;
        }

        public void DecreaseStudentClass()
        {
            this.StudentClass = this.StudentClass - 1;
        }






    }




}
