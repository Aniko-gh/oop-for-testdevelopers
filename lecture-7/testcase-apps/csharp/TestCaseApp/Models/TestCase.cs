namespace TestCaseApp.Models;

public class TestCase(Guid id, string title, string purpose, string expectedResult)
{
    public Guid Id { get; set; } = id;
    public string Title { get; set; } = title;
    public string Purpose { get; set; } = purpose;
    public string ExpectedResult { get; set; } = expectedResult;
}
