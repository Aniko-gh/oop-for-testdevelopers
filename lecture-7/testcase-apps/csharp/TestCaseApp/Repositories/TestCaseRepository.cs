using TestCaseApp.Models;

namespace TestCaseApp.Repositories;

public class TestCaseRepository
{
    private readonly List<TestCase> _cases = [];

    public bool TryAdd(TestCase testCase)
    {
        ArgumentNullException.ThrowIfNull(testCase);

        _cases.Add(testCase);

        return true;
    }

    public IReadOnlyList<TestCase> GetAll()
    {
        return _cases;
    }
}
