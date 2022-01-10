from HouseBuilder import HouseBuilder
"""The director building a different representation."""

class IglooDirector:

    @staticmethod
    def construct():
        return HouseBuilder()\
        .set_building_type("Igloo")\
        .set_wall_material("Ice")\
        .set_number_doors(1)\
        .set_number_windows(0)\
        .get_result()

class HouseBoatDirector:

    @staticmethod
    def construct():
        return HouseBuilder()\
        .set_building_type("House Boat")\
        .set_wall_material("Wooden")\
        .set_number_doors(6)\
        .set_number_windows(8)\
        .get_result()


class IglooDirector:

    @staticmethod
    def construct():
        return HouseBuilder()\
        .set_building_type("Igloo")\
        .set_wall_material("Ice")\
        .set_number_doors(1)\
        .set_number_windows(0)\
        .get_result()


class CastleDirector:

    @staticmethod
    def construct():
        return HouseBuilder()\
        .set_building_type("Castle")\
        .set_wall_material("Granite")\
        .set_number_doors(100)\
        .set_number_windows(200)\
        .get_result()