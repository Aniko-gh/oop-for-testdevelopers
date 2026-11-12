from repositories.customer_repository import CustomerRepository
from services.customer_service import CustomerService
from dialogs.customer_dialog import CustomerDialog

customer_repository = CustomerRepository()
customer_service = CustomerService(customer_repository)
customer_dialog = CustomerDialog(customer_service)


def main() -> None:
    customer_dialog.show_menu()


if __name__ == "__main__":
    main()