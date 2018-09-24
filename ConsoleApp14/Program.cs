using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
        Aircraft craft = new Aircraft();
            craft.WayOfTravel("Air");
            craft.By("Flying");
            craft.AttackFrom();
            craft.Speed();
            craft.WeaponDamge();

            Vehicles vehicle = new Vehicles();
            vehicle.WayOfTravel("Land");
            vehicle.By("Driving");
            vehicle.AttackFrom();
            vehicle.Speed();
            vehicle.WeaponDamge();

            Transportation t = craft;
            t = vehicle;
        }
    }
}
