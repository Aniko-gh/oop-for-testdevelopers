namespace TestCaseApp.Models;

public record TestCase
(
    string TestCaseId,
    string Name,
    string Purpose,
    string Preconditions,
    string TestData,
    string Steps,
    string ExpectedResult
)
{
    public Guid Id { get; } = Guid.NewGuid();
}
