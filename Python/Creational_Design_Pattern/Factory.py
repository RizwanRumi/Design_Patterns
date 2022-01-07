from abc import ABCMeta, abstractstaticmethod

"""
Factory pattern provides an interfaces for creating object in a superclass, 
but allows subclasses to alter the type of object that will be created.

using a Factory allows the consumer to create new objects without having 
to know the details of how they're created, or what their dependencies 
are - they only have to give the information they actually want.

Pros and Cons:
1. Avoid tight coupling between the creator and the concrete products.
2. Single Responsibility Principle is applied. Product creation code can
 move into one place in the program, making the code easier to support.
3. Open/Closed Principle is applied. Introduce new types of products into
 the program without breaking existing client code.
4. The code may become more complicated since to introduce a lot of new
 subclasses to implement the pattern. The best case scenario is when 
 introducing the pattern into an existing hierarchy of creator classes.
"""

# create interface
class ITransport(metaclass=ABCMeta):

    @staticmethod
    def get_deliver():
        """The product interface"""

class Truck():

    def __init__(self):
        self.package = "Standard"
        self.max_product_weight = 50
        self.max_delivery_days = 7
        self.cost = 15

    def get_deliver(self):
        return{"Package": self.package, "max. carry": self.max_product_weight,
               "max. delivery day": self.max_delivery_days, "cost": self.cost }

class Ship():

    def __init__(self):
        self.package = "Standard"
        self.max_product_weight = 100
        self.max_delivery_days = 15
        self.cost = 10

    def get_deliver(self):
        return{"Package": self.package, "max. carry": self.max_product_weight,
               "max. delivery day": self.max_delivery_days, "cost": self.cost }


class Car():

    def __init__(self):
        self.package = "Standard"
        self.max_product_weight = 20
        self.max_delivery_days = 4
        self.cost = 12

    def get_deliver(self):
        return {"Package": self.package, "max. carry": self.max_product_weight,
                "max. delivery day": self.max_delivery_days, "cost": self.cost}

class TransportAgency():

    @staticmethod
    def get_transport(transport_type):
        try:
            if transport_type == "Truck":
                print("Truck:")
                return Truck()
            elif transport_type == "Ship":
                print("Ship:")
                return Ship()
            elif transport_type == "Car":
                print("Car:")
                return Car()
            else:
                raise AssertionError("Transport is not found")

        except AssertionError as error:
            print(error)


if __name__ == "__main__":
    Transport = TransportAgency.get_transport("Truck")
    print("\t {}".format(Transport.get_deliver()))

    Transport = TransportAgency.get_transport("Car")
    print("\t {}".format(Transport.get_deliver()))

    Transport = TransportAgency.get_transport("Ship")
    print("\t {}".format(Transport.get_deliver()))

    Transport = TransportAgency.get_transport("Air")
    print("\t {}".format(Transport))
