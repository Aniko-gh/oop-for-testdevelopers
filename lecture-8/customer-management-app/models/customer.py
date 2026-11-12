from dataclasses import dataclass
from uuid import uuid4

@dataclass
class Customer:
    id: str
    name: str
    email: str
    phone: str

    @classmethod
    def create(cls, name: str, email: str, phone: str) -> "Customer":
        return cls(
            id = str(uuid4()), 
            name = name,
            email = email,
            phone = phone
        )