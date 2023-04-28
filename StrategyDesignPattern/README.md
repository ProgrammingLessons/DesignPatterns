# Strategy Design Pattern

Strategy is a behavioral design pattern that turns a set of behaviors into objects and makes them interchangeable inside original context object.

The original object, called context, holds a reference to a strategy object. The context delegates executing the behavior to the linked strategy object. In order to change the way the context performs its work, other objects may replace the currently linked strategy object with another one.

--uml image

The classes and objects participating in this pattern include:
* Strategy  (SortStrategy)
	* declares an interface common to all supported algorithms. Context uses this interface to call the algorithm defined by a ConcreteStrategy
* ConcreteStrategy  (QuickSort, ShellSort, MergeSort)
	* implements the algorithm using the Strategy interface
* Context  (SortedList)
	* is configured with a ConcreteStrategy object
	* maintains a reference to a Strategy object
	* may define an interface that lets Strategy access its data.

<hr>

-- example uml

An example is made to use the sorting algorithms in the application here. For sorting algorithms, the method here is used by inheriting from an interface. After writing various sorting algorithms, a class is defined to manage the sorting from a single place, and after it is declared which algorithm to use, sorting is done.

The Strategy design pattern is a very useful method in terms of usage. It is also evident in the usage rate on the Dofactory site.



* https://dofactory.com/net/strategy-design-pattern
* https://refactoring.guru/design-patterns/strategy/csharp/example
* https://www.gencayyildiz.com/blog/c-strategy-design-patternstrateji-tasarim-deseni/
