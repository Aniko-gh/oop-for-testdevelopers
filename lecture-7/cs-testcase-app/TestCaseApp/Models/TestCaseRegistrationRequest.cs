namespace TestCaseApp.Models;

public record TestCaseRegistrationRequest
(
    string Name,
    string Purpose,
    string Preconditions,
    string TestData,
    string Steps,
    string ExpectedResult
);