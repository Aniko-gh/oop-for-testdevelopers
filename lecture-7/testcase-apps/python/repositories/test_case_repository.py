from dataclasses import dataclass

from models.test_case import TestCase

@dataclass
class TestCaseRepository:


    def try_add(self, test_case : TestCase) -> bool:
        pass

    def get_all(self) -> list[TestCase]:
        pass

