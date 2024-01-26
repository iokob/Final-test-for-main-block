string[] array = new string[5];
Console.WriteLine("* * * Введите массив из 5 строк, разделяя каждый элемент enter * * *");
void FillArrayFromConsole(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = Console.ReadLine();
    }
}

void printArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.WriteLine(array[i]);
    }
}

string[] processingArray(string[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        //считаем размер результирующего массива
        if (array[i].Length <= 3) {
            count++;
        }
    }
    //создаём выходной массив, который будет результирующий
    string[] rezArray = new string[count];
    //обнуляем счётчик
    count = 0;
    //наполняем результирующий массив строками меньше или равными 3
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            rezArray[count] = array[i];
            count++;
        }
    }
    //осталось только возвратить результативный массив
    return rezArray;
}

FillArrayFromConsole(array); //заполняем исходный массив
string[] rezArray = processingArray(array); //результативный массив создаётся 
//путём обработки исходного массива
printArray(rezArray); //вывод конечного массива в консоль