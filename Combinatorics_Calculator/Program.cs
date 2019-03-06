using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Combinatorics_Calculator
{
    class Program
    {
        static public int CalcFactorial(int number)
        {
            if (number == 1) return 1;
            return number * CalcFactorial(number - 1);
        }

        static void Main(string[] args)
        {

            Dictionary<int, string> _dictionaryOfSimbols = new Dictionary<int, string>();
            var n = new int();
            var m = new int();
            var result = new double();
            int caseSwitch = new int();


        start:
            Console.WriteLine("Выбераите между разные опции");
            Console.WriteLine("Для сочетание без повторений, 1 ");
            Console.WriteLine("Для сочетание с повторениями, 2 ");
            Console.WriteLine("Для размещение без повторени, 3 ");
            Console.WriteLine("Для размещение с повторениямий, 4 ");
            Console.WriteLine("Для перестановка без повторений, 5 ");
            Console.WriteLine("Для перестановка с повторениями, 6 ");


            caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Сколько элементов во множестве? ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько элементов в наборе? ");
                    m = int.Parse(Console.ReadLine());
                    result = CalcFactorial(n) / (CalcFactorial(m) * CalcFactorial(n - m));
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Сколько элементов во множестве? ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько элементов в наборе? ");
                    m = int.Parse(Console.ReadLine());
                    result = CalcFactorial(n + (m - 1)) / (CalcFactorial(m) * CalcFactorial(n - 1));
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Сколько элементов во множестве? ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько элементов в наборе? ");
                    m = int.Parse(Console.ReadLine());
                    result = CalcFactorial(n) / CalcFactorial(n - m);
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Сколько элементов во множестве? ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько элементов в наборе? ");
                    m = int.Parse(Console.ReadLine());
                    result = Math.Pow(n, m);
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Сколько элементов во множестве? ");
                    n = int.Parse(Console.ReadLine());
                    result = CalcFactorial(n);
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Сколько элементов во множестве? ");
                    n = int.Parse(Console.ReadLine());
                    string text; 
                    List<string> Simbols = new List<string>();

                //    Console.WriteLine("Add each of the simbols of the arrange");

                  //  for (int i = 0; i < n; i++) Simbols.Add(Console.ReadLine());

                    Console.WriteLine("Add text with all the letters");
                    text = Console.ReadLine();
                    string[] textArray = text.Split();
                    for (int i = 0; i < textArray.Length; i++)
                    {
                        Console.WriteLine(textArray[i]);
                        Console.WriteLine(i);
                    }
                    foreach (var letter in textArray)
                    {
                        Simbols.Add(letter);  
                    }
                    var quantity = new List<int> { };

                    List<string> separatedSimbols = new List<string>();

                    foreach (var simbol in Simbols)
                    {
                        for (int i = 0; i < Simbols.Count; i++)
                        {
                            if (!separatedSimbols.Contains(simbol))
                            {
                                separatedSimbols.Add(simbol);
                                quantity.Add(0);
                            }
                        }
                    }

                    for (int i = 0; i < separatedSimbols.Count; i++)
                    {
                        foreach (var simbol in Simbols)
                        {
                            if (separatedSimbols[i] == simbol) quantity[i]++;
                        }
                    }

                    Console.WriteLine("Different type of simbols on your arrange");
                    separatedSimbols.ForEach(i => Console.WriteLine(i));

                    Console.WriteLine("Cuantity of each of them, in the same order");
                    quantity.ForEach(i => Console.WriteLine(i));

                    result = 1;
                    quantity.ForEach(i => result = result * i);
                    result = CalcFactorial(n) / result;
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Ошибка, непраильный ввод");
                    goto start;
            }
        }
    }
}
