from services.customer_service import CustomerService

from models.create_customer_dto import CreateCustomerDto

class CustomerDialog:
    def __init__(self, customer_service: CustomerService):
        self.__service:CustomerService = customer_service
    
    
    def create_customer(self) -> None:
        print("")
        print("#### CREATE CUSTOMER ####")

        # enter field values
        name = input("Name: ").strip()
        email = input("Email: ").strip()
        phone = input("Phone: ").strip()

        create_customer_dto = CreateCustomerDto(name, email, phone)

        # normalize - validate - save - return
        result = self.__service.create_customer(create_customer_dto)

        # display error or success message
        if result.succeeded == False:
            print(f"Unable to create customer. {result.error_message}")
        else:
            print(f"Customer was created successfully.")
            print(f"Customer ID: {result.customer.id}")


    def list_customers(self) -> None:
        pass


    def show_menu(self) -> None:
        self.create_customer()