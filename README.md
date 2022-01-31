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

### How to use it (See calculator example) :
1. Create a class that will be listening for events.
2. Inherit the created class with IEventListener.
3. In its constructor, make sure to subscribe it to the EventSyteme.
```c#
public Calculator()
{
    EventSystem.Instance.AddEventListener(this);
}
``` 
