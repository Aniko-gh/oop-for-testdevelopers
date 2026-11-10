using TestCaseApp.Models;

namespace TestCaseApp.Services;

public interface ITestCaseService
{
    RegistrationResult RegisterTestCase(TestCaseRegistrationRequest request);
    IReadOnlyList<TestCase> GetAllTestCases();
}
