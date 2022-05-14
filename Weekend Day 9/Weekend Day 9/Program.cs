using System;

namespace Weekend_Day_9
{
    class Program
    {
        static void Main(string[] args)
        {


            do
            {
                if (true)
                {
                    Console.WriteLine("Enter Capacity");

                    int capacity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nEnter Count");
                    int count = Convert.ToInt32(Console.ReadLine());

                    Weapon weapon = new Weapon(capacity, count);
                }

                bool check = true;
                do
                {
                    Console.WriteLine("0-Show Information");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    switch (answer)
                    {
                        case 0:
                            do
                            {
                                Console.WriteLine("1 - for Shoot Method");
                                Console.WriteLine("2 - for Fire Method");
                                Console.WriteLine("3 - for GetRemainBulletCount Method");
                                Console.WriteLine("4 - for Reload Method");
                                Console.WriteLine("5 - for ChangeFireMode Method");
                                Console.WriteLine("6 - End");

                                int answer2 = Convert.ToInt32(Console.ReadLine());
                                switch (answer2)
                                {
                                    case 1:
                                        weapon.Shoot();
                                        break;
                                    case 2:
                                        weapon.Fire();
                                        break;
                                    case 3:
                                        Console.WriteLine(weapon.GetRemainBulletCount());
                                        break;
                                    case 4:
                                        Console.WriteLine(weapon.Reload());
                                        break;
                                    default:
                                        break;
                                }
                            } while (!check);
                            break;
                        default:
                            break;
                    }


                } while (check);

            } while (true);
       
           
        }
    }
}
