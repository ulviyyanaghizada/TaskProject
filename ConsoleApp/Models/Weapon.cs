using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Weapon
    {
        private int _bulletCapacity;
        private int _bulletCount;
        private double _bulletTime;
        public double ShootingTime { get; set; }
        public ShootingMood FireMood { get; set; }


        public int BulletCapacity
        {
            get
            {
                return _bulletCapacity;
            }
            set
            {
                if (value>0) 
                { 
                    _bulletCapacity = value;
                }
            }
        }
        public int BulletCount
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                if (value > 0)
                {
                    _bulletCount = value;
                }
            }
        }
        public double BulletTime
        {
            get
            {
                return _bulletTime;
            }
            set
            {
                if (value>0)
                {
                    _bulletTime = value;
                }  
            }
        }

        //    public ShootingMood ShootingMood { get; }

        public Weapon(int bulletCapacity, int bulletCount, int bulletTime, ShootingMood FireMood)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            BulletTime = bulletTime;
            ShootingMood shootingMood = FireMood;
            ShootingTime = BulletTime / BulletCapacity;
    }

        public void Shoot()
        {
            BulletCapacity -= 1;
            Console.WriteLine($"Bir gulle azaldi, qalan gulle sayi {BulletCount}");
        }
        public void Fire()
        {
            if (BulletCount!=0)
            {
                if (ShootingMood.single==FireMood)
                {
                    BulletCount-= 1;
                }
                else if (FireMood==ShootingMood.automatic)
                {
                    BulletCount = 0;
                    Console.WriteLine(ShootingTime*BulletCount);
                }
            }
            else
            {
                Console.WriteLine("sizin gulleniz yoxdur!");
            }
        }

        public int GetRemainBulletCount()
        {
            return BulletCapacity-BulletCount;
        }

        public void Relode()
        {
            if (BulletCount<BulletCapacity) 
            {
                BulletCount = BulletCapacity;            
            }
            else
            {
                Console.WriteLine("Daraq tam doludur!");
            }
        }
        public void ChangeFireMood()
        {
            if (FireMood==ShootingMood.single)
            {
                FireMood = ShootingMood.automatic;
            }
            else
            {
                FireMood= ShootingMood.single;
            }
        }
    }
}
