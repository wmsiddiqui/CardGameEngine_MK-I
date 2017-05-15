# CardGameEngine_MK-I - Abandoned

## Lessons Learned

Programming to interfaces more, instead of classes, would have allowed us to unit test more. At the moment we were creating concrete classes to use in our unit tests, when we should be able to just "mock out" classes implementing the respective interfaces. 

Furthermore, due to some invalid concerns we had about security, we made classes more tightly coupled, which led to some convoluted code. Since this is all server sided, we shouldn't need to be concerned about security outside of API level security.

## Things We Did Well

We programmed to interfaces, but just not enough. It was a step I  the right direction. 

Some unit tests are better than none.

Loose coupling allows for different game type implementations.

Great effort to writing clean code. 

## The End

Card Game Engine Architecture phase

Notes:
Program to interfaces, not objects. This will really help in creating unit tests.

Don't design concrete classes first.

First design the architecture by using interfaces. Fleshing out abstract classes should be relatively straightforward then.
Concrete classes will be even easier.

First, we should assume we will be getting a collection of UNSORTED commands or interactions, and we then need to execute them.

I expect better orgainization this time around in regards to namespaces.

TODO: Read up more on creational design patterns, see if we can leveredge any. Abstract Factory seems uneeded, along with Singleton.

See Factory, Builder, and Prototype. 
