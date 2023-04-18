Console.Write("Введите количество элементов массива:\t");
int elementCount = int.Parse(Console.ReadLine()!);

string[] myArray = new string[elementCount];

void FillArray(string[] myArray)
{
  for (int i = 0; i < myArray.Length; i++)
  {
    Console.Write($"\nВведите элемент массива под индексом {i}:\t");
    myArray[i] = (Console.ReadLine()!);

  }
  Console.WriteLine();
}

void PrintArray(string[] myArray)
{
  for (int i = 0; i < myArray.Length; i++)
  {
    Console.Write($"{myArray[i]} ");
  }
}


string[] NewArray(string[] myArray)
{
  int count = 0;

  for (int i = 0; i < myArray.Length; i++)
  {
    if (myArray[i].Length <= 3)
      count++;
  }

  string[] arr = new string[count];
  int j = 0;

  for (int i = 0; i < myArray.Length; i++)
  {
    if (myArray[i].Length <= 3)
    {
      arr[j] = myArray[i];
      j++;
    }
  }
  return arr;

}

FillArray(myArray);
Console.WriteLine("Вывод массива: ");
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Вывод преобразованного массива: ");
PrintArray(NewArray(myArray));
