using System;

public class Fraction
{
    // - This my private attributes (Encapsulation)
    private int _top;
    private int _bottom;

    // Default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // - Here, this is the constructor with one parameter
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;

        // - This is an my creativity:
        // Prevent denominator from becoming zero
        if (bottom == 0)
        {
            Console.WriteLine("Denominator cannot be zero. Automatically changed to 1.");
            _bottom = 1;
        }
        else
        {
            _bottom = bottom;
        }
    }

    // -Getter for top number
    public int GetTop()
    {
        return _top;
    }

    // - Setter for top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // - Getter for bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // -Setter for bottom number
    public void SetBottom(int bottom)
    {
        // Extra protection for denominator
        if (bottom == 0)
        {
            Console.WriteLine("Bottom number cannot be zero.");
        }
        else
        {
            _bottom = bottom;
        }
    }

    // Returns fraction format
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns decimal value
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    // Creativity:
    // Simplifies the fraction automatically
    public void Simplify()
    {
        int smallest = Math.Min(Math.Abs(_top), Math.Abs(_bottom));

        for (int i = smallest; i >= 1; i--)
        {
            if (_top % i == 0 && _bottom % i == 0)
            {
                _top = _top / i;
                _bottom = _bottom / i;
                break;
            }
        }
    }
}