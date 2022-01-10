class House():

    def __init__(self, building_type = "Apartment", doors = 0, windows = 0, wall_material = "brick"):
        self.wall_material = wall_material
        self.building_type = building_type
        self.doors = doors
        self.windows = windows

    def __str__(self):
        return "This is a {0} {1} with {2} door(s) and {3} windows(s).".format(
            self.wall_material, self.building_type, self.doors, self.windows)