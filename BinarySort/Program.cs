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

Console.WriteLine("Sorting Started");

for(int i = 1 ; i < numbers.Count ; ++i)
{
    int key = numbers[i];
    int j = i - 1;

    while(j >=1 && numbers[j] > key)
    {
        numbers[j + 1] = numbers[j];
        j--;
    }
    numbers[j + 1] = key;    
}

for (int i = 1; i < numbers.Count; ++i)
{
    Console.WriteLine(numbers[i]);
}



Console.ReadLine();

