// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("What is the max number");
int maxNumber = Convert.ToInt32(Console.ReadLine());

List<int> numbers = new List<int>();
Random random = new Random();

for (int i = 1 ; i <= maxNumber;i++)
{
    var number = random.Next(1, maxNumber);
    numbers.Add(number);
}

for(int i = 1 ; i <= numbers.Count ;i ++)
{
    Console.WriteLine(numbers[i-1]);
}

Console.ReadLine();

