using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.LSP
{
    /// <summary>
    /// 士兵
    /// </summary>
    internal class Soldier
    {
        /// <summary>
        /// 士兵的枪
        /// </summary>
        private Gun Gun;
        public void SetGun(Gun gun)
        {
            this.Gun= gun; 
        }
        public void KillEnemy()
        {
            Console.WriteLine("士兵开始杀人了");
            Gun.Shoot();
            HashMap
        }
    }
}
