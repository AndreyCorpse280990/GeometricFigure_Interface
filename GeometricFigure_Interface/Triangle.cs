namespace GeometricFigure_Interface;

// Класс треугогольник
public class Triangle : GeometricFigure, IPrintable, IDrawable
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

    public new void Print()
    {
        Console.WriteLine(ToString());
    }
    
   
    public void Draw()
    {
        int baseLength = (int)Math.Round(SideC) * 2; // 
        int height = baseLength / 2; // Высота треугольника равна половине его длины

        // Отступы перед первой строкой звездочек
        int initialSpaces = baseLength / 2;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < initialSpaces - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
};