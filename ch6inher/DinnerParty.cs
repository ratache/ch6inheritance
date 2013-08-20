using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6inher
{
    class DinnerParty:Party
    {
        //Variables
        private decimal CostOfBeveragesPerPerson;

        //Flags
        private bool healthyFlag;

        public DinnerParty(int numOp, bool dflag, bool hflag):base(numOp, hflag)
        {
            this.numberOfPeople = numOp;
            this.fancyDecor = dflag;
        }

        private void HealthyOption(bool hflag)
        {
            healthyFlag = hflag;

            if (!healthyFlag)
            { CostOfBeveragesPerPerson = 5.00M ; }
            else
            { CostOfBeveragesPerPerson = 20.00M;}
        }

        /// <summary>
        /// Dinnerparty public method
        /// Requires number of participants, healthy option, decorations level values to operate.
        /// </summary>
        /// <param name="numberOfPeople">Int value</param>
        /// <param name="hflag">Bool Healthy option flag</param>
        /// <param name="dflag">Bool Fancy decorations</param>
        /// <returns></returns>
        public decimal CalculateCost(int numberOfPeople, bool hflag, bool dflag)
        {
            this.numberOfPeople = numberOfPeople;
            HealthyOption(hflag);
            CalculateCostofDecor(dflag);

            decimal Total = costOfDecor + ((CostOfBeveragesPerPerson + costOfFoodPerPerson) * numberOfPeople);

            if (numberOfPeople > 11)
                Total += 100M;

            if (healthyFlag)
                return Total * .95M;
            else
                return Total;
        }
    }
}
