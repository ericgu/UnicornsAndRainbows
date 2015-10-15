# UnicornsAndRainbows

A design exercise on testing and decoupling in C



This is a scenario that I am looking for feedback on; it is simplified example from a larger program. The user clicks a button on the UI to launch a browser to
a specific page, and the count of clicks is tracked. 

The program uses the <a href="http://blogs.msdn.com/b/ericgu/archive/2014/12/01/unit-test-success-using-ports-adapters-and-simulators.aspx">Port/Adapter/Simulator</a>
approach of structuring external dependencies, though none of the simulators are read/write so they do not have tests. 

The manager class is where all the fun is; it doesn't do very much but is coupled to three different dependencies; the user interface, a configuration object, and
browser navigator class. 

This seems like a lot of coupling for such a simple operation, and your task is to come up with a better expression. You can use your own definition of "better",
but if you make the testing more complex or worse, it's probably isn't better. Note that the value in the configuration object is 
read/write and may change during program execution. 

I have some thoughts that I will try out in other forks... 