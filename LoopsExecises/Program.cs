using System.Xml;

namespace LoopsExecises
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Ex10()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int firstNumb = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int secondNumb = int.Parse(Console.ReadLine());
            int mututalNumb = -1;
            int checkedFirstNumb = -1;
            int checkedSecondNumb = -1;

            int notChangableFirst = firstNumb;
            int notChangableSecond = secondNumb;
            int i = 1;
            int j = 2;

            int divisor = -1;
            bool hasMutualiByDivisor = false;

            int lowerstNumb;

            if (firstNumb == secondNumb)
            {
                mututalNumb = 1;
            }

            if (firstNumb < secondNumb)
            {
                lowerstNumb = firstNumb;
            }
            else
            {
                lowerstNumb = secondNumb;
            }

            while (j < lowerstNumb && mututalNumb != 1)
            {
                if (firstNumb % j == 0)
                {
                    checkedFirstNumb = firstNumb / j;

                    for (int k = 2; k < firstNumb; k++)
                    {
                        if (secondNumb % k == 0)
                        {
                            checkedSecondNumb = secondNumb / k;

                            if (checkedFirstNumb == checkedSecondNumb)
                            {
                                mututalNumb = checkedFirstNumb;
                                hasMutualiByDivisor = true;
                                break;
                            }
                        }
                    }
                }

                j++;
            }
            while (mututalNumb == -1 && !hasMutualiByDivisor)
            {
                checkedFirstNumb = firstNumb * i;

                for (int k = 1; k <= notChangableFirst; k++)
                {
                    checkedSecondNumb = secondNumb * k;

                    if (checkedFirstNumb == checkedSecondNumb)
                    {
                        mututalNumb = checkedFirstNumb;
                        break;
                    }
                }

                i++;
            }

            Console.WriteLine(mututalNumb);
        }

        private static void Ex9()
        {
            Console.Write("Podaj liczbę w systemie dziesiętnym: ");
            int numbInDec = int.Parse(Console.ReadLine());

            int resultOfDivide = 0;
            string totalResultBeforeReverse = "";
            string totalResult = "";

            while (resultOfDivide != 1)
            {
                resultOfDivide = numbInDec / 2;

                if (numbInDec % 2 == 0)
                {
                    totalResultBeforeReverse += "0";
                }
                else
                {
                    totalResultBeforeReverse += "1";
                }

                numbInDec = resultOfDivide;
            }


            for (int i = totalResultBeforeReverse.Length - 1; i >= 0; i--)
            {
                totalResult += totalResultBeforeReverse[i];
            }

            Console.WriteLine("1" + totalResult);
        }

        private static void Ex8()
        {
            Console.Write("Wprowadź dowolny ciąg znaków: ");
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }

        private static void Ex7()
        {
            Console.Write("Podaj długość przekątnej: ");
            int diagonal = int.Parse(Console.ReadLine());

            if (diagonal % 2 == 0)
            {
                throw new Exception("I cannot make diamond form even number");
            }
            int needSpaceBars = 1;
            int needAsterics = 1;
            for (int i = 0; i < diagonal; i++)
            {
                if (diagonal / 2 >= i)
                {
                    for (int k = i; k < diagonal / 2; k++)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    for (int j = 0; j < needSpaceBars; j++)
                    {
                        Console.Write(" ");
                    }
                    needSpaceBars++;
                }


                for (int j = 0; j < needAsterics; j++)
                {
                    Console.Write("*");
                }

                if (diagonal / 2 > i)
                    needAsterics += 2;
                else
                    needAsterics -= 2;

                Console.WriteLine();
            }
        }

        private static void Ex6()
        {
            double sum = 0;
            for (double i = 1; i <= 20; i++)
            {
                sum += 1 / i;
            }

            Console.WriteLine(sum);
        }

        private static void Ex5()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i * i * i);
            }
        }

        private static void Ex4()
        {
            int input = int.Parse(Console.ReadLine());

            if (input % 2 != 0)
            {
                Console.WriteLine("Nie da sie utworzyć piramidy");
            }
            else
            {

                int actualNumb = 1;

                for (int i = 1; i <= 100; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write(actualNumb + " ");
                        actualNumb++;


                    }
                    if (actualNumb - 1 == input)
                        break;
                    Console.WriteLine();

                }
            }
        }

        private static void Ex3()
        {
            long first = 0;
            long second = 1;

            long sum = first + second;

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(sum);

            for (int i = 0; i < 30; i++)
            {
                first = second;
                second = sum;
                sum = first + second;
                Console.WriteLine(sum);
            }
        }

        private static void Ex2()
        {
            int a = 0;
            do
            {
                if (a % 2 == 0 && a != 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            } while (a <= 1000);
        }

        public static void Ex1()
        {
            int amountOfDividers = 0;

            for (int i = 0; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        amountOfDividers++;
                    }


                }
                if (amountOfDividers == 0 && i != 0)
                    Console.WriteLine(i);

                amountOfDividers = 0;
            }
        }
    }
}