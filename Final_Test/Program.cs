/* Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] GetInputArrayFromUser()
{
    Console.Write("Введите количество элементов масcива строк: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    string[] inputArray = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine($"Введите элемент массива строк с индексом {i}: ");
        inputArray[i] = Console.ReadLine();
    }
    return inputArray;
}

string[] UpTo3SymbolsSortArray(string[] inputArray)
{
    string[] resultArray = new string[inputArray.Length];
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[count] = inputArray[i];
            count++;
        }
    }
    Array.Resize(ref resultArray, count);
    return resultArray;
}

void PrintStringResultArray(string[] inputArray)
{
    Console.Write("[");
    Console.Write(string.Join(", ", inputArray));
    Console.WriteLine("]");
}

Console.WriteLine("Привет! Эта программа находит элементы массива строк, количество символов в которых меньше или равно трем, и создает новый массив из этих элементов");
string[] userArray = GetInputArrayFromUser();
string[] upTo3SymbolsSortedArray = UpTo3SymbolsSortArray(userArray);
Console.WriteLine("Новый массив с элементами, число символов в которых меньше или равно трем:");
PrintStringResultArray(upTo3SymbolsSortedArray);

