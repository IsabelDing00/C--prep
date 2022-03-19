using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assign03
{
    public static class DesignClasses
    {
        public static void Mian(string[] args)
        {

        }
    }

    public abstract class Person
    {
        public Person(int age, decimal salary)
        {
            this.age = age;

            // Salary cannot be negative number
            if (salary > 0)
            {
                this.salary = salary;
            }
            else
            {
                this.salary = 0;
            }
            this.addresses = new ArrayList();
        }

        //Calculate Age of the Person
        private int age;
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        //Calculate the Salary of the person, Use decimal for salary
        private decimal salary;
        public decimal Salary
        {
            get { return salary; } 
            set { salary = value; } 
        }

        // Can have multiple Addresses, should have method to get addresses
        private ArrayList addresses;
        public ArrayList getAddresses()
        {
            return this.addresses; 
        }

        public virtual void addBouns(DateTime year) { }

        public virtual void calGPA(int grade) { }
        
    }

    //Will have list of enrolled students
    public class Course
    {
        public ArrayList students;
    }

    public class Department
    {
        //Will have one Instructor as head
        public bool isHead;

        //Will have Budget for school year (start and end Date Time)
        public decimal budget;

        //Will offer list of courses
        public ArrayList students;

    }
    public class Instructor : Person
    {
        public Instructor()
        {

            //Belongs to one Department and he can be Head of the Department
            //Instructor will have added bonus salary based on his experience, calculate his years of experience based on Join Date
            /*this.dep = dep;
            this.isHead = isHead;
            this.date = date;*/

        }
       
        public Department dep { get;set; }
        public bool isHead { get;set; }
        public DateTime date { get;set; }

        
        public override void addBouns(DateTime date)
        {
            DateTime today = DateTime.Now;
            int year = today.Year - date.Year;

            Console.WriteLine($"This person has stayed {year} years");
        }
    }



}
