using System;

// README.md를 읽고 코드를 작성하세요.


Shape[] shapes =
{
    new Circle(5),
    new Circle(15),
    new Rectangle(4, 6),
    new Rectangle(5, 5),
    new Square(7)
};

Console.WriteLine("=== 도형 분류기 ===");
foreach (var shape in shapes)
{
    string label = shape switch
    {
        Circle c => $"원(반지름: {c.Radius})",
        Rectangle r => $"직사각형({r.Width}x{r.Height})",
        Square s => $"정사각형({s.Side})",
        _ => "도형"
    };

    string classify = ShapeClassifier.ClassifyShape(shape);
    double area = ShapeClassifier.CalculateArea(shape);
    Console.WriteLine($"{label}: {classify}, 넓이: {area:F2}");
}




class Shape { }


class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius) => Radius = radius;
}


class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height) { Width = width; Height = height; }
}


class Square : Shape
{
    public double Side { get; set; }
    public Square(double side) => Side = side;
}

static class ShapeClassifier
{
    public static double CalculateArea(Shape shape) => shape switch
    {
        Circle c => Math.PI * c.Radius * c.Radius,
        Square s => s.Side * s.Side,
        Rectangle r => r.Width * r.Height,
        _ => 0
    };


    public static string ClassifyShape(Shape shape) => shape switch
    {
        Circle { Radius: >= 10 } => "큰 원",
        Circle => "작은 원",
        Rectangle { Width: var w, Height: var h } when w == h => "정사각형 모양의 직사각형",
        Rectangle => "일반 직사각형",
        Square => "정사각형",
        _ => "알 수 없는 도형"
    };
}
