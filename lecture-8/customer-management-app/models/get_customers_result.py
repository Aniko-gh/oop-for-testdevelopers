from dataclasses import dataclass

from models.customer import Customer

@dataclass
class GetCustomersResult:
    succeeded: bool
    error_message: str | None
    customers: list[Customer] | None