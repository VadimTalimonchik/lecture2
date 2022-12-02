// int[] array = {1, 12, 31, 4, 15, 16, 17, 18};

// int n = array.Length;
// int find = 16;

// int index = 0;

// while(index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//     }
//     // index = index + 1; // на каждом этапе увеличиваем index на 1
//     index++;
// }

// Улучшения (в прошлом варианте если в массиве будет два
// одинаковых значения, то в выводе будет два индекса
// соответственно этих чисел, чтобы это исправить, нам
// понадобиться новый оператор)
int[] array = {1, 12, 16, 31, 4, 15, 16, 17, 18};

int n = array.Length;
int find = 16;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;  // будет выводиться первый элемент
    }
    // index = index + 1; // на каждом этапе увеличиваем index на 1
    index++;
}
