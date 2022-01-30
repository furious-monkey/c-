namespace App.CustomEvents;

public class MultiplicationEvent : OperationEvent
{
    public MultiplicationEvent(int num1, int num2) : base(Type.MultiplicationEvent, num1, num2)
    {
        
    }

    public override int Calculate()
    {
        return FirstNumber * SecondNumber;
    }
}