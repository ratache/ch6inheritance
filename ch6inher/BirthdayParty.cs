using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch6inher
{
    class BirthdayParty:Party
    {
        private int cakeSize;//size of cake depending on attendees

        public BirthdayParty(int NumberOfPeople, bool FancyDecor, string CakeWriting):base(NumberOfPeople, FancyDecor)
        {
            CalcCakeSize();
            CalculateCostofDecor(FancyDecor);
            this.cakeWriting = CakeWriting;
        }

        /// <summary>
        /// Sets cakesize
        /// </summary>
        private void CalcCakeSize()
        {
            if (numberOfPeople <= 4)
                cakeSize = 8;
            else
                cakeSize = 16;
        }

        /// <summary>
        /// The whole shebang, calculates the whole party cost.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateCost(int numbersValue)
        {
            this.numberOfPeople = numbersValue;

            decimal totalCost = costOfDecor + (costOfFoodPerPerson * numberOfPeople);
            decimal cakeCost;

            if(cakeSize==8)
                cakeCost = 40M + cakeWriting.Length * 1.5M;
            else
                cakeCost = 75M + cakeWriting.Length * 1.5M;

            if (numberOfPeople > 11)
                totalCost += 100M;

            return totalCost + cakeCost;
        }

        //PROPERTIES
        private string cakeWriting = "";//what to be written on the cake

        /// <summary>
        /// Property for the cakewriting process. Makes inserted
        /// cakewritingvalue fit the cake.
        /// </summary>
        public string CakeWriting
        {
            get { return cakeWriting; }
            set 
            {
                int maxLength;
                if (cakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters, this cakesize supports " + maxLength);
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;
            }
        }
    }
}
