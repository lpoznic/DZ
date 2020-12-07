using System;
using System.Collections.Generic;
using System.Text;
using EpisodeClass;

namespace SeasonClass
{

    public class Season
    {
        public int seasonNum { get; set; }
        public Episode[] episodes { get; private set; }
        public int Length { get; private set; }

    public Season(int seasonNum, Episode[] episodes)
        {
            this.seasonNum = seasonNum;
            this.episodes = episodes;
            Length = episodes.Length;
        }

    public Episode this[int i]
        {
            get { return episodes[i]; }
            set { this.episodes[i] = value; }
        }

        

        public TimeSpan GetTotalDuration()
        {
            TimeSpan totalDuration = TimeSpan.Zero;

            foreach(Episode episode in episodes)
            {
                totalDuration += episode.GetDescription().GetEpisodeLenght();
            }

            return totalDuration;
        }

        public int GetTotalViewers()
        {
            int totalViews = 0;

            foreach (Episode episode in episodes)
            {
                totalViews += episode.GetViewerCount();
            }

            return totalViews;
        }


        public override string ToString()
        {
            string text = "";
            text += $"Season {seasonNum}:\n" +
                "===========================================\n";

            foreach (Episode episode in episodes)
            {
                text += $"{episode.ToString()}\n";
            }

            text += "Report:\n" +
                "===========================================\n" +
                $"Total viewers: {GetTotalViewers()}\n" +
                $"Total duration: {GetTotalDuration()}\n" +
                "===========================================\n";

            return text;

        }
    }

}
        


    

