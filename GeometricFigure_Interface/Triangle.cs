namespace GeometricFigure_Interface;

// Класс треугогольник
public class Triangle : GeometricFigure, Iprintable, IDrawable
{
    private double SideA { get; }// длина стороны А
    private double SideB { get; }// длина стороны B
    private double SideC { get; }// длина стороны C
    private double Height { get; }
            
    // конструктор
    public Triangle(string name, double a, double b, double c)
    {
        this.Name = name;
        this.SideA = a;
        this.SideB = b;
        this.SideC = c;
    }
            
    // Метод для получения площади
    public override double GetArea()
    {
        // формула Герона
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
            
    // Метод для получения периметра
    public override double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }

    public void Print()
    {
        Console.WriteLine(ToString());
    }
    
   
    public void Draw()
    {
      
    }
    
    
};