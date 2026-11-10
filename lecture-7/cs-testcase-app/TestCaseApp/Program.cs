using TestCaseApp.Models;
using TestCaseApp.Repositories;
using TestCaseApp.Services;


ITestCaseRepository testCaseRepostory = new InMemoryTestCaseRepository();
var testCaseService = new TestCaseService(testCaseRepostory);

var testCaseRegistrationRequest = 
    new TestCaseRegistrationRequest
    (
        "Registrera kund med giltiga obligatoriska uppgifter",
        "Verifiera att en kund kan registeras när alla obligatoriska uppgifter är korrekt angivna.",
        "Testaren är inloggad med behörighet att registera kunder. Formuläret  \"Ny Kund\" är öppet. Ingen kund med testets e-postadress finns registrerad.",
        "Namn: Hans Mattin-Lassei. E-postadress: hans@domain.com",
        "inga",
        "Kunden ska registeras och visa rätt uppgifter."
    );

testCaseService.RegisterTestCase(testCaseRegistrationRequest);
