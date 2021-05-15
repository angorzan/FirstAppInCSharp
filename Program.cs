using System;

namespace FirstAppAnnaGorzanowska
{
    class Program
    {
        static void Main(string[] args)
        {
            simpleCalc();
            arrayOperations();

            Person person = new Person { FirstName = "Syrius", LastName = "Black" };
            Console.WriteLine(person.FirstName + " " + person.LastName);

            Console.ReadKey();

        }

        private static void arrayOperations()
        {
            Console.WriteLine("Enter the length of the array");
            int arrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maximum value that can be in the array");
            int arrayMaxValue = int.Parse(Console.ReadLine());

            int[] myArray = new int[arrayLength];
            generateRandomValueArray(arrayLength, arrayMaxValue, myArray);

            Console.WriteLine("Not sorted array:");
            printArrayElements(myArray);

            Console.WriteLine("Sorted array:");
            bubbleSort(myArray);
            printArrayElements(myArray);
        }

        static void bubbleSort(int[] array)
        {
            int n = array.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }
        private static void generateRandomValueArray(int arrayLength, int arrayMaxValue, int[] myArray)
        {
            Random random = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                myArray[i] = random.Next(arrayMaxValue);
            }
        }

        private static void printArrayElements(int[] myArray)
        {
            Console.WriteLine();
            foreach (var item in myArray)
            {
                Console.Write($"{item} ");
            }
        }

        private static void simpleCalc()
        {
            Boolean keepCounting = true;
            while (keepCounting)
            {
                numberOperations();
                Console.WriteLine("Shall I keep counting? Press [y/n]");
                char decision = char.Parse(Console.ReadLine());
                if (decision == 'n') { keepCounting = false; } else { keepCounting = true; };
            }
        }

        private static void numberOperations()
        {
            Console.WriteLine("Enter the first floating point number");
            try
            {
                float firstNumber = float.Parse(Console.ReadLine());
                Console.WriteLine($"The number entered by the user is {firstNumber}");
                Console.WriteLine("Enter the second floating point number");
                try
                {
                    float secondNumber = float.Parse(Console.ReadLine());
                    Console.WriteLine($"The number entered by the user is {secondNumber}");
                    Console.WriteLine("Give the sign of the mathematical operation (+/-/:/*)");
                    try
                    {
                        char arytSign = char.Parse(Console.ReadLine());
                        float result = 0;
                        switch (arytSign)
                        {
                            case '+':
                                result = firstNumber + secondNumber;
                                break;
                            case '-':
                                result = firstNumber - secondNumber;
                                break;
                            case '/':
                                result = firstNumber / secondNumber;
                                break;
                            case '*':
                                result = firstNumber * secondNumber;
                                break;
                        }
                        Console.WriteLine($"{firstNumber} {arytSign} {secondNumber} = {result}");
                    }
                    catch
                    {
                        Console.WriteLine("Zły znak");
                    }
                }
                catch { Console.WriteLine("Podana liczba jest nieprawidłowa"); }
            }
            catch { Console.WriteLine("Podana liczba jest nieprawidłowa"); }
        }
    }
}
