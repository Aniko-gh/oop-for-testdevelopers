from dataclasses import dataclass

@dataclass
class CreateTestCase:
    title : str
    purpose : str
    expected_result : str