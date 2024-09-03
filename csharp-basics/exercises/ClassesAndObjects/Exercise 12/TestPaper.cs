using System;

namespace Excercise12
{
    public class Testpaper : ITestpaper
    {
        public string Subject { get; private set; }
        public string[] MarkScheme { get; private set; }
        public string PassMark { get; private set; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }
}