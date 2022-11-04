// Задача25. Написать цикл, который принимает на вход два числа (А и В) и возводит
// число А в натуральную степень В.

Console.WriteLine("Введите два числа");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
  
int step = A;
   
    for (int i = 1; i < B; i++)
    {
        step = step * A;
    }
        
Console.WriteLine($"stepen = {step}");