# Visitor Design Pattern

The Visitor design pattern represents an operation to be performed on the elements of an object structure. This pattern lets you define a new operation without changing the classes of the elements on which it operates.


--UML

The classes and objects participating in this pattern include:
* Visitor
	* declares a Visit operation for each class of ConcreteElement in the object structure. The operation's name and signature identifies the class that sends the Visit request to the visitor. That lets the visitor determine the concrete class of the element being visited. Then the visitor can access the elements directly through its particular interface
* ConcreteVisitor  (IncomeVisitor, VacationVisitor)
	* implements each operation declared by Visitor. Each operation implements a fragment of the algorithm defined for the corresponding class or object in the structure. ConcreteVisitor provides the context for the algorithm and stores its local state. This state often accumulates results during the traversal of the structure.
* Element 
	* defines an Accept operation that takes a visitor as an argument.
* ConcreteElement 
	* implements an Accept operation that takes a visitor as an argument
* ObjectStructure 
	*can enumerate its elements
	* may provide a high-level interface to allow the visitor to visit its elements
	* may either be a Composite (pattern) or a collection such as a list or a set

<hr>

--Example UML


In the sample project here, features are added to different types of printers. Thanks to the visitor design, the desired feature is added to the relevant object.


It is also evident in the usage rate on the Dofactory site.
![use](https://user-images.githubusercontent.com/29948990/235091323-afa296c3-193c-433e-9a16-05fe656e8326.png)


* https://dofactory.com/net/visitor-design-pattern
* https://refactoring.guru/design-patterns/visitor
* https://www.gencayyildiz.com/blog/c-visitor-design-patternvisitor-tasarim-deseni/
