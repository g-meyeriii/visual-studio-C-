using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject {
    class Major {
        //Properties
        public string Description;
        public int Id;
        public int MinSat;           
            
        //Constructor
        public Major(int id, int minsat, string description) {
            Description = description;
            Id = id;
            MinSat = minsat;

        }

        //Method
        public void Print () {

         Console.WriteLine($" Id={Id},Desc = {Description}, Min= {MinSat}");

            }

        }
    }
