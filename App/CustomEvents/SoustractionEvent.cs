namespace App.CustomEvents;

public class SoustractionEvent : OperationEvent
{
    public new static string EventType => "EVENT_SOUSTRACTION_OPERATION";
    
    public SoustractionEvent(int num1, int num2) : base(EventType, num1, num2)
    {
        
    }

    public override int Calculate()
    {
        return FirstNumber - SecondNumber;
    }
}