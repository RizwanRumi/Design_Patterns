from abc import ABCMeta, abstractstaticmethod

"""The builder interface"""

class IHouseBuilder(metaclass=ABCMeta):
    @staticmethod
    def set_wall_material(self, value):
        """Set the wall material"""

    @staticmethod
    def set_building_type(self, value):
        """Set the building type"""

    @staticmethod
    def set_number_doors(Self, value):
        """Set the number doors"""

    @staticmethod
    def set_number_windows(self, value):
        """Set the number of windows"""

    @staticmethod
    def get_result(self):
        "Retuen the house"