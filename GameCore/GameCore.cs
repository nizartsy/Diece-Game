using System;
using System.Collections.Generic;
using System.Linq;

namespace GameCore
{
    public class GameCore
    {
        private static List<Reward> liReward;

        public GameCore()
        {
            liReward = new List<Reward>();
            liReward = Util.Helper.GetScoreData();
        }

        #region Enum Field
        public class Reward
        {
            public int Number { get; set; }
            public int Times { get; set; }
            public int Score { get; set; }
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
        public int TotalScore { get; set; }
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
                if (Combinations != null && Combinations.Length > 0)
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
                    int number = distinctElement[i];
                    combinationElement = Combinations.Where(val => val.Equals(number)).ToArray();
                    itemScore = CalculateReward(number, combinationElement);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return itemScore;
        }

        private int CalculateReward(int Number, int[] combinationArray)
        {
            var itemLength = combinationArray.Length;
            if (liReward.Select(i => i.Number.Equals(Number)).Count() > 0)
            {
                var shrtList = (from item in liReward
                                where item.Number.Equals(Number)
                                orderby item.Times descending
                                select item).ToList<Reward>();

                foreach (var item in shrtList)
                {

                    if (item.Times < itemLength)
                    {
                        TotalScore += item.Score;
                        itemLength -= item.Times;
                    }
                    if (item.Times.Equals(itemLength))
                    {
                        TotalScore += item.Score;
                        itemLength -= item.Times;
                    }
                }
            }
            return TotalScore;
        }


        #endregion
    }
}
