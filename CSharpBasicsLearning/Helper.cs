namespace CSharpBasicsLearning
{
    public class Helper
    {
        public (int day, int month, string name) Test()
        {
            return (1, 2, "vishnu");
        }

        public int GetYearFromDate(ReadOnlySpan<char> dateString)
        {
            dateString.Slice(0, 4);
            return int.Parse(dateString.Slice(4));
        }

    }
}
