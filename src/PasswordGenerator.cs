using System;

namespace PassMan;

public class PasswordGenerator
{
    public static string Generate(bool lower, bool upper, bool numbers, bool symbols, bool ambiguous, int length)
    {
        var pool = "";
        if (lower)
        {
            pool += "abcdefghijklmnopqrstuvwxyz";
        }
        if (upper)
        {
            pool += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
        if (numbers)
        {
            pool += "0123456789";
        }
        if (symbols)
        {
            pool += "@#$%?!";
        }
        if (ambiguous)
        {
            pool += "{}[]()/\\\'\"´`~,;.:<>§*+";
        }

        var random = new Random();
        var output = "";
        if (pool.Length == 0)
        {
            return output;
        }

        for (var i = 0; i < length; i++)
        {
            output += pool[random.Next(pool.Length)];
        }
        return output;
    }
}