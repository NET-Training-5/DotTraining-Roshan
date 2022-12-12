using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracrice
{
     class footballPasal: sportsPasal
    {

        public footballPasal(int students, int rent, float expenditure)
        {
            Students = students;
            Rent = rent;
            Expenditure = expenditure;
        }


        public float GetIncome() => Students * Rent;
        public float GetProfit() => (Students * Rent) - Expenditure;

    }
}
