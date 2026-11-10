using TestCaseApp.Models;

namespace TestCaseApp.Repositories;

public class InMemoryTestCaseRepository : ITestCaseRepository
{
    private readonly List<TestCase> _testCases = [];

    public IReadOnlyList<TestCase> GetAll()
    {
        return _testCases;
    }

    public TestCase? TryAdd(TestCase testCase)
    {
        _testCases.Add(testCase);
        return testCase;
    }
}