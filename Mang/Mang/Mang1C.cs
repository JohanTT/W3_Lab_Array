using System;

namespace Mang
{
    class Mang1C
    {
        // Nhap mang
        public static void Nhap(int [] a)
        {
            Console.WriteLine("Tien hanh nhap Mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Xuat mang
        public static void Xuat(int [] a)
        {
            Console.WriteLine("Tien hanh xuat Mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        // Tinh tong
        public static int Sum(int [] a)
        {
            int tong = 0;
            //Console.WriteLine("Tien hanh tinh tong cac phan tu trong mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        // Tim max
        public static int FindMax(int [] a)
        {
            int max = -999;
            //Console.WriteLine("Tien hanh tim kiem max va min trong mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
            }
            return max;
        }
        // Tim min
        public static int FindMin(int[] a)
        {
            int min = 999;
            //Console.WriteLine("Tien hanh tim kiem max va min trong mang: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
            }
            return min;
        }

        // Dem so luong so nguyen duong chan
        public static int CountPositiveNum(int[] a)
        {
            int dem = 0;
            //Console.WriteLine("Tien hanh tim so luong so nguyen duong chan: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0 && a[i] % 2 == 0) dem++;
            }
            return dem;
        }

        // Dem so chan
        public static int CountNum(int[] a)
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0) dem++;
            }
            return dem;

        }
        // Tinh trung binh cong
        public static double Average(int [] a)
        {
            //Console.WriteLine("Tien hanh tim gia tri trung binh cong: ");
            return (double)Sum(a)/a.Length;
        }

        // Dem so luong phan tu x
        public static int CountX(int [] a, int x)
        {
            int dem = 0;
            //Console.WriteLine("Tien hanh tim {0} trong mang: ", x);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x) dem++;
            }
            return dem;
        }

        // Tao mang chua cac phan tu so chan
        public static int[] NewArray(int [] a)
        {
            int soluong = CountNum(a);
            int dem = 0;
            int[] b = new int[soluong];
            
            //Console.WriteLine("Tien hanh tao 1 mang moi dua vao so chan: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0) b[dem++] = a[i];
            }
            return b;
        }

        private static void Main(string[] args)
        {
            Console.Write("Hay nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Nhap(A);
            Xuat(A);
            Console.WriteLine("Tong cac phan tu trong mang la: {0}", Sum(A));
            Console.WriteLine("Phan tu lon nha trong mang la: {0}", FindMax(A));
            Console.WriteLine("Phan tu nho nhat trong mang la: {0}", FindMin(A));
            Console.WriteLine("Trung binh cong cua cac phan tu trong mang la: {0}", Average(A));
            Console.WriteLine("So luong cac so duong chan la: {0}", CountPositiveNum(A));
            if (CountPositiveNum(A) == 0) Console.WriteLine("Khong co phan tu chan nao trong mang nen khong tao duoc mang moi.");
            else
            {
                Console.WriteLine("Tien hanh tao mang moi voi {0} phan tu chan tu mang truoc: ", CountNum(A));
                int[] B = NewArray(A);
                Xuat(B);
            }
        }
    }
}
