// 82.C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
Console.Write("Введите строку: ");
string str = Console.ReadLine();
int k = 0;
foreach(char c in str)
{
    if(c != '.') k++;
    else break;
}
System.Console.WriteLine($"Количество символов до точки: {k}");
