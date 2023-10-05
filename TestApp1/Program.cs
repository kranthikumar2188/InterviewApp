//1) Write a program that loops through [1..100].It should do the following:
//a) If the number is divisible by 3, print “fizz”.
//b) If divisible by 5 print “buzz”.
//c) If divisible by 3 & 5, print “fizzbuzz"


for(int i=1; i <= 100; i++)
{
    if(i % 3 ==0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if(i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

//2) Write a program to reverse a string “abcdef” --> “fedcba” without using the.NET
//reverse() function
//Prompt for the input from console and display the output to the console.

Console.Clear();

string input = Console.ReadLine();

string reversed = ReverseString(input);

Console.WriteLine(reversed);

static string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();

    int l = charArray.Length;
    for(int i = 0; i < l/2; i++)
    {
        char temp = charArray[i];
        charArray[i] = charArray[l - i -1];
        charArray[l - i - 1] = temp;
    }

    return new string(charArray);
}