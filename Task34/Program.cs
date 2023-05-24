// Задача 34. Задайте массив заполненный случаными положительными числами.
//напишите программу,которая кокажет количество четных чисел 

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i=0; i < size; i++)
    {
       tempArray [i]= rand.Next(leftRange, rightRange +1);
    }
    return tempArray;
}
int CoutElem(int[] array)
{
    int count = 0;
    for(int i =0; i < array.Length; i ++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

void RrintArray(int[]arr)
{
   Console.WriteLine("["+ string.Join(",",arr) + "]"); 
}

int[] arr = FillArray(10, 100,1000);
RrintArray(arr);
CoutElem(arr);
Console.WriteLine($"Количество трехзначных положительных чисел: {CoutElem(arr)}"); 









