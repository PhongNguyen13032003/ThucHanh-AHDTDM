using System;

class Program {
    // Hàm kiểm tra xem một số có phải là số chính phương hay không
    static bool IsPerfectSquare(int num) {
        int squareRoot = (int)Math.Sqrt(num);
        return squareRoot * squareRoot == num;
    }

    // Hàm đếm và in ra các số chính phương nhỏ hơn n
    static void PrintPerfectSquares(int n) {
        Console.WriteLine($"Cac so chinh phuong nho hon {n}:");
        for (int i = 1; i < n; i++) {
            if (IsPerfectSquare(i)) {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void Main(string[] args) {
        Console.Write("Nhap vao mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());
        PrintPerfectSquares(n);
    }
}
