namespace TestCaseApp.Models;

public record TestCaseResult
(
    bool Succeeded,
    string? Message,
    IReadOnlyList<TestCase> Result
);