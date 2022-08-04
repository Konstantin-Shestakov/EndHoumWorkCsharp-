____
# Итоговая проверочная работа
____

    Программный код написана на языке С#. Он решает следующую задачу:
           написать программу, которая из имющегося массива формирует массив из строк, длина которых меньше либо равно 3 символа.

## **Решение**
![Влок-схема](BShema.jpg)  


 Задаем массив из строк

    string[] UserWrite = {"-65", "5", "World", "China", "-25", "Donbass", ":-)", "Car"};
Создаем итоговый массив, получая его из метода Array, разделенных элементов зяпятой и пробелом, удовлеворяющие условию задачи:


    string[] ResultArrey = Array(UserWrite).Split(", ", StringSplitOptions.RemoveEmptyEntries);

Объявляем метод Array, который принимает массив UserWrite и при помощи цикла for перебирает все элементы массива, проверяя их, вложенным в него логическим оператором if выполнение уловия задачи. Если длина симовлов элемента массива менее или равно 3, тогда оно записывается в переменную result. Метод возращает значение переменной result:
    
    
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

Выводим на печать в консоль оба массива: исходный UserWrite и итоговый ResultArray:

    Console.Write("[" + string.Join(", ", UserWrite) + "]" + " -> "+"[" + string.Join(", ", ResultArrey) + "]");















     
