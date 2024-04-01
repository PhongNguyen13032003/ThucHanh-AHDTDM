using System;

class Program 
{
    static bool KiemTraSoChinhPhuong(int num) 
    {
        int squareRoot = (int)Math.Sqrt(num);
        return squareRoot * squareRoot == num;
    }
    static void XuatSoChinhPhuong(int n) 
    {
        Console.WriteLine($"Cac so chinh phuong nho hon {n}:");
        for (int i = 1; i < n; i++) 
        {
            if (KiemTraSoChinhPhuong(i)) 
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void Main(string[] args) 
    {
        Console.Write("Nhap vao mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());
        XuatSoChinhPhuong(n);
    }
}
