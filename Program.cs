// Задача 25.
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Math.Pow не использовать
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
void DegreeNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

Console.WriteLine("Input your first number A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your first number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

DegreeNumber(numA, numB);
*/
// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int user_num){
    
    int counter = Convert.ToString(user_num).Length;
    int diff = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      diff = user_num - user_num % 10;
      result = result + (user_num - diff);
      user_num = user_num / 10;
    }
   return result;
  }

int sumNumber = SumNumber(user_num);
Console.WriteLine("Sum digits of number: " + sumNumber);
*/
// Задача 29: Напишите программу, которая задаёт массив из 
// произвольного количества элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreatNewArray (int size_array)
{
    int [] randomArray = new int[size_array];                                             
    for (int i = 0; i < size_array; i++)
    {
        randomArray[i] = new Random().Next(1, 9); 
    }
    return randomArray;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input size array: ");
int size_array = Convert.ToInt32(Console.ReadLine());

int [] arrayNew = CreatNewArray(size_array);
ShowArray(arrayNew);
