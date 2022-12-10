using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Pracrice
{
    internal class Movie
    {
        public string name;
        public string director;
        private string rating;


        public Movie(string aname, string adirector, string arating)
        {
            name = aname;

            director = adirector;

            Rating = arating;
        }



        public string Rating
        {
            get { return rating; }
            set {
                if(value == "G" || value =="PG" || value == "PG-13")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}

