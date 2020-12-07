using System;
using EpisodeClass;
using DescriptionClass;
using System.IO;

namespace TVUtilities
{
    public class TvUtilities
    {
        public static double GenerateRandomScore()
        {
            Random r = new Random();
            double genRand = r.Next(0, 10);
            return genRand;
        }

        public static void Sort(Episode[] a)
        {
            int i, j, n = a.Length;
            Episode aux;
            for (i = 0; i < n - 1; i++)
                for (j = 0; j < n - 1 - i; j++)
                    if (a[j] < a[j+1])
                    {
                        aux = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = aux;
                    }
        }

        public static Episode[] LoadEpisodesFromFile(string fileName)
        {
            string[] episodesInputs = File.ReadAllLines(fileName);
            Episode[] episodes = new Episode[episodesInputs.Length];

            using(StreamReader sr = new StreamReader(fileName))
            {
                int i = 0;
                string episode;

                while((episode = sr.ReadLine())!= null)
                {
                    episodes[i] = Parse(episode);
                    i++;
                }
            }

            return episodes;
        }

        public static Episode Parse(string input)
        {
            Description desc = new Description(int.Parse(input.Split(',')[3]),TimeSpan.Parse(input.Split(',')[4]),input.Split(',')[5]);
            return new Episode(int.Parse(input.Split(',')[0]),double.Parse(input.Split(',')[1]),double.Parse(input.Split(',')[2]),desc);
        }

        
    }
}
