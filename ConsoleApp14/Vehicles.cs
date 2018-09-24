using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Vehicles: Transportation
    {
        public void WeaponDamge()
        {
            Console.WriteLine("Extremely Heavy Weapon");
        }
        public void AttackFrom()
        {
            Console.WriteLine("Attack through Ground");
        }
        public void Speed()
        {
            Console.WriteLine("Moderate Speed");
        }
    }
    
}
