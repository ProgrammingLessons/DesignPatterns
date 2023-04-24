# Chain Of Responsibility Design Pattern

Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

-- ss1

This design pattern features a chain. After an incoming request enters the chain, it is transferred to the next chain according to the conditions.


A visualization of the classes and objects participating in this pattern.

--UML diagram

* Handler   (IEditor)
    * defines an interface for handling the requests
    * (optional) implements the successor link
* ConcreteHandler   (Editor, ExecutiveEditor, ManagingEditor)
    * handles requests it is responsible for
    * can access its successor
    * if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
* Client   (ChainApp)
    * initiates the request to a ConcreteHandler object on the chain



-- Project uml diagram

In the sample application, the flow through which a magazine article was approved was made. If the article for the journal is less than 1000 characters, Editor. Executive Editor if it is between 1000 and 2000 characters. If it is more than 2000 characters, it must be approved by the Managing Editor.





* https://dofactory.com/net/chain-of-responsibility-design-pattern
* https://refactoring.guru/design-patterns/chain-of-responsibilityc-composite-design-patterncomposite-tasarim-deseni/
* https://www.borakasmer.com/the-chain-of-responsibility-pattern/
* https://www.buraksenyurt.com/post/Tasarc4b1m-Desenleri-Chain-of-Responsibility
