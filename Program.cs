using System;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata.Ecma335;

class Palindrome
{
    static void Main()
    {
        Console.WriteLine("palindrome checker");
        Solve solve = new Solve();
        solve.Getinput();
        solve.palindromeChecker();
        bool isPalindrome = solve.palindromeChecker();
        Console.WriteLine($"Is It Palindrome : {isPalindrome}");
    }
}

public class Solve
{
    private string ?input = "";

    public void Getinput()
    {
        Console.Write("silahkan masukan kata yang akan di cek menggunakan palindrome checker : ");
        input = Console.ReadLine();
    }
    public bool palindromeChecker()
    {
        int pointer1 = 0;
        int pointer2 = input.Length - 1;
        while (pointer2 > pointer1)
        {
            if (input[pointer1] != input[pointer2])
            {
                return false;
            }
            pointer1++;
            pointer2--;
        }
        return true;
    }
}


