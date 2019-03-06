using System;
using System.Collections.Generic;
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
            Console.WriteLine("Выберите между разними опции");
            Console.WriteLine("Для сочетаний без повторений, 1 ");
            Console.WriteLine("Для сочетаний с повторениями, 2 ");
            Console.WriteLine("Для размещений без повторени, 3 ");
            Console.WriteLine("Для размещений с повторениямий, 4 ");
            Console.WriteLine("Для перестановки без повторений, 5 ");
            Console.WriteLine("Для перестановки с повторениями, 6 ");


            caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Сколько элементов в множестве? ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько элементов в наборе? ");
                    m = int.Parse(Console.ReadLine());
                    result = CalcFactorial(n) / (CalcFactorial(m) * CalcFactorial(n - m));
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;


                case 2:

                    Console.WriteLine("Сколько элементов в множестве? ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько элементов в наборе? ");
                    m = int.Parse(Console.ReadLine());
                    result = CalcFactorial(n + (m - 1)) / (CalcFactorial(m) * CalcFactorial(n - 1));
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;


                case 3:

                    Console.WriteLine("Сколько элементов в множестве? ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько элементов в наборе? ");
                    m = int.Parse(Console.ReadLine());
                    result = CalcFactorial(n) / CalcFactorial(n - m);
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;


                case 4:

                    Console.WriteLine("Сколько элементов в множестве? ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Сколько элементов в наборе? ");
                    m = int.Parse(Console.ReadLine());
                    result = Math.Pow(n, m);
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;


                case 5:

                    Console.WriteLine("Сколько элементов в множестве? ");
                    n = int.Parse(Console.ReadLine());
                    result = CalcFactorial(n);
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;


                case 6:

                    string text;
                    List<string> Simbols = new List<string>();
                    Console.WriteLine("Для введения символов в строку введите 1");
                    Console.WriteLine("Для введения слов введения любой номер");
                    if (int.Parse(Console.ReadLine()) == 1)
                    {
                        Console.WriteLine("Введите символы");
                        text = Console.ReadLine();
                        foreach (var letter in text)
                        {
                            Simbols.Add(letter.ToString());
                        }
                        n = Simbols.Count;
                    }
                    else { 
                    Console.WriteLine("Сколько элементов в множестве? ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите каждый слов");
                        for (int i = 0; i < n; i++)
                        {
                            Simbols.Add(Console.ReadLine()); 
                        }
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

                    Console.WriteLine("Разные симболы в массиве");
                    separatedSimbols.ForEach(i => Console.WriteLine(i));

                    Console.WriteLine("Количество, из каждого из них");
                    quantity.ForEach(i => Console.WriteLine(i));

                    result = 1;
                    quantity.ForEach(i => result = result * i);
                    result = CalcFactorial(n) / result;
                    Console.WriteLine("Ответ; {0}", result);
                    Console.ReadLine();
                    break;
                default:

                    Console.WriteLine("Ошибка, неправильный ввод");
                    goto start;
            }

            Console.WriteLine("Для нового вычичления нажмите 1, чтобы закрыть программу нажмите любой номер");
            if (int.Parse(Console.ReadLine()) == 1) goto start;
        }
    }
}
