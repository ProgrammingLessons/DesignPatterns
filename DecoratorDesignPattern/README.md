# Decorator Design Pattern

Decorator is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside special wrapper objects, called decorators.
Using decorators you can wrap objects countless number of times since both target objects and decorators follow the same interface. The resulting object will get a stacking behavior of all wrappers.


Decorator can divide the design pattern into two parts, Decorator classes and Component classes. Component classes include the Decorator super class. So it is necessary to create a structure like this:

![ss1](https://user-images.githubusercontent.com/29948990/234003702-b3fa174f-d359-4816-aa1d-84b621feff9e.png)


The Decorator class derives from the Component class. At the same time, there is a HAS-A relationship between the Decorator class and the Component class. This means that inside the Decorator class, there is an instance variable of type Component (Composition structure).
The Decorator class can be abstract or interface. It is necessary not to use concrete classes.

The object to which the properties will be added dynamically derives from the ConcreteComponent class.

The ConcreteDecorator object adds properties to the ConcreteComponent object.

UML diagram of sample application:

![ss2](https://user-images.githubusercontent.com/29948990/234003807-663fab13-9176-48c9-aa4e-cadafd940635.png)



All operations are not performed in a class, but they are made to be managed in parts. 
It also easily provides the innovations that may come later. 
In the application, a base circle is defined with the decorator operation. 
When a new request is made regarding the circle operation, it can be inherited from the decorator. 
Thus, the open-closed principle is applied from solid principles.


If we want to make a change from the runtime moment that I learned from here, or if there are possible parts to be changed later, it would be to use the decorator design pattern here.


* https://refactoring.guru/design-patterns/decorator/csharp/example
* https://www.gencayyildiz.com/blog/c-decorator-design-patterndecorator-tasarim-deseni/
* https://www.tutorialspoint.com/design_pattern/decorator_pattern.htm
* https://medium.com/@veysel.gunes36/decorator-tasar%C4%B1m-deseni-nedir-what-is-decorator-design-pattern-73e0dbc3443d
