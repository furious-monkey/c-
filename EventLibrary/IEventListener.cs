namespace EventLibrary;

public interface IEventListener
{
    public void OnEvent(Event e);
}