namespace App.CustomEvents;

public class DivisionEvent : OperationEvent
{
    public DivisionEvent(int num1, int num2) : base(Type.DivisionEvent, num1, num2)
    {
        
    }

    public override int Calculate()
    {
        return FirstNumber / SecondNumber;
    }
}