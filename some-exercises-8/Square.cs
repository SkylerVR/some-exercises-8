namespace some_exercises_8;

public class Square : Rectangle
{
    public Square(int firstAngle, int secondAngle) : base(firstAngle, secondAngle)
    {
    }
    public void GetSquare()
    {
        Console.WriteLine(FirstAngle * SecondAngle);
    }
}