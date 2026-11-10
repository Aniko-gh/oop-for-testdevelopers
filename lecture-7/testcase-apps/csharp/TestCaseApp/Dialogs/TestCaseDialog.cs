using TestCaseApp.Models;
using TestCaseApp.Services;

namespace TestCaseApp.Dialogs;

public class TestCaseDialog(TestCaseService service)
{
    public void AddDialog()
    {
        Console.Clear();
        Console.WriteLine("#### NEW TEST CASE ####");

        Console.Write("Enter Title: ");
        var title = Console.ReadLine() ?? "";

        Console.Write("Enter Purpose: ");
        var purpose = Console.ReadLine() ?? "";

        Console.Write("Enter Expected Result: ");
        var expectedResult = Console.ReadLine() ?? "";

        var createTestCase = new CreateTestCase(title, purpose, expectedResult);

        var result = service.Create(createTestCase);

        Console.WriteLine("");
        Console.WriteLine(result.Message);

        if (result.Succeeded && result.Result.Count > 0)
        {
            var testCase = result.Result[0];

            if (testCase != null)
                Console.WriteLine($"Test Case ID '{testCase.Id}'.");
        }

        Console.ReadKey();
    }

    public void ListDialog()
    {
        Console.Clear();
        Console.WriteLine("#### VIEW TEST CASES ####");

        var result = service.GetAll();

        var cases = result.Result;

        if (cases != null)
        {
            foreach (var c in cases)
            {
                Console.WriteLine($"Id: {c.Id}");
                Console.WriteLine($"Title: {c.Title}");
                Console.WriteLine($"Purpose: {c.Purpose}");
                Console.WriteLine($"Expected Result: {c.ExpectedResult}");
                Console.WriteLine("");
            }
        }

        Console.ReadKey();
    }

    public void MenuDialog()
    {
        Console.Clear();

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("#### TEST CASE MANAGEMENT ####");
            Console.WriteLine("1. New Test Case");
            Console.WriteLine("2. View Test Cases");
            Console.WriteLine("0. Exit");
            Console.Write("Select Option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddDialog();
                    break;

                case "2":
                    ListDialog();
                    break;

                case "0":
                case null:
                    return;

                default:
                    Console.WriteLine("Select a valid menu option.");
                    break;
            }

            Console.Clear();
        }
    }
}
