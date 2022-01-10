from Director import IglooDirector, HouseBoatDirector, CastleDirector

"""
The builder pattern is a creational pattern whose intent is to separate the
construction of a complex object from its representation so that we can use
the same construction process to create different representation.

it tries to solve :
- how can a class create different representations of a complex object?
- how can a class that includes creating a complex object be simplified

Pros and cons:
- Can construct objects step-by-step, defer construction steps or run steps recursively.
- Reuse the same construction code when building various representations of objects.
- Single Responsibility Principle. Isolate complex construction code from the business logic of the product.
- Overall complexity of the code increases.
"""


if __name__ == "__main__":
    IGLOO = IglooDirector.construct()
    HOUSEBOAT = HouseBoatDirector.construct()
    CASTLE = CastleDirector.construct()

    print(IGLOO)
    print(HOUSEBOAT)
    print(CASTLE)
