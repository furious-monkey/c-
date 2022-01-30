namespace App.CustomEvents;

public class AdditionEvent : OperationEvent
{
    public AdditionEvent(int num1, int num2) : 
        base(Type.AdditionEvent, num1, num2)
    {
        
    }

    public override int Calculate()
    {
        return FirstNumber + SecondNumber;
    }
}