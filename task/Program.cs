// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритм


Console.WriteLine("Enter first array size:");
int length = Convert.ToInt32(Console.ReadLine());
string [] GetArray (int size)
{
    string [] array = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Enter element:");
        array [i] = Console.ReadLine();
    }    
    return array;
}

 
string [] array = GetArray(length);
Console.WriteLine($"Your array is: [{string.Join("; ", array)}]");

void GetNewArray (int size, string[] firstArray)
{
    string [] result = new string[size];
    int maxValue = 3;
    int count = 0;
    System.Console.Write("Result: ");
    for (int i = 0; i < size; i++)
    {
        if (firstArray[i].Length <=  maxValue) 
        {
            result[i] = firstArray[i];
            count ++;
            Console.Write(result[i] + "; ");
        }
    }
    if (count == 0) Console.WriteLine("there is no elements with 3 or less symbols"); 
}
GetNewArray(length,array);
