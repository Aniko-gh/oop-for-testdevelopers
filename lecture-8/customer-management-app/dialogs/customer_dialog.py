from services.customer_service import CustomerService

from models.create_customer_dto import CreateCustomerDto

class CustomerDialog:
    def __init__(self, customer_service: CustomerService):
        self.__service:CustomerService = customer_service
    
    
    def create_customer_dialog(self) -> None:
        print("")
        print("#### CREATE CUSTOMER ####")

        name = input("Name: ").strip()
        email = input("Email: ").strip()
        phone = input("Phone: ").strip()

        create_customer_dto = CreateCustomerDto(name, email, phone)

        result = self.__service.create_customer(create_customer_dto)

        if result.succeeded == False:
            print(f"Unable to create customer. {result.error_message}")
        else:
            print(f"Customer was created successfully.")
            print(f"Customer ID: {result.customer.id}")


    def list_customers_dialog(self) -> None:
        pass


    def show_menu_dialog(self) -> None:
        self.create_customer_dialog()