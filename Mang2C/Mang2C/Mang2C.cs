using System;

namespace Mang2C
{
    class Mang2C
    {
        // Nhap mang 2 chieu voi m dong, n cot
        public static void Nhap(int[, ] a, int m, int n)
        {
            Console.WriteLine("Tien hanh nhap Mang 2 chieu: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap phan tu thu [{0}][{1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Xuat mang 2 chieu voi m dong, n cot
        public static void Xuat(int[, ] a, int m, int n)
        {
            Console.WriteLine("Tien hanh xuat Mang 2 chieu: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("[{0}][{1}] = {2} ", i, j, a[i, j]);
                Console.WriteLine();
            }
                Console.WriteLine();
        }
        
        // Xuat gia tri max
        public static int TimMax(int[, ] a, int m, int n)
        {
            int max = -999;
            //Console.WriteLine("Tien hanh tim gia tri Max trong Mang 2 chieu: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max) max = a[i, j];
                }
            }
            return max;
        }

        // Xuat gia tri min
        public static int TimMin(int[, ] a, int m, int n)
        {
            int min = 999;
            //Console.WriteLine("Tien hanh tim gia tri Min trong Mang 2 chieu: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < min) min = a[i, j];
                }
            }
            return min;
        }

        // Xuat tong gia tri
        public static int Sum(int[, ] a, int m, int n)
        {
            int tong = 0;
            //Console.WriteLine("Tien hanh tinh tong cac phan tu trong Mang 2 chieu: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong += a[i, j];
                }
            }
            return tong;
        }

        // Xuat trung binh cong
        public static double TBC(int [, ] a, int m, int n)
        {
            return (double)Sum(a, m, n) / (m * n);
        }

        // Sap xep mang
        public static int[,] Sort(int [, ] a, int m, int n)
        {
            int tmp = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int q = 0; q < m; q++)
                    {
                        for (int r = 0; r < n; r++)
                        {
                            if (a[i, j] < a[q, r])
                            {
                                tmp = a[i, j];
                                a[i, j] = a[q, r];
                                a[q, r] = tmp;
                            }
                        }
                    }
                }
            }
            return a;
        }

        // Tim x trong mang
        public static void TimX(int [, ] a, int m, int n)
        {
            int dem = 0;
            Console.Write("Tien hanh tim kiem x, vui long nhap x de tim: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == x)
                    {
                        Console.WriteLine("Da tim thay phan tu x tai vi tri [{0}][{1}]", i, j);
                        dem++;
                    }
                }
            }
            if (dem == 0) Console.WriteLine("Khong tim thay phan tu x trong Mang");
        }

        // Tinh tong tren duong cheo chinh
        public static int TongDCC(int[,] a, int m, int n)
        {
            int tong = 0;
            //Console.WriteLine("Tien hanh tinh tong cac phan tu tren duong cheo chinh: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) tong += a[i, j];
                }
            }
            return tong;
        }

        // Sap xep co dieu kien
        public static int[,] Sort2(int [, ] a, int m, int n)
        {
            int tmp = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int r = 0; r < n; r++)
                    {
                        if (i % 2 == 0)
                        {
                            if (a[i, j] < a[i, r])
                            {
                                tmp = a[i, j];
                                a[i, j] = a[i, r];
                                a[i, r] = tmp;
                            }
                        }

                        else
                        {
                            if (a[i, j] > a[i, r])
                            {
                                tmp = a[i, j];
                                a[i, j] = a[i, r];
                                a[i, r] = tmp;
                            }
                        }
                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int m = 4, n = 5;

            int[,] a = new int[m, n];

            Nhap(a, m, n);
            Xuat(a, m, n);
            Console.WriteLine("Tong cac phan tu trong mang la: {0}", Sum(a, m, n));
            Console.WriteLine("Trung binh cong cac phan tu trong mang la: " + TBC(a, m, n).ToString());
            Console.WriteLine("Phan tu lon nhat trong mang la: {0}", TimMax(a, m, n));
            Console.WriteLine("Phan tu nho nhat trong mang la: {0}", TimMin(a, m, n));
            Console.WriteLine("Tong cac phan tu tren duong cheo chinh cua mang la: {0}", TongDCC(a, m, n));
            TimX(a, m, n);
            Console.WriteLine();
            Console.WriteLine("Cac phan tu trong mang sau khi sap xep theo thu tu tang dan tu trai qua phai va tu tren xuong duoi: ");
            int[,] b = Sort(a, m, n);
            Xuat(b, m, n);
            Console.WriteLine("Cac phan tu trong mang sau khi sap xep theo dong chan tang dan va dong le giam dan la: ");
            int[,] c = Sort2(b, m, n);
            Xuat(c, m, n);
        }
    }
}
