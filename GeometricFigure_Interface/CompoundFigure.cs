namespace GeometricFigure_Interface;

// Класс составная фигура
public class CompoundFigure : GeometricFigure
{
    private List<GeometricFigure> figeres = new List<GeometricFigure>(); // список фигур
            
    //Метод для добавления фигуры в составную фигуру
    public void AddFigure(GeometricFigure figure)
    {
        figeres.Add(figure);
    }
            
    // Метод для вычисления общей площади всех фигур
    public override double GetArea()
    {
        return figeres.Sum(figure => figure.GetArea());
    }
            
    // Метод для вычисления общего периметра всех фигур
    public override double GetPerimeter()
    {
        return figeres.Sum(figure => figure.GetPerimeter());
    }
}