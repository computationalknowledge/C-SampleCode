using System;

class program
{
    public static void Main()
    {
        Console.WriteLine(a());  
        Console.WriteLine(b());
        Console.WriteLine(c());

    }

    public static  bool a()
    {
        char c = 'a'; char d = 'a';

        if (c == d) return true;

        return false;
    }

    public static bool b()
    {
        string c = "a"; string d = "a";

        if (c == d) return true;

        return false;
    }

    public static bool c()
    {
        String c = "a"; String d = "a";

        if (c == d) return true;

        return false;
    }
}
