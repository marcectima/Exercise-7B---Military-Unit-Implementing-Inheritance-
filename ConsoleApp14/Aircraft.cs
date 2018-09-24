using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Aircraft: Transportation
    {
        public void WeaponDamge()
        {
            Console.WriteLine("Heavy Weapon");
        }
        public void AttackFrom()
        {
            Console.WriteLine("Attack through Air");
        }
        public void Speed()
        {
            Console.WriteLine("Very Fast Speed");
        }
    }
}
