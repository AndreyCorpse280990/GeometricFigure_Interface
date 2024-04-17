namespace GeometricFigure_Interface;

// Класс квадрата
public class Square : GeometricFigure, IPrintable
{
    private double Length { get; } // длина стороны
            
    // конструктор
    public Square(string name, double length)
    {
        this.Name = name;
        this.Length = length;
    }
            
    // Метод для получения площади
    public override double GetArea()
    {
        return Length * Length;
    }
            
    // Метод для получения периметра
    public override double GetPerimeter()
    {
        return Length * 4;
    }

    public new void Print()
    {
        Console.WriteLine(ToString());
    }
}