// Написать программу масштабирования фигуры

// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"


double[] FindNumber(string line)        // Метод ищет в строке цифры и записывает их в массив
{
    int[] array = new int[line.Length];
    int index = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (Char.IsDigit(line[i]))
        {
            array[index] = int.Parse(line[i].ToString());
            index++;
        }
    }
    double[] newArray = new double[index];    // Переписываем в новый массив нужного размера (иначе много лишних нулей было)
    for (int i = 0; i < index; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

string NewFigure(double[] array, double k)
{
    string figure = "(" + array[0] + ";" + array[1] + ") ";  // Масштабируем относительно первой точки

    if (k > 1)
    {
        for (int i = 2; i < array.Length; i += 2)
        {                               // Такая формула получилась для увеличения x = k*x2 - x1 
            string point = "(" + (k * array[i] - array[0]) + ";" + (k * array[i + 1] - array[1]) + ") ";
            figure = figure + point;
        }
    }
    else if (k < 1 && k > 0)
    {
        for (int i = 2; i < array.Length; i += 2)
        {                             // Формула для уменьшения x = k(x2 + x1)
            string point = "(" + k * (array[i] + array[0]) + ";" + k * (array[i + 1] + array[1]) + ") ";
            figure = figure + point;
        }
    }
    else figure = "Масштаб задан неправильно!";
    return figure;
}

Console.Clear();
Console.Write("Задайте вершины фигуры: ");
string figure = Console.ReadLine() ?? "0";
double[] array = FindNumber(figure);
Console.Write("Введите коэффициент масштабирования: ");
double k = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Новые вершины фигуры: {NewFigure(array, k)}");


// К сожалению, программа работает только для задания координат в виде натуральных чисел от 0 до 9.
// Ну хотя бы масштабирует вроде правильно =)