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


//---------------------------------основная программа------------------------------------
string [] arr = Generate_array();


