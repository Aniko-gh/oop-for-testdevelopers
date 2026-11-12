from unittest.mock import Mock

import pytest

from repositories.customer_repository import CustomerRepository
from services.customer_service import CustomerService
from models.create_customer_dto import CreateCustomerDto

@pytest.fixture
def mock_repository():
    return Mock(spec=CustomerRepository)

@pytest.fixture
def service(mock_repository):
    return CustomerService(mock_repository)


def test_create_customer_succeeds_with_valid_values(service):
    # arrange - förberedelser
    create_customer_dto = CreateCustomerDto("Hans", "hans@domain.com ", "073-1234567")

    # act - utförandet
    result = service.create_customer(create_customer_dto)

    # assert - utvärdering/kontroll
    assert result.succeeded is True
    assert result.error_message is None
    assert result.customer is not None
    assert result.customer.id != ""
    assert result.customer.name == "Hans"
    assert result.customer.email == "hans@domain.com"
    assert result.customer.phone == "073-1234567"

