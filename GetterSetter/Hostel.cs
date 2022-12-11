using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracrice
{
    internal class Hostel
    {

        public string Name;
        private int Capacity;
        private string type;

        public string location;


        public Hostel(string aName, int aCapacity, string alocation)
        {

            Name = aName;
            studentsCapacity = aCapacity;
            location = alocation;
        }

        public int studentsCapacity
        {
            get { return Capacity; }
            set 
            { 
                if (value < 50 && value >0)
                {
                    Capacity = value;
                }
                else
                {
                    Capacity = 0;
                }

            }
        }


                public string Type
        {
            get { return type; }

            set
            {
                if (value == "Boys" || value == "Girls")
                {
                    type = value;   
                }

                else
                {
                    type = "not valid";
                }
            }
        }




    }
}


