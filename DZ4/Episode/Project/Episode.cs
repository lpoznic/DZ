using System;
using DescriptionClass;

namespace EpisodeClass
{
    public class Episode
    {
        private int viewerCount;
        private double sumScore { get; set; }
        private double maxScore { get; set; }
        private Description description { get; set; }


        public Episode()
        {
            sumScore = 0;
            maxScore = 0;
        }

        public Episode(int ViewerCount, double SumScore, double MaxScore, Description Description)
        {
            viewerCount = ViewerCount;
            sumScore = SumScore;
            maxScore = MaxScore;
            description = Description;
        }

        public Episode(Episode copy)
        {
            this.viewerCount = copy.viewerCount;
            this.sumScore = copy.sumScore;
            this.maxScore = copy.maxScore;
            this.description = new Description(copy.description);
        }

        public int GetViewerCount() { return viewerCount; }
        public double GetSumScore() { return sumScore; }
        public double GetAverageScore() { return sumScore / viewerCount; }
        public double GetMaxScore() { return maxScore; }
        public Description GetDescription() { return description; }


        public void AddView(double Score)
        {
            viewerCount++;
            sumScore += Score;

            if (Score > maxScore)
            {
                maxScore = Score;
            }

        }

        public override string ToString()
        {
            return $"{viewerCount},{sumScore},{maxScore},{description.GetEpisodeNumber()},{description.GetEpisodeLenght()},{description.GetEpisodeName()}";
        }

        public static bool operator <(Episode ep1, Episode ep2)
        {
            return ep1.sumScore < ep2.sumScore;
        }

        public static bool operator >(Episode ep1, Episode ep2)
        {
            return !(ep1.sumScore < ep2.sumScore);
        }
    }
}
