# Mediator Design Pattern

Mediator is a behavioral design pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

Rather than communicating directly between objects, the purpose of this design is to prevent them from communicating directly with each other by 
putting an intermediate class (Mediator) in the middle and performing all communication tasks over this common object. 
In addition, as the number of classes increases, the dependencies between them also increase, making the maintenance and modification of the application more difficult. 
The Mediator design pattern also serves to reduce dependencies between these classes and facilitate communication between them.


![mediator_uml](https://user-images.githubusercontent.com/29948990/234710267-4101c9c7-cba8-4c59-8a12-90b03d95d074.png)

The classes and objects participating in this pattern include:
* Mediator  (IChatroomMediator)
	* defines an interface for communicating with Colleague objects
* ConcreteMediator  (ChatroomMediator)
	* implements cooperative behavior by coordinating Colleague objects
	* knows and maintains its colleagues
* Colleague classes  (Participant)
	* each Colleague class knows its Mediator object
	* each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague


<hr>


UML diagram of sample app:

![Screenshot_2](https://user-images.githubusercontent.com/29948990/234710366-32ca6122-a283-48a0-b327-cbd73284cadd.png)

In the sample application, if there was no Mediator design pattern in a chat system, users would send messages to each other while sending messages to each other. As shown in the sample picture.

![not_mediator](https://user-images.githubusercontent.com/29948990/234711893-aafc8fcd-f786-4fc6-8a50-fd1bf87f0c79.png)

Here, to solve this confusion, a mediator system is brought together and it is this system that manages the flow.

![with_meditor](https://user-images.githubusercontent.com/29948990/234711931-ed39b601-fdca-475c-bce5-bb89cfa64fa2.png)


All messages pass through this mediator and are forwarded to the relevant place. In this way, there is no object redundancy.

The biggest feature I learned thanks to Mediator design will be to use this design pattern in cases where objects that are related to each other communicate directly.



* https://medium.com/bili%C5%9Fim-hareketi/mediator-tasar%C4%B1m-kal%C4%B1b%C4%B1-881ee987ea72
* https://www.buraksenyurt.com/post/Tasarc4b1m-Desenleri-Mediator
* https://github.com/anupavanm/csharp-design-patterns-for-humans#-mediator
* https://dofactory.com/net/mediator-design-pattern
* https://www.youtube.com/watch?v=YBL_8WlFJ6Q
