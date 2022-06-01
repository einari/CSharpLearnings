using ScaryStuff.Weather;

namespace ScaryStuff;

public class ListOfShapes
{
    public static void Execute()
    {
        var shapes = new Shape[]
        {
            new Box(),
            new Circle(),
            new Triangle()
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}