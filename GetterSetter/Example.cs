using System;

interface IShape
{

public float GetArea();
 public float GetPerimeter();
}
class Rectangle: IShape
{
    public Rectangle(float l, float b)
    {
        length = l;
        width = b;
    }
    float length;
    float width;


    public float GetArea() => length * width;
    public float GetPerimeter() => 2 * (length + width);


}

class Square: Rectangle
{
    public Square(float s): base(s,s)
    {

    }

}



class Circle: IShape
{
    public float radius;
    public Circle(float radius) => radius = radius;

    public float GetArea() => Math.PI * radius *radius;
    public float GetPerimeter() => 2 * Math.PI * radius;

}