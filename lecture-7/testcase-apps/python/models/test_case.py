from dataclasses import dataclass
from uuid import UUID

@dataclass
class TestCase:
    id : UUID
    title : str
    purpose : str
    expected_result : str