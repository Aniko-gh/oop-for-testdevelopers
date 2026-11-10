from dataclasses import dataclass

from services.test_case_service import TestCaseService


@dataclass
class TestCaseDialog:
    __service : TestCaseService

    def add_dialog(self) -> None:
        pass

    def list_dialog(self) -> None:
        pass

    def menu_dialog(self) -> None:
        pass