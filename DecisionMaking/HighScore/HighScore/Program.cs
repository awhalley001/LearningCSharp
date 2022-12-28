using System;

namespace HighScore
{
    internal class Program
    {
        private static string highScorePlayer = "TurFold";
        private static int highScore = 100;
        public static void Main(string[] args)
        {
            string playerName = "HarryA";
            int playerHighScore = 1000;

            HiScore(playerName, playerHighScore);
            

            Console.Read();

        }

        public static void HiScore(string username, int score)
        {
            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = username;
                Console.WriteLine($"New highscore is {highScore}");
                Console.WriteLine($"New highscore player is {highScorePlayer}");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highScore} could not be broken is is still held by {highScorePlayer}");
            }
            
        }
    }
}