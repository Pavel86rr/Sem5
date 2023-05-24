//Задача36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элнментов, стоящих на нечетных позициях

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
int SumElem(int[] array)
{
    int sum = 0;
    for(int i =1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void RrintArray(int[]arr)
{
   Console.WriteLine("["+ string.Join(",",arr) + "]"); 
}

int[] arr = FillArray(8, 1,10);
RrintArray(arr);
SumElem(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях равна: {SumElem(arr)}"); 
