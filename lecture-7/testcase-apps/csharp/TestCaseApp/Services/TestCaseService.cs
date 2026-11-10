using TestCaseApp.Models;
using TestCaseApp.Repositories;

namespace TestCaseApp.Services;

public class TestCaseService(TestCaseRepository repository)
{
    public TestCaseResult Create(CreateTestCase createTestCase)
    {
        var title = createTestCase.Title.Trim();
        var purpose = createTestCase.Purpose.Trim();
        var expectedResult = createTestCase.ExpectedResult.Trim();

        if (string.IsNullOrWhiteSpace(title))
            return new TestCaseResult(false, "title is required.", []);

        if (string.IsNullOrWhiteSpace(purpose))
            return new TestCaseResult(false, "purpose is required.", []);

        if (string.IsNullOrWhiteSpace(expectedResult))
            return new TestCaseResult(false, "expected result is required.", []);

        var testCase = new TestCase
            (
                Guid.NewGuid(),
                title,
                purpose,
                expectedResult
            );

        var result = repository.TryAdd(testCase);

        return result
            ? new TestCaseResult(true, "Test case added", [testCase])
            : new TestCaseResult(false, "Unable to add test case", []);
    }

    public TestCaseResult GetAll()
    {
        var cases = repository.GetAll();
        return new TestCaseResult(true, null, cases);
    }
}
