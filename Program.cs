// Задача: написать программу которая из имеющегося массива создаст массив из элементов которые короче или равны трем символам

string [] Generate_array()
{ 
    string [] array = new string [10];
    for (int i=0; i<10; i++)
    {
        Console.WriteLine("Введите элемент массива");
        array [i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void Search_data(string [] array)
{
string [] arr = new string [10];
Console.Write("Массив array [");
for (int i=0; i<array.Length; i++)
{
    string l = array[i];
    int n = l.Length;
    if (n<4) 
    {
        arr[i] = array[i];
        Console.Write(arr[i] + " ");
    }
}
Console.Write("]");
}
//---------------------------------основная программа------------------------------------
string [] arr = Generate_array();
Search_data(arr);

