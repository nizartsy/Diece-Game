using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedGameCore
{
    public class GreedGame
    {
        #region Enum Field
        public enum Score
        {
            SingleOne = 100,
            SingleFive = 50,
            TrippleOne = 1000,
            TrippleTwo = 200,
            TrippleThree = 300,
            TrippleFour = 400,
            TrippleFive = 500,
            TrippleSix = 600,
            ZeroScore = 0
        }
        #endregion
        #region Properties
        /// <summary>
        /// Insert combinations to Array
        /// </summary>
        public int[] Combinations { get; set; }
        /// <summary>
        /// Total Score of Combination
        /// </summary>
        public int TotalScore { get; set;}
        #endregion
        #region OperationSection
        /// <summary>
        /// Calculate the Score
        /// </summary>
        /// <returns></returns>
        public int CalculateScore()
        {
            TotalScore = 0;
            try
            {
                if (Combinations!=null && Combinations.Length > 0)
                {
                    TotalScore = calculateCombinationValue();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return TotalScore;
        }
        /// <summary>
        /// Calculating the Combinational Sum and Returns, Fecth the distinct values from an array.
        /// and calculat the combination and return its su
        /// </summary>
        /// <returns></returns>
        private int calculateCombinationValue()
        {
            int[] distinctElement = Combinations.Distinct().ToArray();
            int itemScore = 0;
            int[] combinationElement = null;

            try
            {
                for (int i = 0; i < distinctElement.Count(); i++)
                {

                    switch (distinctElement[i])
                    {
                        case 1:
                            combinationElement = Combinations.Where(val => val == 1).ToArray();
                            if (combinationElement.Length > 3)
                                itemScore += Convert.ToInt32(Score.TrippleOne) + ((combinationElement.Length - 3) * (Convert.ToInt32(Score.SingleOne)));
                            else if (combinationElement.Length == 3)
                                itemScore += Convert.ToInt32(Score.TrippleOne);
                            else
                                itemScore += combinationElement.Length * Convert.ToInt32(Score.SingleOne);
                            break;
                        case 2:
                            combinationElement = Combinations.Where(val => val == 2).ToArray();
                            if (combinationElement.Length > 2)
                                itemScore += Convert.ToInt32(Score.TrippleTwo);
                            break;
                        case 3:
                            combinationElement = Combinations.Where(val => val == 3).ToArray();
                            if (combinationElement.Length > 2)
                                itemScore += Convert.ToInt32(Score.TrippleThree);
                            break;
                        case 4:
                            combinationElement = Combinations.Where(val => val == 4).ToArray();
                            if (combinationElement.Length > 2)
                                itemScore += Convert.ToInt32(Score.TrippleFour);
                            break;
                        case 5:
                            combinationElement = Combinations.Where(val => val == 5).ToArray();
                            if (combinationElement.Length > 3)
                                itemScore += Convert.ToInt32(Score.TrippleFive) + ((combinationElement.Length - 3) * (Convert.ToInt32(Score.SingleFive)));
                            else if (combinationElement.Length == 3)
                                itemScore += Convert.ToInt32(Score.TrippleFive);
                            else
                                itemScore += combinationElement.Length * Convert.ToInt32(Score.SingleFive);
                            break;
                        case 6:
                            combinationElement = Combinations.Where(val => val == 6).ToArray();
                            if (combinationElement.Length > 2)
                                itemScore += Convert.ToInt32(Score.TrippleSix);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return itemScore;
        }
        #endregion
    }
}
