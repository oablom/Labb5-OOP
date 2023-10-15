
Circle cirkel1 = new Circle(5);
Circle cirkel2 = new Circle(6);

Console.WriteLine(cirkel1.GetCircleArea());
Console.WriteLine(cirkel2.GetCircleArea());

class Circle
{
    int _Radius;
    float _pi = 3.141f;
    public Circle(int radie)
    {
        _Radius = radie;


    }
    public float GetCircleArea()
    {
        return _Radius * _Radius * _pi;
    }

}
