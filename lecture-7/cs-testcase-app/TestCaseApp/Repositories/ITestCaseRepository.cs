using TestCaseApp.Models;

namespace TestCaseApp.Repositories;

public interface ITestCaseRepository
{
    TestCase? TryAdd(TestCase testCase);
    IReadOnlyList<TestCase> GetAll();

}