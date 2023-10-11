using System;

namespace lesson1
{

    class Program
    {
        class Numbermanipulator {
            public int Findmax (int a, int b)
            {
                int result;
                if (a < b)
                {
                    result = b;
                }
                else
                {
                    result = a;
                }
                return result;
            }

        }

        class Human {
            private int age;

            public int Age {
                get { return age; }

                set { 
                    if (value > 0) {
                        age = value;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("ABOBA!!!!!");
            Console.ReadKey(); //не закрывает консоль пока не жамкнешь какую-то кнопку
            float a = 5.6f;
            decimal b = 1.2m;

            int x = 15;
            sbyte x1 = (sbyte)x; // присвоение переменной типа огранченного меньшим числом значения переменной типа большего числа(значение не превышает макс знч меньшей переменной)
            string str1 = Convert.ToString(x);

            string agestr = Console.ReadLine();
            int age = Convert.ToInt32(agestr);
            Console.WriteLine(age);
            Console.WriteLine(agestr);

            if (age > 20)
            {
                Console.WriteLine("old hah");
            }
            else
            {
                Console.WriteLine("smol lol");
            }
            switch (age)
            {
                case 16:
                    Console.WriteLine("you're 16 lol");
                    break;
                case 10:
                    Console.WriteLine("you're 10 smol lol");
                    goto case 20;
                case 20:
                    Console.WriteLine("you're 20 old af lol");
                    break;
                default:
                    Console.WriteLine("you're хз lol");
                    break;
            }
            int z = 9;
            Numbermanipulator numbermanipulator = new Numbermanipulator();
            int bignum = numbermanipulator.Findmax(x, z);
            Console.WriteLine("большее число: "+bignum);

            Human hum1 = new Human();
            hum1.Age = 50;
            age = hum1.Age;

            int newnuber = 10;
            Console.WriteLine(newnuber);
        }

            
    }

    }


