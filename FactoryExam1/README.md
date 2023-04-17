# Factory Design Pattern

It falls under the category of Creational Patterns. The Factory Method design pattern offers us a very alternative method for creating related objects. The main purpose is to ensure that the required object is produced over a single instance, thanks to the Factory Method pattern, instead of asking for an instance of the class we want to create.



![Attribute](https://user-images.githubusercontent.com/29948990/232442988-6e5868b5-1808-407d-b540-19e4ed1541ae.jpg)

In the example, bike, car, rickshaw classes are created that implement the Vehicle interface. A factory class(VehicleFactory.cs) is created that will create these three classes. And here its object is declared to the factory for the requested class. If the desired class exists in the factory, a new object is created and returned. If the requested class does not exist, an error is thrown.

Factory design pattern is advantageous in terms of usage. When the object is desired to be created, it will be created from a single center. However, if attention is paid to the GetVehicle method, if else is written for each class. It is undesirable for the software. The solution to this is fixed in the abstract factory design pattern.


* https://refactoring.guru/design-patterns/factory-method
* https://www.c-sharpcorner.com/article/factory-design-pattern-in-c-sharp/
* https://github.com/oguzhanbolme/design-patterns/tree/master/factory-method
* https://github.com/anupavanm/csharp-design-patterns-for-humans#-factory-method
