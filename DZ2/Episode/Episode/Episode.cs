using System;
using DescriptionClass;

namespace EpisodeClass
{
    public class Episode
    {
        private int viewerCount;
        private double averageScore { get; set; }
        private double maxScore { get; set; }
        private Description description { get; set; }

        public int GetViewerCount() { return viewerCount; }
        public double GetAverageScore() { return maxScore/viewerCount; }
        public double GetMaxScore() { return maxScore; }
        public Description GetDescription() { return description; }


        public Episode()
        {
            averageScore = 0;
            maxScore = 0;
        }

        public Episode(int ViewerCount,  double MaxScore, double AverageScore, Description Description)
        {
            viewerCount = ViewerCount;
            averageScore = AverageScore;
            maxScore = MaxScore;
            description = Description;
        }

        public void AddView(double Score)
        {
            viewerCount++;
            averageScore += Score;

            if (Score > maxScore)
            {
                maxScore = Score;
            }

        }

        public static bool operator <(Episode ep1, Episode ep2)
        {
            return (ep1.averageScore < ep2.averageScore);
        }

        public static bool operator >(Episode ep1, Episode ep2)
        {
            return !(ep1.averageScore < ep2.averageScore);
        }
    }
}
