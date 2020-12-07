using System;

namespace DescriptionClass
{
    public class Description
    {
        public int episodeNumber { get; set; }
        public TimeSpan episodeLenght { get; set; }
        public string episodeName { get; set; }

        public Description(int EpisodeNumber, TimeSpan EpisodeLenght, string EpisodeName)
        {
            episodeNumber = EpisodeNumber;
            episodeName = EpisodeName;
            episodeLenght = EpisodeLenght;
        }

        public int GetEpisodeNumber()
        {
            return episodeNumber;
        }

        public TimeSpan GetEpisodeLenght()
        {
            return episodeLenght;
        }

        public string GetEpisodeName()
        {
            return episodeName;
        }

        public override string ToString()
        {
            return $"{episodeNumber},{episodeLenght},{episodeName}";
        }




    }

    
}


