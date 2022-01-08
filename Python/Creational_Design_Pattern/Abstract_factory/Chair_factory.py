from abc import ABCMeta, abstractstaticmethod

class IChair(metaclass=ABCMeta):

    @staticmethod
    def get_dimension():
        """The chair interface"""

class BigChair(IChair):

    def __init__(self):
        self.height = 80
        self.width = 80
        self.depth = 80

    def get_dimensions(self):
        return {"height": self.height, "width": self.width, "depth": self.depth}

class MediumChair(IChair):

    def __init__(self):
        self.height = 60
        self.width = 60
        self.depth = 60

    def get_dimensions(self):
        return {"height": self.height, "width": self.width, "depth": self.depth}

class SmallChair(IChair):

    def __init__(self):
        self.height = 60
        self.width = 60
        self.depth = 60

    def get_dimensions(self):
        return {"height": self.height, "width": self.width, "depth": self.depth}

class Chair():

    @staticmethod
    def get_chair(chair_type):
        try:
            if chair_type == "BigChair":
                return BigChair()
            elif chair_type == "MediumChair":
                return MediumChair()
            elif chair_type == "SmallChair":
                return SmallChair()
            else:
                raise AssertionError("chair is not found")

        except AssertionError as error:
            print(error)



if __name__ == "__main__":
    CHAIR = Chair.get_chair("BigChair")
    print(f"{CHAIR.__class__} : {CHAIR.get_dimensions()}")

    CHAIR = Chair.get_chair("MediumChair")
    print(f"{CHAIR.__class__} : {CHAIR.get_dimensions()}")

    CHAIR = Chair.get_chair("SmallChair")
    print(f"{CHAIR.__class__} : {CHAIR.get_dimensions()}")

