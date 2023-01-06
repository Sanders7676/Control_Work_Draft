// Вариант решения для массива из чисел


Console.WriteLine();

Console.Write("Ведите количество элементов в массиве: ");

int lengthOfFirstArray = InputInt();

int[] array = new int[lengthOfFirstArray];

int[] arrayFirst = FillArray(array);

Console.WriteLine();

Console.WriteLine("Введенный массив выглядит следующим образом:");

PrintArray(arrayFirst);

Console.WriteLine();

Console.Write("Ведите ограничивающее значение для элементов массива: ");

int limitingValue = InputInt();

int[] desiredArray = FillingArrayWithGivenElementSize(arrayFirst, limitingValue);

Console.WriteLine();

if (desiredArray.Length == 0)
{
    Console.WriteLine("В новом массиве отсутствуют элементы.");
}
else
{
    Console.WriteLine("Новый массив, состоящий из элементов, удовлетворяющих заданному ограничению, выглядит следующим образом:");
    PrintArray(desiredArray);
}

Console.WriteLine();



// Метод заполнения массива с определенным размеров элементов

int[] FillingArrayWithGivenElementSize(int[] arrayFirst, int limitingValue)
{
    // Находим какой будет длина искомого массива
    
    int lengthOfSecondArray = 0;

    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i] <= limitingValue)
        {
            lengthOfSecondArray++;
        }
    }

    // Заполняем искомый массив элементами в соответствии с установленным ограничением

    int[] arraySecond = new int[lengthOfSecondArray];

    int iSecond = 0;

    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i] <= limitingValue)
        {
            arraySecond[iSecond] = arrayFirst[i];

            iSecond++;
        }
    }
    return arraySecond;
}



// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);

    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}



//метод заполнения массива числами, вводимыми через консоль

int[] FillArray(int[] arr)
{
    Console.WriteLine();

    Console.WriteLine("Введите значения элементов массива:");

    Console.WriteLine();

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите значение {i + 1}-го элемента: ");

        int num = int.Parse(Console.ReadLine());

        arr[i] = num;
    }
    return arr;
}



//Метод печати массива

void PrintArray(int[] array)
{
    Console.WriteLine($"[ {string.Join(", ", array)} ]");
}