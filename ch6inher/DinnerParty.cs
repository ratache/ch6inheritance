using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6inher
{
    class DinnerParty
    {
        //Variables
        private int NumberOfPeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;
        //Constants
        private const int CostOfFoodPerPerson = 25;
        //Flags
        private bool healthyFlag;
        private bool decorationFlag;

        public DinnerParty(int NumberOfPeople, bool dflag, bool hflag)
        {
            this.NumberOfPeople = NumberOfPeople;
            this.healthyFlag = hflag;
            this.decorationFlag = dflag;
        }

        /// <summary>
        /// Methods
        /// </summary>
        private void CalculateCostOfDecorations(bool dflag)
        {
            decorationFlag = dflag;

            if (decorationFlag)
            { CostOfDecorations = (NumberOfPeople * 15M) + 50M; }
            else
            { CostOfDecorations = (NumberOfPeople * 7.5M) + 30M; }
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
            this.NumberOfPeople = numberOfPeople;
            HealthyOption(hflag);
            CalculateCostOfDecorations(dflag);

            decimal Total = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (numberOfPeople > 11)
                Total += 100M;

            if (healthyFlag)
                return Total * .95M;
            else
                return Total;
        }
    }
}
