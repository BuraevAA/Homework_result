/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести
с клавиатуры, либо задать на страте выполнения алгоритма. При решении не 
пользоваться коллекциями, лучше обойтись исключительно массивами*/
Console.Clear();
Console.WriteLine("Введите количество элементов массива"); 
int count = Convert.ToInt32(Console.ReadLine()); 
void FillArray(string[] array) 
{ 
    for (int j = 0; j < array.Length; j++) 
    { 
        Console.WriteLine("Введите строку"); 
        array[j] = Console.ReadLine(); 
    } 
} 
void PrintArray(string[] array) 
{ 
    for (int j = 0; j < array.Length; j++) 
    { 
        Console.Write("''"+array[j]+"'', "); 
    } 
} 
void FilterArray(string[] list) 
{ 
    for (int i = 0; i < list.Length; i++) 
    { 
        if(list[i].Length <= 3) 
        Console.Write("''"+list[i]+"'', "); 
    }  
}
string[] array = new string[count]; 
FillArray(array); 
PrintArray(array); 
Console.WriteLine(); 
FilterArray(array);