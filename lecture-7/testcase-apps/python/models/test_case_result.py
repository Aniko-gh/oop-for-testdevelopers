from dataclasses import dataclass

from models.test_case import TestCase

@dataclass
class TestCaseResult:
    succeeded : bool
    message : str
    result : list[TestCase] = []