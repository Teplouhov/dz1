using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dz
{
    class Program
    {
        static int FindMis(string str) 
        {
            char[] temp = str.ToCharArray();
            int counter = 3;

            while (counter <= temp.Length)
            {
                int[] mas = new int[temp.Length];

                int razr = 1;
                for (int i = 0; i < temp.Length / counter; i++)
                {
                    razr *= 10;
                }

                int k = 0;

                for (int j = 0; j < counter; j++)
                {
                    int num = 0;
                    int tr = razr;

                    for (int i = 0; i < (temp.Length / counter); i++)
                    {
                        tr /= 10; 
                        num += (temp[k] - 48) * tr;
                        k++;
                    }
                    mas[j] = num;
                }
                
                for (int i = 0; i < (mas.Length); )
                {
                    if (mas[i + 1] - mas[i] == 1)
                    {
                        i++;
                        if (i == (mas.Length - 1)) 
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        if (mas[i + 1] - mas[i] == 2)
                        {
                            Console.WriteLine("пропущено " + (mas[i] + 1));
                            return (mas[i] + 1);
                        }

                        else 
                        {
                            if (counter == temp.Length)
                            {
                                return -1;
                            }
                            else 
                            {
                                break;
                            }
                            
                        }
                      
                    }

                }
                counter++;
                
            }

            return -1;
        }

        static void Main(string[] args)
        {
            string str;
            int ans=0;
            Console.WriteLine("Введите числовую последовательность");
            str = Console.ReadLine();
            ans = FindMis(str);
            Console.WriteLine("в последовательности {0} пропущено число {1} ", str,ans);
        }
    }
}
