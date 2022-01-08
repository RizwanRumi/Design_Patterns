from abc import ABCMeta
from Chair_factory import Chair
from Table_factory import Table

'''
The Abstract Factory pattern add an abstract layer over multiple factory method implementations.
The abstract factory contains or composites one or more than one factory method
'''

class IFurnitureFactory(metaclass= ABCMeta):
    @staticmethod
    def get_furniture(furniture_type):
        """The static furniture factory interface method"""

class FurnitureFactory(IFurnitureFactory):

    @staticmethod
    def get_furniture(furniture_type):
        try:
            if furniture_type in ["BigChair", "MediumChair", "SmallChair"]:
                return Chair.get_chair(furniture_type)
            elif furniture_type in ["BigTable", "MediumTable", "SmallTable"]:
                return Table.get_Table(furniture_type)
            else:
                raise AssertionError("Cannot find furniture type")

        except AssertionError as _e:
            print(_e)
        return None


if __name__ == "__main__":
    FURNITURE = FurnitureFactory.get_furniture("SmallChair")
    print(f"{FURNITURE.__class__}:{FURNITURE.get_dimensions()}")

    FURNITURE = FurnitureFactory.get_furniture("BigTable")
    print(f"{FURNITURE.__class__}:{FURNITURE.get_dimensions()}")