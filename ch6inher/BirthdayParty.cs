using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch6inher
{
    class BirthdayParty
    {
        public const int costOfFoodPerPerson = 25;//price constant
        public decimal costOfDecorations = 0;//the cost of the decor
        public int cakeSize;//size of cake depending on attendees

        private bool fancyDecorations;//the option for fancy decor

        public BirthdayParty(int NumberOfPeople, bool FancyDecor, string CakeWriting)
        {
            this.numberOfPeople = NumberOfPeople;
            CalcCakeSize();
            this.cakeWriting = CakeWriting;
            CalculateCostofDecor(fancyDecorations);
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
        public decimal CalculateCost()
        {
            decimal totalCost = costOfDecorations + (costOfFoodPerPerson * numberOfPeople);
            decimal cakeCost;

            if(cakeSize==8)
                cakeCost = 40M + cakeWriting.Length * 1.5M;
            else
                cakeCost = 75M + cakeWriting.Length * 1.5M;

            if (numberOfPeople > 11)
                totalCost += 100M;

            return totalCost + cakeCost;
        }

        /// <summary>
        /// Calculates the cost of the decor depending on decor option and attendees. There is also
        /// a cost constant added (50 or 30).
        /// </summary>
        /// <param name="isitFancy">bool</param>
        public void CalculateCostofDecor(bool isitFancy)
        {
            fancyDecorations = isitFancy;
            if (fancyDecorations)
                costOfDecorations = (numberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (numberOfPeople * 7.50M) + 30M;
        }

        //PROPERTIES
        private string cakeWriting = "";//what to be written on the cake
        private int numberOfPeople;//amount of attendees

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

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;

                CalculateCostofDecor(fancyDecorations);
                CalcCakeSize();
                this.CakeWriting = cakeWriting;//runs the cakewriting property
            }
        }
    }
}
