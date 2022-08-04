// Написать программу, которая из имющегося массива формирует массив из строк, 
// длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры 
// либо задать на старте выполнения алгоритма.
// [hello, 2, world, :-0] -> [2,:-)]


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите массив строк через пробел");
        string[] UserWrite = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] ResultArrey = Array(UserWrite).Split(", ", StringSplitOptions.RemoveEmptyEntries);
          string Array(string[] array)
        {
             string result = "";
            for (int i = 0; i < UserWrite.Length; i++)
            {
                if (UserWrite[i].Length <= 3)
                {
                    result = result + UserWrite[i]+ ", ";
                }
            }
             return result;
         }
           Console.Write("[" + string.Join(", ", UserWrite) + "]" + "->"+"[" + string.Join(", ", ResultArrey) + "]");
     }
}