namespace GeometricFigure_Interface;

public class Scene
{
    private List<GeometricFigure> figures;

    public Scene()
    {
        figures = new List<GeometricFigure>();
    }

    public void AddFigure(GeometricFigure figure)
    {
        figures.Add(figure);
    }

    public void DrawScene()
    {
        foreach (var figure in figures)
        {
            if (figure is IDrawable drawableFigure && figure is IPrintable printableFigure)
            {
                drawableFigure.Draw();
                printableFigure.Print();
            }
            else if (figure is IPrintable)
            {
                ((IPrintable)figure).Print();
            }
            else
            {
                Console.WriteLine("Фигура не может быть нарисована и не имеет метода Print.");
            }
        }
    }
}