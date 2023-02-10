# The Car Factory cookie
I have a car factory
    -  Cars 4 wheels
    -   Race car has two doors

    -   SchoolCar has 5 doors
    - we can create RaceCars and SchoolCars
    - Race car speed can reach up to 300mph
    - SchoolCars speed can reach up to 50mph
    - SchoolCars must have baby-chair
    - Race car must not have baby-chair
    - Car factory has a list of built cars,
    Then, create a list of Cars and please fetch only the SchoolCars from the list
## My  intention was
    - avoid Car class to be instantiable by its own, because isn't make sense.
    - We can only call Car constructor through it sub-classes, becuase make sense create a new ShoolCar, Car by it's own mean nothing.
    - We encure Single Responsibility principle, because Car Factory doesn't care about what type of Car it's building
    - We ensure OPEN CLOSED PRINCIPLE; becuase if a new type of car want to be built(I.e Bike), we don't need to modify CarFactory, only Car build. Make sense, becuase Car Factory dont' should be worried about what type of car is built, it only want to built cars, whatever the cars are.

## How to run

    - Please run unit test to see how it's work