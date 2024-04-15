namespace GeometricFigure_Interface;

public abstract class GeometricFigure
{
    protected string Name { get; set; } // имя фигуры
            
    // методы для получения площади и периметра
    public abstract double GetArea();
    public abstract double GetPerimeter();
            
    // перегрузка ToString
    public override string ToString()
    {
        return $"Фигура: {Name}\nПлощадь: {GetArea()}\nПериметр: {GetPerimeter()}";
    }

    public virtual void Print()
    {
        Console.WriteLine(ToString());
    }
}