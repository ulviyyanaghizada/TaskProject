using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation;
            Weapon weapon = new Weapon(100,50,60,ShootingMood.automatic);
            
            do
            {
                Console.WriteLine("0-Informasiya Almaq üçün");
                Console.WriteLine("1-Shoot metodu üçün ");
                Console.WriteLine("2-Fire Metodu üçün");
                Console.WriteLine("3-Get Remain Bullet Count metodu üçün");
                Console.WriteLine("4-Reload metodu üçün");
                Console.WriteLine("5-Change Fire Mode metodu üçün");
                Console.WriteLine("6-Proqramı dayandırmaq üçün");

                operation = Console.ReadLine();

                switch (operation)
                {
                    case "0":
                        Console.WriteLine();
                        break;

                    case "1":
                        weapon.Shoot();
                        break;

                    case "2":
                        weapon.Fire();
                        break;

                    case "3":
                        weapon.GetRemainBulletCount();
                        break;

                    case "4":
                        weapon.Relode();
                        break;

                    case "5":
                        weapon.ChangeFireMood();
                        break;
                }
            } while (operation != "6");
        }
    }
}