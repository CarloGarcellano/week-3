using System;

class Program
{
    static void Main()
    {
        // 1. countdown from 10 to 1 (for loop)
        // for (int i = 10; i >= 1; i--)
        // {
        //     Console.WriteLine(i);
        // }

        // 2. print odd numbers from 1 to 50 (while loop)
        // int o = 1;
        // while (o <= 50)
        // {
        //     Console.Write(o + " ");
        //     o += 2;
        // }
        // Console.WriteLine();

        // 3. power of a number (do while loop)
        // int baseNum = 2, exponent = 5;
        // int result = 1;
        // int k = 1;
        // do
        // {
        //     result *= baseNum;
        //     k++;
        // } while (k <= exponent);
        // Console.WriteLine(result);

        // 4. Sum of squares of first 10 natural numbers (for loop)
        // int sq = 0;
        // for (int i = 1; i <= 10; i++)
        // {
        //     sq += i * i;
        // }
        // Console.WriteLine(sq);

        // 5. sum of odd digits in a number (for loop)
        int num = 123456789;
        int sod = 0;
        string strNum = num.ToString();
        for (int i = 0; i < strNum.Length; i++)
        {
            int digit = strNum[i] - '0';
            if (digit % 2 != 0)
                sod += digit;
        }
        Console.WriteLine(sod);
    }
}
    