from IHouseBuilder import IHouseBuilder
from House import House

"""
    The concrete builder class implement all methods of interface
    and construct the object step by  step
"""

class HouseBuilder(IHouseBuilder):
    def __init__(self):
        self.house = House()

    def set_wall_material(self, value):
        self.house.wall_material = value
        return self

    def set_building_type(self, value):
        self.house.building_type = value
        return self

    def set_number_doors(self, value):
        self.house.doors = value
        return self

    def set_number_windows(self, value):
        self.house.windows = value
        return self

    def get_result(self):
        return self.house
