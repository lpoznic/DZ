using System;

namespace DescriptionClass
{
    public class Description
    {
        private int episodeNumber;
        private TimeSpan episodeLenght;
        private string episodeName;

        public Description(int EpisodeNumber, TimeSpan EpisodeLenght, string EpisodeName)
        {
            episodeNumber = EpisodeNumber;
            episodeName = EpisodeName;
            episodeLenght = EpisodeLenght;
        }

        public Description()
        {
            episodeNumber = 0;
            episodeName = "0";
            episodeLenght = TimeSpan.FromMinutes(0);
        }



        
    }

    
}


