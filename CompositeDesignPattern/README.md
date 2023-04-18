# Composite Design Pattern

Composite is a structural design pattern that allows composing objects into a tree-like structure and work with the it as if it was a singular object.

Composite became a pretty popular solution for the most problems that require building a tree structure. Composite’s great feature is the ability to run methods recursively over the whole tree structure and sum up the results.


![composite](https://user-images.githubusercontent.com/29948990/232745919-7098f3e7-c37b-42c8-819e-315e46d57722.png)


In designs such as tree structures to which the Composite pattern will be applied, three different classes of responsibility should be designed, namely Component, Composite and Leaf.
* Component: It is an abstract class that describes simple and complex objects in the tree structure and the common areas of these objects.
* Composite: It is the class that corresponds to the complex objects in the tree structure. For a more technical explanation, it represents complex objects where Components come together and form sub-breaks in the tree structure.
* Leaf: It is a single Component object, which is the most basic element in the tree structure and does not contain sub-breaks. So it refers to the simple object.


In the example made here, the army model with the command and command system is built in software.
Soldiers, Component abstract class design has been realized. Ranks are defined as enums. 
Commander class was created with the Commander class. Since the commander is a soldier, he inherited from the Soldier class. Since each commander will have soldiers subordinate to him, a list has been created here and these soldiers have been kept.
In the army hierarchy, the last link of the tree structure is the soldiers. As such, they are referred to as Leaf in our design.
Although the BuckPrivate class represents a soldier, it derives from the 'Soldier' abstract class, as it is essentially a soldier and provides the necessary implementations in it.


* https://refactoring.guru/design-patterns/composite
* https://www.gencayyildiz.com/blog/c-composite-design-patterncomposite-tasarim-deseni/
* https://www.youtube.com/watch?v=-FWLN9FmGAk
* https://www.youtube.com/watch?v=UsynwPeipb8
* https://www.dofactory.com/net/composite-design-pattern
