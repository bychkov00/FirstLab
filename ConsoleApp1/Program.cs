using System;

public class Test
{
    public static void Main()
    {
        Console.WriteLine("Введите число, чтобы проверить четное ли оно: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
            Console.WriteLine(a + " - Число четное");
        else
            Console.WriteLine(a + " - Число нечетное");
        Console.WriteLine("Введите длины трех сторон треугольника через пробел");
        int[] side_triangle = new int[3];
        int p = 0;
        double s = 0;
        string b = Console.ReadLine();
        string[] bb = b.Split(' ');
        for (int i = 0; i < 3; i++)
        {
            side_triangle[i] = Convert.ToInt32(bb[i]);
            p += side_triangle[i];
        }
        double half_p = p / 2.0;
        if (p - side_triangle[0] > side_triangle[0] && p - side_triangle[1] > side_triangle[1] && p - side_triangle[2] > side_triangle[2])
        {
            s = Math.Sqrt(half_p * (half_p - side_triangle[0]) * (half_p - side_triangle[1]) * (half_p - side_triangle[2]));
            Console.WriteLine("Площадь треугольника равна: " + s);
        }
        else
            Console.WriteLine("Треугольник не существует");
        Console.WriteLine("Введите два числа (первое число меньше второго), чтобы найти сумму нечетных чисел в ряду");
        b = Console.ReadLine();
        string[] bbnew = b.Split(' ');
        int num1 = Convert.ToInt32(bbnew[0]);
        int num2 = Convert.ToInt32(bbnew[1]);
        int sum = 0;
        if (num1 % 2 == 0)
            num1++;
        while (num1 <= num2)
        {
            sum += num1;
            num1 += 2;
        }
        Console.WriteLine("Сумма ряда состовляет:" + sum);
    }
}
