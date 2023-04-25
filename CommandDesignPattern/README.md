# Command Design Pattern

Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request�s execution, and support undoable operations.


![ss1](https://user-images.githubusercontent.com/29948990/234239176-32046800-ca30-42d4-9990-73757e35bf52.png)

The classes and objects participating in this pattern include:

* Command
    * declares an interface for executing an operation
* ConcreteCommand 
    * defines a binding between a Receiver object and an action
    * implements Execute by invoking the corresponding operation(s) on Receiver
* Client 
    * creates a ConcreteCommand object and sets its receiver
* Invoker
    * asks the command to carry out the request
* Receiver
    * knows how to perform the operations associated with carrying out the request.

<hr>

UML diagram of sample app:

![ss2](https://user-images.githubusercontent.com/29948990/234239230-36b7d082-1842-4bec-94fb-257d7358ebae.png)


In the example application made here, the commands to turn the lamp off and on are made. By not doing the if else situation, the command design pattern and the class of each command were created for the lamp and commands were sent to the lamp with the help of the Invoker class.

In my opinion, it is a design pattern that provides great convenience in terms of use because it eliminates the if else writing. It removes code complexity. DoFactory sitesinde kullanım oranıda bunu göstermektedir. 

![image](https://user-images.githubusercontent.com/29948990/234239496-6f0551ab-c186-4e81-af08-705f38609247.png)



Source: 
* https://www.dofactory.com/net/command-design-pattern
* https://github.com/csharp-design-patterns/command
* https://github.com/anupavanm/csharp-design-patterns-for-humans#-command
