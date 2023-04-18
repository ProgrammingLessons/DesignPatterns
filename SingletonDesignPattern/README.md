# Singleton Design Pattern

Singleton design pattern is in the category of creational design pattern.

The purpose of this design pattern is to create only one instance of a class. In other words, when an instance is wanted to be created from any class, if there is no instance created before, a new one is created. If it has been created before, the existing instance is used.


![uml](https://user-images.githubusercontent.com/29948990/232697345-6fbbd1fd-ff82-444d-a425-da65044f06d1.png)


Different methods can be used for the singleton design pattern. In this application, 6 different methods have been tried for singleton.

### Case1
The singleton written in case1 is not safe. Two different threads could both have evaluated the test if (instance==null) and found it to be true, then both create instances, which violates the singleton pattern. Note that in fact the instance may already have been created before the expression is evaluated, but the memory model doesn't guarantee that the new value of instance will be seen by other threads unless suitable memory barriers have been passed.


### Case2
This method is application thread-safe. Request from different thread will not be able to enter instance creation at the same time. Since the object will be produced after the first operation with the Lock operation, the object created will be given to the request from the second thread. When more than one object is produced, more memory is used. This method solves the memory problem.


### Case3
Case3 has double checks. If we look at the Case2 codes again, the object existence is checked after the lock check. In Case3, it will be more efficient if the object existence is checked before the lock for a preliminary check and not to wait for the operation on the lock.


### Case4
Static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain. Given that this check for the type being newly constructed needs to be executed whatever else happens, it will be faster than adding extra checking as in the previous examples(Case1, Case2, Case3). 

### Case5
Here, instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance. This means the implementation is fully lazy, but has all the performance benefits of the previous ones. Note that although nested classes have access to the enclosing class's private members, the reverse is not true, hence the need for instance to be internal here. That doesn't raise any other problems, though, as the class itself is private. The code is a bit more complicated in order to make the instantiation lazy, however.

### Case6
If you're using .NET 4 (or higher), you can use the System.Lazy<T> type to make the laziness really simple. All you need to do is pass a delegate to the constructor which calls the Singleton constructor - which is done most easily with a lambda expression. It is simple and good in performance. In addition, if needed, the IsValueCreated property can be used to check whether the sample has been created yet.


My personal preference is for solution 4: the only time I would normally go away from it is if I needed to be able to call other static methods without triggering initialization, or if I needed to know whether or not the singleton has already been instantiated. I don't remember the last time I was in that situation, assuming I even have. In that case, I'd probably go for solution 2, which is still nice and easy to get right.

Solution 5 is elegant, but trickier than 2 or 4, and as I said above, the benefits it provides seem to only be rarely useful. Solution 6 is a simpler way to achieve laziness, if you're using .NET 4. It also has the advantage that it's obviously lazy. I currently tend to still use solution 4, simply through habit - but if I were working with inexperienced developers I'd quite possibly go for solution 6 to start with as an easy and universally applicable pattern.


* https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
* https://refactoring.guru/design-patterns/singleton
* https://metinalniacik.medium.com/singleton-design-pattern-tasar%C4%B1m-%C3%B6r%C3%BCnt%C3%BCs%C3%BC-b7221929dc26
* https://csharpindepth.com/articles/singleton
* https://www.tutorialsteacher.com/csharp/singleton
