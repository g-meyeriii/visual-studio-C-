using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {


            var majors = new Major[] { //Putting  values into a array instead of hard coding 
                
             new Major(100, 1000,"Accounting"),
             new Major(200, 1000, "Business"),
             new Major(300, 1200, "Enginering"),
             new Major(400, 1300, "Math"),
             new Major(500,1100,"Education")

            };
            //majors[0] = accounting;  no longer valid, the above input make them obsolete
            //majors[1] = business;
            //majors[2] = engineering;
            //majors[3] = math;
                       
             for (var idx = 0; idx < majors.Length; idx++) { 
                var major = majors[idx];
                major.Print();
                }
            //foreach(var idx in major){
            Major.Print();
            }

             var students = new Student[] {
                new Student(1, "Bill", "Smith", 900, 2.0, majors[0]),
                new Student(2, "Billy", "Bob", 1000, 2.8, majors[2]),
                new Student(3, "Jane", "Doe", 1200, 4.0, majors[1]),
                new Student(4, "Fred", "Flinstone", 600, 1.0, majors[1])
                };

            foreach(var student in students) {  //For each loop, updated for loop use when ever you can, easier. You can't make any changes to the variable in the foreach, for loop you can
                student.print();

                }











            //billsmith.print();
            //billybob.print();
            //janedoe.print();

            }
        }
    }
