namespace App.CustomEvents;

public class SoustractionEvent : OperationEvent
{
    public SoustractionEvent(int num1, int num2) : 
        base(Type.SoustractionEvent, num1, num2)
    {
        
    }

    public override int Calculate()
    {
        return FirstNumber - SecondNumber;
    }
}