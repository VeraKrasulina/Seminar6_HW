// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите числа через пробел: ");
string imput = Console.ReadLine();

int[] ConvertToIntArrey(string text, char separator)
{
    string[] imput = text.Split(separator);
    int[] numbers = new int[imput.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        int j;
        string temp = imput[i];
        if (int.TryParse(temp, out j)) { numbers[i] = j; }
    }
    return numbers;
}

int[] output = ConvertToIntArrey(imput, ' ');

int counter = 0;
for (int i = 0; i < output.Length; i++)
{
    counter += output[i] > 0 ? 1 : 0;
}

Console.WriteLine($"Количество чисел больше 0 в этом списке - {counter}.");