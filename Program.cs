using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
//Read n1 and n2 from the user
System.Console.WriteLine("Enter n1");
int n1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter n2");
int n2 = int.Parse(Console.ReadLine());
//Find and print the perfect numbers n2 to n2
System.Console.WriteLine("Perfect numbers from"+n1+"to"+n2+":");
for (int i = n1; i <=n2; i++)
{
    
}
        }
if (IsPerfectNumber(i))
{
    System.Console.WriteLine(i);
}
//Returns true if given number is a perfect,false overwise static bool Is PerfectNumber(int n)
        {
int sum = 0;
for (int i =1; i < n; i++)
{
    sum+=i;
}
        }
        return sum == n;
    }
 }
}


    
