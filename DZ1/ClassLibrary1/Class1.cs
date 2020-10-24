using System;

namespace ClassLibrary1
{
    public class Episode
    {
        public int ViewerCount;
        public double AverageScore;
        public double MaxScore;

        public int GetViewerCount() { return ViewerCount; }
        public double GetAverageScore() { return AverageScore; }
        public double GetMaxScore() { return MaxScore; }


        public Episode()
        {
            ViewerCount = 0;
            AverageScore = 0;
            MaxScore = 0;
        }

        public Episode(int viewerCount, double averageScore, double maxScore)
        {
            this.ViewerCount = viewerCount;
            this.AverageScore = averageScore;
            this.MaxScore = maxScore;
        }

        public void AddView(double Score)
        {
            ViewerCount++;
            AverageScore += Score;

            if (Score > MaxScore)
            {
                MaxScore = Score;
            }

        }

    }

}
