using System.Text;
using System.Threading.Tasks;

namespace Excercise12
{
    public interface ITestpaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }

        public interface IStudent
        {
            string[] TestsTaken { get; }
            void TakeTest(ITestpaper paper, string[] answers);
        }
    }
}