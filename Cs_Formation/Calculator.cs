public class Calculator
{
    private double _value;

    public Calculator()
    {
        this._value = 0;
    }

    public Calculator(double value)
    {
        this._value = value;
    }

    public void Add(double rvalue)
    {
        this._value = this._value + rvalue;
    }

    public void Sub(double rvalue)
    {
        this._value = this._value - rvalue; 
    }

    public void Divide(double rvalue)
    {
        if (rvalue == 0)
        {
            Console.WriteLine("Impossible de diviser par 0");
        }
        else
        {
            this._value = this._value / rvalue;
        }
    }

    public double GetResult()
    {
        return this._value;
    }
}

public main()
{
    Calculator calc = new Calculator();

    calc.Add(5);
    calc.Add(10);

    calc.Sub(20);

    calc.Divide(2);

    double resultat = calc.GetResult();

    Console.WriteLine(resultat);
}