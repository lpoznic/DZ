using EpisodeClass;
using System;
using System.Collections;
using System.Collections.Generic;
using TVUtilities;

namespace SeasonClass
{
    public class Season : IEnumerable<Episode>
    {
        public int seasonNum { get; set; }
        public List<Episode> episodes { get; private set; }
        public int Length { get; private set; }

        public Season(int SeasonNum, List<Episode> Episodes)
        {
            this.seasonNum = SeasonNum;
            this.episodes = Episodes;
            Length = episodes.Count;
        }

        public Season(Season season)
        {
            this.episodes = new List<Episode>();
            foreach(var episode in season)
            {
                episodes.Add(new Episode(episode));
            }
            this.seasonNum = season.seasonNum;
            this.Length = season.Length;
        }

        public Episode this[int i]
        {
            get { return episodes[i]; }
            set { this.episodes[i] = value; }
        }



        public TimeSpan GetTotalDuration()
        {
            TimeSpan totalDuration = TimeSpan.Zero;

            foreach (Episode episode in episodes)
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

        

        public void Remove(string episodeName)
        {
            int i;
            for(i=0;i<episodes.Count;i++) {
                if(episodeName==episodes[i].GetDescription().episodeName)
                {
                    episodes.RemoveAt(i);
                    return;
                }
                throw new TvException("No such episode found.", episodeName);
            }
        }

        public IEnumerator<Episode> GetEnumerator()
        {
            return ((IEnumerable<Episode>)episodes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Episode>)episodes).GetEnumerator();
        }
    }

}
        


    

