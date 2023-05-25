// Задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом 
// массива

//Random rand = new Random();
//Console.WriteLine(Math.Round(rand.Next(0,100) + rand.NextDouble(),4));

 double [] FillArray(int size, int leftRange, int rightRange)
 {
     double[] tempArray = new  double[size];
     Random rand = new Random();
     for(int i=0; i < size; i++)
     {
        tempArray [i] = Math.Round((rand.Next(leftRange, rightRange +1) + rand.NextDouble()),3);
     }
     return tempArray;
 }
  double[] array = FillArray(4, 1,10);

  double max = array[0];
  double min = array[0];
  for(int i = 0; i < array.Length; i ++)
    { 
        if(max < array[i]) max = array[i];
        if(min > array[i]) min = array[i]; 
    }
 

void RrintArray(double[]arr)
{
   Console.WriteLine("["+ string.Join("  ",arr) + "]"); 
}


RrintArray(array);

Console.WriteLine($"Максимальное значение элемента массива равно: {max}");
Console.WriteLine($"Минимальное значение элемента массива равно: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {Math.Round((max-min),3)}");
