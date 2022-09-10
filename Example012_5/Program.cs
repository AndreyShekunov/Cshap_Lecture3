// Задача сортировки массива методом выбора (по другому сортировка методом минимакса)
//Смысл алгоритма
//6 8 3 2 1 4 5 7
//1 8 3 2 6 4 5 7 - первый проход
//1 2 3 8 6 4 5 7 - второй проход
//1 2 3 8 6 4 5 7 - третий проход
//1 2 3 4 6 8 5 7 - четвертый проход
//1 2 3 4 5 8 6 7 - пятый проход
//1 2 3 4 5 6 8 7 - шестой проход
//1 2 3 4 5 6 7 8 - седьмой проход

int[] arr = { 15, 5, 4, 3, 2, 6, 7, 1, 1 }; // массив, который будем отсортировывать

// метод для вывода массива на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// пишем метод, который будет упорядочивать массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr); // вывод исходного массива { 1, 5, 4, 3, 2, 6, 7, 1, 1 }
SelectionSort(arr); // вызов метода упорядочивания массива
PrintArray(arr); // выводится упорядоченный массив

