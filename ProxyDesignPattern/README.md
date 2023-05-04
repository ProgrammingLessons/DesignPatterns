# Proxy Design Pattern

Proxy is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client. A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object.


![proxy_uml](https://user-images.githubusercontent.com/29948990/236127896-5b2947cb-4b31-4e21-8c65-49b71016f9a5.png)

The classes and objects participating in this pattern include:
* Proxy  
	* maintains a reference that lets the proxy access the real subject. Proxy may refer to a Subject if the RealSubject and Subject interfaces are the same.
	* provides an interface identical to Subject's so that a proxy can be substituted for for the real subject.
	* controls access to the real subject and may be responsible for creating and deleting it.
	* other responsibilites depend on the kind of proxy:
		* remote proxies are responsible for encoding a request and its arguments and for sending the encoded request to the real subject in a different address space.
		* virtual proxies may cache additional information about the real subject so that they can postpone accessing it. For example, the ImageProxy from the Motivation caches the real images's extent.
		* protection proxies check that the caller has the access permissions required to perform a request.
* Subject   
	* defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected.
* RealSubject   
	* defines the real object that the proxy represents.

<hr>

![example_uml](https://user-images.githubusercontent.com/29948990/236127935-7b55bca1-2294-44e5-8d49-06af5035f8bc.png)

In order to be more understandable in this project, I took the javascript example from the dofactory site and wrote it using C#. 
Here, a proxy class is placed between the client and geography, preventing direct access to the Geography location class. 
This proxy class takes what the client wants from the real class and delivers it to the client.


The Strategy design pattern is a very useful method in terms of usage. It is also evident in the usage rate on the Dofactory site.

![frequency](https://user-images.githubusercontent.com/29948990/236127961-dd809aad-1a2e-4f99-9d6c-3aa04bcc11be.png)


* https://www.dofactory.com/net/proxy-design-pattern
* https://refactoring.guru/design-patterns/proxy/csharp/example
* https://www.dofactory.com/javascript/design-patterns/proxy
