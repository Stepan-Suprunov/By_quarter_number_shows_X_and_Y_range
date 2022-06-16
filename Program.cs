// По номеру четверти показывает диапазон X и Y.

Console.WriteLine("Введите номер четверти:");
int Quater = int.Parse(Console.ReadLine());

if (Quater == 1)
{
    Console.WriteLine("Х от 0 до бесконечности");
    Console.WriteLine("У от 0 до бесконечности");
}
else if (Quater == 2)
{
    Console.WriteLine("Х от 0 до минус бесконечности");
    Console.WriteLine("У от 0 до бесконечности");
}
else if (Quater == 3)
{
    Console.WriteLine("Х от 0 до минус бесконечности");
    Console.WriteLine("У от 0 до минус бесконечности");
}
else if (Quater == 4)
{
    Console.WriteLine("Х от 0 до бесконечности");
    Console.WriteLine("У от 0 до минус бесконечности");
}
else
{
    Console.WriteLine("Введён не верный номер четвери");
}