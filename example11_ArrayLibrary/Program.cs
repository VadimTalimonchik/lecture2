// Методы

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index = index + 1; // index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[10]; // 1. создаём (определяем) новый массив с 10-ю элементами

// FillArray(array); // 2. вызвали метод FillArray, который заполнил массив
// PrintArray(array); // 3. метод PrintArray вывел (распечатал) массив


// Адаптируем решение задачи нахождения элемента массива
// с использованием метода. Опишем его отличным от метода void.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 4;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index = index + 1; // index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // ... (начало на строке 84) чтобы такого не происходило,
                      // надо 0 (было ранеее) заменить на -1. Вывод при ошибке
                      // будет -1, что будет указывать на ошибку.
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;  // для того, чтобы при нахождении первого значения (при
                    // одинаковых значениях в массива) цикл прекращал работу
                    // и выводи его одно.
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // 1. создаём (определяем) новый массив с 10-ю элементами

FillArray(array); // 2. вызвали метод FillArray, который заполнил массив
array[4] = 4;
array[6] = 4;

PrintArray(array); // 3. метод PrintArray вывел (распечатал) массив
Console.WriteLine(); // вывод пустой строки

int pos = IndexOf(array, 4); // !!! есть проблемы, если указать число которое не существует в массиве,
                             // то вывод будет 0 (далеее смотреть строку 60)...
Console.WriteLine(pos);
