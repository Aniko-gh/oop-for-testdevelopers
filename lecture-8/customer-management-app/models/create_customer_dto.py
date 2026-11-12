from dataclasses import dataclass

@dataclass
class CreateCustomerDto:
    name: str
    email: str
    phone: str  