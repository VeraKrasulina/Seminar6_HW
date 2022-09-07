// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// y = k1 * x + b1              
// y = k2 * x + b2        
// y - y = (k1 * x + b1) - (k2 * x + b2)  >>> 0 = (k1 - k2) * x + (b1 - b2) >>> (k1 - k2)* x = -(b1 - b2) >>> x = -(b1 - b2) / (k1 - k2)                                          
Console.Write("Введите первую переменную для прямой А: ");
double variableA1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите вторую переменную для прямой А: ");
double variableA2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первую переменную для прямой B: ");
double variableB1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите вторую переменную для прямой B: ");
double variableB2 = Convert.ToDouble(Console.ReadLine());

if (variableA1 == variableB1)
{ 
    Console.WriteLine("Линии параллельны и пересечений не имеют");
}
else
{
    double crossCoordX = -(variableA2 - variableB2) / (variableA1 - variableB1);
    double crossCoordY = variableA1 * crossCoordX + variableA2;
    Console.WriteLine($"Линии пересекутся в точке ({Math.Round(crossCoordX, 2)} {Math.Round(crossCoordY, 2)}).");
}
