from abc import ABCMeta, abstractstaticmethod

class ITable(metaclass=ABCMeta):

    @staticmethod
    def get_dimension():
        """The Table interface"""

class BigTable(ITable):

    def __init__(self):
        self.height = 80
        self.width = 80
        self.depth = 80

    def get_dimensions(self):
        return {"height": self.height, "width": self.width, "depth": self.depth}

class MediumTable(ITable):

    def __init__(self):
        self.height = 60
        self.width = 60
        self.depth = 60

    def get_dimensions(self):
        return {"height": self.height, "width": self.width, "depth": self.depth}

class SmallTable(ITable):

    def __init__(self):
        self.height = 60
        self.width = 60
        self.depth = 60

    def get_dimensions(self):
        return {"height": self.height, "width": self.width, "depth": self.depth}

class Table():

    @staticmethod
    def get_Table(table_type):
        try:
            if table_type == "BigTable":
                return BigTable()
            elif table_type == "MediumTable":
                return MediumTable()
            elif table_type == "SmallTable":
                return SmallTable()
            else:
                raise AssertionError("Table is not found")

        except AssertionError as error:
            print(error)



if __name__ == "__main__":
    TABLE = Table.get_Table("BigTable")
    print(f"{TABLE.__class__} : {TABLE.get_dimensions()}")

    TABLE = Table.get_Table("MediumTable")
    print(f"{TABLE.__class__} : {TABLE.get_dimensions()}")

    TABLE = Table.get_Table("SmallTable")
    print(f"{TABLE.__class__} : {TABLE.get_dimensions()}")

