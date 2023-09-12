﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day7
{
    class Student
    {
        //declaring private fields of the class
        private string code = "N.A.";
        private string _Name = "Unknown";
        private int Age = 0;

        //declare properties for the code field
        public string Code
        {
            get {
                return code ;}
            set {
                code = value;
            }
        }

        //declare properties for the _Name field
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        //declare properties for the Age field
        public int Years
        {
            get
            {
                return Age;
            }
            set
            {
                if(value<=20)
                Age = 21;
            }
        }

    }
    class Properties_Eg
    {
        static void Main()
        {
            //create a student object
            Student student = new Student();

            //get accessors are called
            Console.WriteLine($"Initial Code {student.Code}, Initial Name {student.Name} and Initial Age {student.Years}");
           
            //set accessors are called            
            student.Code = "S100";  
            student.Name = "Shahbaz";
            student.Years = 16;
            Console.WriteLine("After Changes thru Properties");
            Console.WriteLine($"Changed Code {student.Code}, Changed Name {student.Name} and Changed Age {student.Years}");
            Console.ReadKey();
        }
    }
}
