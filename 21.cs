using System;
using System.Globalization;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var count_of_points = 0;
                while (true)
                {
                Console.WriteLine("���������� ����� ������:"+ count_of_points.ToString());
                Console.WriteLine("���� ���?(�/�)");
                var isgetcard = Console.ReadLine();
                    if (isgetcard == "�")
                    {
                        Random kek = new Random();
                        var nrandchislo = kek.Next(1, 10);
                        count_of_points += nrandchislo;
                        if (count_of_points > 21)
                        {
                            Console.WriteLine("�� ���������");
                            Console.WriteLine("������ ���?�/�");
                            var isplaychar = Console.ReadLine();
                            if (isplaychar != "�")
                            {
                                count_of_points = 0;
                                break;
                            }
                        }
                        continue;
                    }
                    else
                    {
                        if (count_of_points > 21)
                        {
                            Console.WriteLine("�� ���������");
                            Console.WriteLine("������ ���?�/�");
                            var isplaychar = Console.ReadLine();
                            if (isplaychar != "�")
                            {
                                count_of_points = 0;
                                break;
                            }
                        }
                        else
                        {
                            Random player = new Random();
                            var ranplayerpoint = player.Next(17, 21);
                            if (count_of_points > ranplayerpoint)
                            {
                                Console.WriteLine("�� ��������! ���������� ����� ���������:" +ranplayerpoint );
                                break;
                            }
                            else
                            {
                                if(count_of_points == ranplayerpoint)
                                Console.WriteLine("�����! ���������� ����� ���������:" + ranplayerpoint);
                                if(count_of_points < ranplayerpoint)
                                    Console.WriteLine("�� ���������! ���������� ����� ���������:" + ranplayerpoint);
                                break;
                            }
                        }

                    }
                }

            }
        }
    }
}
