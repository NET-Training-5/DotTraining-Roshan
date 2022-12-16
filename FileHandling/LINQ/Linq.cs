using System.Collections.Generic;
using System.Linq;

class Linq
{
    int[] numnber = {12,32,213,65,790,9,643,2,56,8709,432,4,570,90,79,40};

   public void LearnToQuery()
        {
            //finding even number in array
            var evennumber = numnber.Where(x=> x%2 == 0);

            //finding odd number
            var oddnumber = numnber.Where(x=> x %2  != 0); 


            //List multiples of 5 and 7 from "numbers"

            var muntipleOF = numnber.Where(x => x%5==0 && x%7==0);

            //List all items less than 100 and ends with 0, from "numbers"

            var item = numnber.Where(x=> x%10==0);

        }

    
    

}