using App.CustomEvents;
using EventLibrary;

namespace App;

public class Calculator : IEventListener
{
    private string? _input;
    private int _num1;
    private int _num2;
    private int _result;
    private char _operator;

    public Calculator()
    {
        EventSystem.Instance.AddEventListener(this);
    }

    public void Start()
    {
        ReadNumber(true);
        ReadOperator();
        ReadNumber(false);
        Calculate();
        DisplayEquation();
    }
    
    public void OnEvent(Event e)
    {
        var dispatcher = new EventDispatcher(e);
        dispatcher.Dispatch(AdditionEvent.EventType, e2 => OnOperation((AdditionEvent) e2));
        dispatcher.Dispatch(SoustractionEvent.EventType, e2 => OnOperation((SoustractionEvent) e2));
        dispatcher.Dispatch(MultiplicationEvent.EventType, e2 => OnOperation((MultiplicationEvent) e2));
        dispatcher.Dispatch(DivisionEvent.EventType, e2 => OnOperation((DivisionEvent) e2));
    }

    private bool OnOperation(OperationEvent e)
    {
        _result = e.Calculate();
        return true;
    }

    private void ReadNumber(bool isFirstNumber)
    {
        Console.WriteLine("Enter " + (isFirstNumber ? "first" : "second") + " number: ");
        _input = Console.ReadLine();
        if (isFirstNumber)
        {
            _num1 = Convert.ToInt32(_input);
        }
        else
        {
            _num2 = Convert.ToInt32(_input);
        }
    }

    private void ReadOperator()
    {
        Console.WriteLine("Enter operator (+, -, *, /): ");
        _input = Console.ReadLine()!;
        _operator = _input[0];
    }
    
    private void Calculate()
    {
        EventSystem.Instance.OnEvent(GetEvent()!);
    }

    private Event? GetEvent()
    {
        return _operator switch
            {
                '+' => new AdditionEvent(_num1, _num2),
                '-' => new SoustractionEvent(_num1, _num2),
                '*' => new MultiplicationEvent(_num1, _num2),
                '/' => new DivisionEvent(_num1, _num2),
                _ => null
            };
    }

    private void DisplayEquation()
    {
        Console.WriteLine(_num1 + " " + _operator + " " + _num2 + " = " + _result);
    }
}