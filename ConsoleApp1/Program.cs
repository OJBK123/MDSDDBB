using ConsoleApp1.LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var soldier = new Soldier();
                soldier.SetGun(new Pistol());
                soldier.KillEnemy();

                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
