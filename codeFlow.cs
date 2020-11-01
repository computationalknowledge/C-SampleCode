using System; class sample
{
public static void first()
{
Console.WriteLine("first method");
}
public void second()
{
first();
Console.WriteLine("second method");
}
public void second(int i)
{
Console.WriteLine(i); second();
}
}
class program
{
public static void Main()
{
sample obj = new sample(); sample.first(); obj.second(10);
}
}
