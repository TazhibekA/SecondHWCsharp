using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            EightthTask();
        }
        public static void FirstTask() {
            Console.WriteLine("1 2 3");
            Console.Read();
        }
        public static void SecondTask() {
            int firstNumber = 5;
            int secondNumber = 10;
            int thirdNumber = 21;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.ReadLine();

        }
        public static void ThirdTask() {


            double centimeters = 150;

            double metr = centimeters / 100;
            Console.WriteLine("В метрах: ");
            Console.WriteLine(metr);
            Console.ReadLine();
        }

        public static void FourthTask()
        {
            int days = 234;
            Console.WriteLine("Количество полных недель: ");
            int countOfDaysOnWeek = 7;
            int weeks = days / countOfDaysOnWeek;
            Console.WriteLine(weeks);
            Console.ReadLine();
        }

        public static void FifthTask()
        {
            Console.WriteLine("Цифра: ");
            int number = 23;
            Console.WriteLine(number);
            int dozen = 10;
            int countOfDozens = number / dozen;
            int countOfUnits = number - (dozen * countOfDozens);
            int sumOfNumber = countOfDozens + countOfUnits;
            int multiplicationOfNumber = countOfDozens * countOfUnits;
            Console.WriteLine("Количество десяток: ");
            Console.WriteLine(countOfDozens);
            Console.WriteLine("Количество единиц: ");
            Console.WriteLine(countOfUnits);
            Console.WriteLine("Сумма его цифр: ");
            Console.WriteLine(sumOfNumber);
            Console.WriteLine("Произведение его цифр: ");
            Console.WriteLine(multiplicationOfNumber);
            Console.ReadLine();

        }
        
        public static void SixthTask() {
            bool A = true;
            bool B = false;
            bool C = false;

            bool result;

            result = A || B;
            Console.WriteLine(result);
            result = A && B;
            Console.WriteLine(result);
            result = B || C;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void SeventhTask (){
            double radiusOfCircle = 5.0;
            double sideOfSquare = 10.0;
            double areaCircle;
            double areaSquare;
            areaCircle = Math.PI * (radiusOfCircle * radiusOfCircle);
            areaSquare = sideOfSquare * sideOfSquare;

            if (areaCircle > areaSquare)
            {
                Console.WriteLine(areaCircle);
            }
            else if (areaCircle < areaSquare)
            {
                Console.WriteLine(areaSquare);
            }
            else {
                Console.WriteLine("=");

            }

            Console.ReadLine();

        }


        public static void EightthTask() {
            double firstVolume = 6;
            double secondVolume = 10;
            double firstWeight = 2;
            double secondWeight = 5;
            double firstDensity;
            double secondDensity;

            firstDensity = firstWeight / firstVolume;
            secondDensity = secondWeight / secondVolume;


            if (firstDensity > secondDensity)
            {
                Console.WriteLine(firstDensity);
            }
            else if (secondDensity > firstDensity)
            {
                Console.WriteLine(secondDensity);

            }

            else {
                Console.WriteLine("=");
            }

            Console.ReadLine();


        }

        public static void NinthTask()
        {
            double firstU = 6;
            double secondU = 10;
            double firstR = 2;
            double secondR = 5;
            double firstI;
            double secondI;

            firstI = firstU / firstR;
            secondI = secondU / secondR;


            if (firstI > secondI)
            {
                Console.WriteLine(secondI);
            }
            else if (secondI > firstI)
            {
                Console.WriteLine(firstI);

            }

            else
            {
                Console.WriteLine("=");
            }

            Console.ReadLine();


        }

        public static void TenthTask() {


        }

    }
}
