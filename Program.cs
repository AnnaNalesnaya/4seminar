// Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе. 


int Prompt(string message)
{
    Console.WriteLine(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int SumOfNambers(int numbr)
{
    int result = 0;
    while (numbr > 0)
    {
     result += numbr % 10;
     numbr = numbr / 10;       
    }
     return result;
}
int num = Prompt("введите число ");
     if (num >= 0)
{
    Console.WriteLine($" {num} -> {SumOfNambers(num)}");
}
else Console.WriteLine("не корректный ввод");