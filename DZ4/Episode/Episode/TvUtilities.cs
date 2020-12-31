using System;
using EpisodeClass;
using DescriptionClass;
using System.IO;

namespace TVUtilities
{
    public class TvUtilities
    {
        public static void Swap(Episode ep1, Episode ep2)
        {
            Episode t;
            t = ep1;
            ep1 = ep2;
            ep2 = t;
        }

        

        public static void Sort(Episode[] episodes)
        {
            int i, j;
            for (i = 0; i < episodes.Length - 2; i++)
            {
                for (j = 0; j < episodes.Length - 2; j++)
                {
                    if(episodes[i].GetAverageScore() < episodes[i + 1].GetAverageScore())
                    {
                        Swap(episodes[i + 1], episodes[i]);
                    }
                }
            }
        }

        static double GenerateRandomScore()
		{
			Random r = new Random();
			double genRand = r.Next(0, 10);
			return genRand;
		}

        public static Episode Parse(string input)
        {
            Description desc = new Description(int.Parse(input.Split(',')[3]), TimeSpan.Parse(input.Split(',')[4]), input.Split(',')[5]);
            return new Episode(int.Parse(input.Split(',')[0]), double.Parse(input.Split(',')[1]), double.Parse(input.Split(',')[2]), desc);
        }

        
    }
}
