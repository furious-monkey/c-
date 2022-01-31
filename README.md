# c-sharp-event-system
This is a simple Event System and Event Dispatcher written in C# with DotNetCore 6.0. 

### Why did I build an Event System even though C# provides a built-in event system:
- To understand how one would work.
- To learn C# before my OOP III class (which is in C#). 
- As a reference for future work/game development.
- As a challenge

### This library is able to: 
- Create custom events which can include methods and values
- Call methods from outer-scope with the Observer design pattern (Event System)
- Manage event listener
- Dispatch events to the correct callback

### This library does not allow for:
- Sorting events with filters
- Clearing events of specific type
- Events queuing
- Delaying events

### Which file does what:
- EventSystem.cs class manages listeners.
- EventDispatcher.cs dispatches events to the right callback for listener classes.
- Event.cs is an abstract class every custom events needs to inherit from.
- IEventListener is and interface every event listener class needs to implement.

### How to use the library :
See the Calculator example in the App project. In  this example, there's a basic calculator calling and event depending on the operator selected. Once the event is fired, the calculator will be notified. The dispatcher will call the right callback depending on the event type. See the DivisionEvent to see the impact of the EventSystem class, since the DivisionEvent also calls a function in the TestClass, to show how the subscribe system allows for multiple listeners for the same event type.

### Contributing : 
Feel free to contribute if you have refactors or ideas in mind.

### The future of this little library :
I would like to add a queue system and a filter system. Though I don't think I'll comeback to this small project since school will takeover all my free time.
