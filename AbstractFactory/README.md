# Abstract Factory Design Pattern

It falls under the category of Creational Patterns. 
Abstract Factory Design Pattern it provides the production of more than one relational object not by a single interface, but by defining a different interface for each product family.

While there is only one interface belonging to a single product family in the factory design pattern, there are different interfaces for different product families in the abstract factory.

![uml_diagram](https://user-images.githubusercontent.com/29948990/232478788-c66a5ed9-545b-4d15-bad8-e1457bea5508.png)


As an example, we will apply the example made in the factory design pattern. There were Car, Bike and Rickshaw classes. These classes inherited from the Ivehicle interface. When we wanted to create a class instance from a member of the vehicle family, we were specifying which class to create as a parameter to the GetVehicle method from the VehicleFactory class. When this happens, there is a dependency on the factory side and undesirable situations occur in the code.

In the abstract factory, a factory class is created for each member of the vehicle family (Car, bike, rickshaw). Each member is responsible for the instance of his class. Thus, there is no dependency and no code confusion.

The abstract design pattern should be preferred over the factory design pattern.


* https://refactoring.guru/design-patterns/abstract-factory
* https://www.c-sharpcorner.com/article/c-sharp-abstract-factory-design-pattern-with-code-example/
* https://www.dotnettricks.com/learn/designpatterns/abstract-factory-design-pattern-dotnet
* https://github.com/VanHakobyan/DesignPatterns/tree/master/Abstract%20Factory
