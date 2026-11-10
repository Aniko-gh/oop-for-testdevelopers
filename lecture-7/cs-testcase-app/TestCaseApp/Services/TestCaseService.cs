using TestCaseApp.Models;
using TestCaseApp.Repositories;

namespace TestCaseApp.Services;

public class TestCaseService(ITestCaseRepository repository) : ITestCaseService
{
    public IReadOnlyList<TestCase> GetAllTestCases()
    {
        var testCases = repository.GetAll();

        return [.. testCases.OrderBy(testCase => testCase.TestCaseId)];

    }

    public RegistrationResult RegisterTestCase(TestCaseRegistrationRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        var name = request.Name.Trim();
        var purpose = request.Purpose.Trim();
        var preconditions = request.Preconditions.Trim();
        var testData = request.TestData.Trim();
        var steps = request.Steps.Trim();
        var exprectedResult = request.ExpectedResult.Trim();

        if (string.IsNullOrWhiteSpace(name))
            return new RegistrationResult(false, "Du måste ange ett namn för testfallet.");

        if (string.IsNullOrWhiteSpace(purpose))
            return new RegistrationResult(false, "Du måste ange syfte med testfallet.");

        if (string.IsNullOrWhiteSpace(preconditions))
            return new RegistrationResult(false, "Du måste ange förutsättningar för testfallet.");

        if (string.IsNullOrWhiteSpace(testData))
            return new RegistrationResult(false, "Du måste ange testdata för testfallet.");

        if (string.IsNullOrWhiteSpace(steps))
            return new RegistrationResult(false, "Du måste ange olika test-steg för testfallet.");

        if (string.IsNullOrWhiteSpace(exprectedResult))
            return new RegistrationResult(false, "Du måste ange ett förväntat resultat för testfallet.");

        var testCase = new TestCase
        (
            "TC-001",
            name,
            purpose,
            preconditions,
            testData,
            steps,
            exprectedResult
        );

        var result = repository.TryAdd(testCase);

        return result is not null
            ? new RegistrationResult(true, "Registration succeeded")
            : new RegistrationResult(false, "Unable to register test case");

    }
}
