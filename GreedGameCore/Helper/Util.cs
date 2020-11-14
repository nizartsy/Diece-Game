using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using static GreedGameCore.GreedGame;

namespace GreedGameCore.Helper
{
    class Util
    {
        private static XDocument xmlDocument;
        private static List<Reward> Rewards;
        private const string filePath = @"E:\GreedGame\GreedGame\GreedGameCore\Configuration\Config.xml";

        public static List<Reward> GetScoreData()
        {
            if(File)
            xmlDocument = XDocument.Load(filePath);
            

            return GetDefaultScore();

        }
        private static List<Reward> GetDefaultScore()
        {
            Rewards = new List<Reward>();
            Rewards.Add(new Reward() { Number = 1, Times = 1, Score = 100 });
            Rewards.Add(new Reward() { Number = 1, Times = 3, Score = 1000 });
            Rewards.Add(new Reward() { Number = 2, Times = 3, Score = 200 });
            Rewards.Add(new Reward() { Number = 3, Times = 3, Score = 300 });
            Rewards.Add(new Reward() { Number = 4, Times = 3, Score = 400 });
            Rewards.Add(new Reward() { Number = 5, Times = 1, Score = 50 });
            Rewards.Add(new Reward() { Number = 5, Times = 3, Score = 500 });
            Rewards.Add(new Reward() { Number = 6, Times = 3, Score = 600 });
            Rewards.Add(new Reward() { Number = 0, Times = 0, Score = 0});
            
            return Rewards;
        }
    }
}
