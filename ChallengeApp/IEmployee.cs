

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surame { get; }
        Statistics GetStatistics();
    }
}
