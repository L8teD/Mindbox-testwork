using Mindbox.Task;

IFigure figure = null;

Console.WriteLine("Введите цифру:\n1 - треугольник\n2 - круг");
string input = Console.ReadLine();

switch (input)
{
    case ("1"):
        figure = new Triangle(5, 5, 5);
        break;
    case ("2"):
        figure = new Circle(5);
        break;
    default:
        Console.WriteLine("Неверный ввод");
        break;
}

Console.WriteLine(figure?.GetArea());

Console.ReadKey();


