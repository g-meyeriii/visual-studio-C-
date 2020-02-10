using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject {
    class Student {//==========================================================================================
        //Properties
        public int Id;
        public string Firstname;
        public string Lastname;
        public int SAT;
        public double GPA;
        public Major Major;

        //Constructor
        public Student(int Id, string firstname, string lastname, int sat, double gpa, Major major) {
            Firstname = firstname;
            Lastname = lastname;
            SAT = sat;
            GPA = gpa;
            Major = major;
            }
        //Method
        public void print() {
            Console.WriteLine($"Id={Id},Firstname={Firstname}, Lastname={Lastname}, SAT ={SAT},GPA={GPA},Major={Major.Description},"+
                $", MinSat Requried = {Major.MinSat}");
            }






        }//===================================================================================================
    }
