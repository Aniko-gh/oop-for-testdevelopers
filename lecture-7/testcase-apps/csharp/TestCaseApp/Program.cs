using TestCaseApp.Repositories;
using TestCaseApp.Services;
using TestCaseApp.Dialogs;

var repository = new TestCaseRepository();
var service = new TestCaseService(repository);
var dialog = new TestCaseDialog(service);

dialog.MenuDialog();