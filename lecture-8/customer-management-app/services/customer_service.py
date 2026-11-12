from repositories.customer_repository import CustomerRepository
from models.create_customer_dto import CreateCustomerDto
from models.create_customer_result import CreateCustomerResult
from models.get_customers_result import GetCustomersResult
from models.customer import Customer

class CustomerService:
    def __init__(self, customer_repository: CustomerRepository):
        self.__repository:CustomerRepository = customer_repository
    
    
    def create_customer(self, create_customer_dto:CreateCustomerDto) -> CreateCustomerResult:
        
        # normalize values
        normalized_name = create_customer_dto.name.strip()
        normalized_email = create_customer_dto.email.strip()
        normalized_phone = create_customer_dto.phone.strip()

        # validate values
        if not normalized_name:
            return CreateCustomerResult(False, "Customer name is required.", None)

        if not normalized_email:
            return CreateCustomerResult(False, "Email address is required.", None)

        if not normalized_phone:
            return CreateCustomerResult(False, "Phone number is required.", None)

        # create customer
        customer = Customer.create(normalized_name, normalized_email, normalized_phone)

        # save customer
        self.__repository.add(customer)

        # return customer
        return CreateCustomerResult(True, None, customer)

        
    def get_customers(self) -> GetCustomersResult:
        pass
