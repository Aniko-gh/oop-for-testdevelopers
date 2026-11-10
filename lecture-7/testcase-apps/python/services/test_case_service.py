from dataclasses import dataclass

from repositories.test_case_repository import TestCaseRepository

from models.create_test_case import CreateTestCase
from models.test_case_result import TestCaseResult

@dataclass
class TestCaseService:
    __repository : TestCaseRepository

    def create_test_case(self, create_test_case : CreateTestCase) -> TestCaseResult:
        pass

    def get_all_test_cases(self) -> TestCaseResult:
        pass

