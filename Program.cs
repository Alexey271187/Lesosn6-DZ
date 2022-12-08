// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Программа для поиска и написания массива строк длинной 3 и менее символов");

string[] array = NewArray();
string[] result = Search(array, 5);

string[] NewArray() 
{
    Console.Write("Введите текст: ");
    return Console.ReadLine()!.Split(" ");
}

string[] Search(string[] input, int n) 
{
    string[] output = new string[CreateNewArray(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CreateNewArray(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");