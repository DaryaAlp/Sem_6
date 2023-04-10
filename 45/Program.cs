/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

 Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] copyArray = CopyArray(array);
Console.WriteLine(String.Join(" ", CopyArray(array)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];

    }
    return result;
}

/*int[] ArrayAll = GenerateArray(); // задаем инфу для метода создания массива
        Console.WriteLine($"[{String.Join(", ", ArrayAll)}]");
        int[] newArray2 = copyMe(ArrayAll, ArrayAll.Length);
        Console.WriteLine($"[{String.Join(", ", newArray2)}]");

        int[] GenerateArray() // генератор массива с произвольными числами
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = new Random().Next(-100, 100);
            }
            return array;
        }

        int[] copyMe(int[] array, int len)
        {
            int[] newArray = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }*/