using System;

public class Fraction
{
    private float top;
    private float bottom;

    public Fraction()
    {
        this.top = 1;
        this.bottom = 1;
    }

    public Fraction(float wholeNumber)
    {
        this.top = wholeNumber;
        this.bottom = 1;
    }

    public Fraction(float top, float bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    public float GetTop()
    {
        return top;
    }

    public void SetTop(float top)
    {
        this.top = top;
    }

    public float GetBottom()
    {
        return bottom;
    }

    public void SetBottom(float bottom)
    {
        this.bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }

    public float GetDecimalValue()
    {
        return top / bottom;
    }
}