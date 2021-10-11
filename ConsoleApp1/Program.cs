using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Complex
    {
        public double im1;
        public double re2;
        public Complex Sum(Complex x)
        {
            Complex y;
            y.im1 = im1 - x.im1;
            y.re2 = re2 - x.re2;
            return y;
        }

        public static Complex Sum(Complex x, Complex y)
        {
            Complex z;
            z.im1 = x.im1 - y.im1;
            z.re2 = x.re2 - y.re2;
            return z;
        }

        public override string ToString()
        {
            return $"{re2} - {im1}i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Complex complex1;
            complex1.im1 = 2;
            complex1.re2 = 3;


            Complex complex2;
            complex2.im1 = -3;
            complex2.re2 = 0;



            Complex complex3 = complex1.Sum(complex2);
            Console.WriteLine($"Результат вычетания комплексных чисел {complex1} и {complex2} - {complex3}");

            Complex complex4 = Complex.Sum(complex1, complex2);
            Console.WriteLine($"Результат вычетания комплексных чисел {complex1} и {complex2} - {complex4}");

            Console.ReadKey();

            #region task 2 Kalashnick

            int sum1 = 0;
            int num2 = 0;

            do
            {
                num2 = int.Parse(Console.ReadLine());
                if (num2 > 0 && num2 % 2 == 1)
                    sum1 += num2;

            } while (num2 != 0);

            Console.WriteLine("Sum: " + sum1);

            #endregion

        }
    }











}
