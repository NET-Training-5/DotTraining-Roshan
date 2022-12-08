using Fundamentals1;

internal class NewBaseType
{
    private static void Main(string[] args)
    {
        byte age = 23;
        string name = "Ram";
        var m = name + "ïs" + age + "years old";
        var n = $"{name}is{age}years old"; // string interpolation.

        Console.WriteLine(m);
        Console.WriteLine(n);


        Methods a = new();
        a.PrintMessage();

        a.Print("nepal");

        var hello = a.GetMessage();
        Console.WriteLine(hello);

        var sum = a.Add(10.23, 20.23);
        Console.WriteLine(sum);

        var average = a.Numbers(10, 20, 30);
        object value = Console.WriteLine(average);

        string[] value1 = { "Ram", "shyam", "hari" };

        a.FindMinMax();




        Drawing.Gen = new();
        Gen.DrawPattern();
        Gen.DrawPattern2();

        var (min, max) = Gen.FindMinMax(2, 453, 23, 53, 1, 24, 1, 3434, 21, 2);
        System.Console.WriteLine( $"Min:{min} Max:{max}");

    }
}



//takes argunents or not , returns multiple values


