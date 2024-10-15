using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {
        Console.WriteLine("QUESTION 1");
        Console.WriteLine("OUTPUT:");
        print_2d_array();

        Console.WriteLine("\nQUESTION 2");
        Console.WriteLine("OUTPUT:");
        string m_res = merger();
        Console.WriteLine(m_res);

        Console.WriteLine("\nQUESTION 3");
        Console.WriteLine("OUTPUT:");
        string[] w_res = find_words("this is an example of a string with words like hello and demo");
        foreach (string w in w_res)
        {
            Console.WriteLine(w);
        }

        Console.WriteLine("\nQUESTION 4");
        Console.WriteLine("OUTPUT:");
        summarize_ratings();

        Console.WriteLine("\nQUESTION 5");
        Console.WriteLine("OUTPUT:");
        convert_numbers();

        Console.WriteLine("\nQUESTION 6");
        Console.WriteLine("OUTPUT:");
        display_marks();

        Console.WriteLine("\nQUESTION 7");
        Console.WriteLine("OUTPUT:");
        multiply_matrices();
    }

    static void print_2d_array()
    {
        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static string merger()
    {
        string[] s = { "hello ", "and ", "welcome ", "to ", "this ", "demo! " };
        string r = "";
        for (int i = 0; i < s.Length; i++)
        {
            r += s[i];
        }
        return r;
    }

    static string[] find_words(string str)
    {
        List<string> lst = new List<string>();
        string[] wrds = str.Split(' ');
        for (int i = 0; i < wrds.Length; i++)
        {
            if (wrds[i].Length >= 4 && wrds[i].Length <= 5)
            {
                if (wrds[i].Contains("a") || wrds[i].Contains("e") || wrds[i].Contains("i") || wrds[i].Contains("o") || wrds[i].Contains("u"))
                {
                    lst.Add(wrds[i]);
                }
            }
        }
        return lst.ToArray();
    }

    static void summarize_ratings()
    {
        int[] rtngs = { 2, 2, 3, 4, 3, 4, 5, 3, 4, 5, 3, 4, 2, 2, 3, 4, 4, 3, 5, 3, 3, 4, 4, 3, 2, 4, 3, 2, 3, 5, 4, 2, 3, 4, 2, 4, 3, 3, 5, 2 };
        int[] freq = new int[5];

        for (int i = 0; i < rtngs.Length; i++)
        {
            freq[rtngs[i] - 1]++;
        }

        for (int i = 0; i < freq.Length; i++)
        {
            Console.WriteLine("Response " + (i + 1) + " given by: " + freq[i] + " people");
        }
    }

    static void convert_numbers()
    {
        int dec = 10;
        string bin = dec_to_bin(dec);
        Console.WriteLine("Binary: " + bin);

        int new_dec = bin_to_dec(bin);
        Console.WriteLine("Decimal: " + new_dec);
    }

    static string dec_to_bin(int n)
    {
        string b = "";
        while (n > 0)
        {
            b = (n % 2) + b;
            n = n / 2;
        }
        return b;
    }

    static int bin_to_dec(string b)
    {
        int d = 0;
        int p = 1;
        for (int i = b.Length - 1; i >= 0; i--)
        {
            d += (b[i] - '0') * p;
            p *= 2;
        }
        return d;
    }

    static void multiply_matrices()
    {
        int[,] a = {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };
        int[,] b = {
        { 9, 8, 7 },
        { 6, 5, 4 },
        { 3, 2, 1 }
    };

        int[,] r = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                r[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    r[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        Console.WriteLine("Resultant Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(r[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void display_marks()
    {
        int[,] m = new int[5, 10]
        {
        { 92, 73, 86, 71, 97, 93, 95, 97, 80, 91 },
        { 90, 86, 81, 80, 78, 78, 80, 82, 88, 88 },
        { 99, 97, 89, 100, 77, 70, 80, 78, 78, 97 },
        { 79, 95, 79, 77, 84, 71, 91, 79, 84, 78 },
        { 72, 82, 97, 88, 90, 88, 80, 82, 83, 80 }
        };

        Console.WriteLine("Student  1   2   3   4   5   6   7   8   9   10");
        

        for (int r = 0; r < 5; r++)
        {
            Console.Write("Test " + (r + 1) + " ");
            for (int c = 0; c < 10; c++)
            {
                Console.Write(m[r, c] + " ");
            }
            Console.WriteLine();
        }

        Console.Write("Avg. ");
        for (int c = 0; c < 10; c++)
        {
            int sum = 0;
            for (int r = 0; r < 5; r++)
            {
                sum += m[r, c];
            }
            Console.Write(sum / 5 + " ");
        }
        Console.WriteLine();
    }
}
