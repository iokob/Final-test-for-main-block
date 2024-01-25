string[] array = new string[5];
Console.WriteLine("* * * Введите массив из 5 строк, разделяя каждый элемент enter * * *");
void FillArrayFromConsole(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = Console.ReadLine();
    }
}

void testPrintArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.WriteLine(array[i]);
    }
}

FillArrayFromConsole(array);
testPrintArray(array);