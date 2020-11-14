using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static GameCore.GameCore;

namespace GameCore.Util
{
    class Helper
    {
        private static List<Reward> Rewards;
        private const string filePath = @"E:\GreedGame\GreedGame\GameCore\Configuration\Config.json";

        public static List<Reward> GetScoreData()
        {
            try
            {
                return GetConfigValue(Rewards);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static List<Reward> GetConfigValue(List<Reward> liRewards)
        {
            try
            {
                if (File.Exists(filePath))
                    liRewards = JsonConvert.DeserializeObject<List<Reward>>(File.ReadAllText(filePath));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return liRewards;
        }
    }
}
