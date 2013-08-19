using System;


public class Party
{
    //Class variables
    internal decimal costOfDecor;
    internal int numberOfPeople;

    //Constants
    internal const int costOfFoodPerPerson = 25;

    //Flags
    internal bool fancyDecor;

    /// <summary>
    /// Calculates the cost of the decor depending on decor option and attendees. There is also
    /// a cost constant added (50 or 30).
    /// </summary>
    /// <param name="isitFancy">bool</param>
    public void CalculateCostofDecor(bool isitFancy)
    {
        fancyDecor = isitFancy;
        if (fancyDecor)
            costOfDecor = (numberOfPeople * 15.00M) + 50M;
        else
            costOfDecor = (numberOfPeople * 7.50M) + 30M;
    }
}
