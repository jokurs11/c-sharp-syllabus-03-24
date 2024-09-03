using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Excercise12.ITestpaper;

namespace Excercise12
{
    public class Student : IStudent
    {
        private List<string> testsTaken = new List<string>();

        public Student()
        {
            testsTaken = new List<string>();
        }

        public string[] TestsTaken
        {
            get
            {
                if (testsTaken.Count > 0)
                {
                    return testsTaken.ToArray();
                }
                else
                {
                    return new string[] { "No tests taken" };
                }
            }
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            int correctAnswers = 0;

            for (int i = 0; i < paper.MarkScheme.Length; i++)
            {
                if (i < answers.Length && paper.MarkScheme[i] == answers[i])
                {
                    correctAnswers++;
                }
            }

            double percentageScore = (double)correctAnswers / paper.MarkScheme.Length * 100;
            string result;

            if (percentageScore >= ConvertToPercentage(paper.PassMark))
            {
                result = "Passed";
            }
            else
            {
                result = "Failed";
            }

            testsTaken.Add($"{paper.Subject}: {result}! ({percentageScore:0}%)");
        }
        private double ConvertToPercentage(string passMark)
        {
            return double.Parse(passMark.TrimEnd('%'));
        }
    }
}