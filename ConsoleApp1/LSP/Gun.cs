using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.LSP
{
    /// <summary>
    /// 枪支
    /// </summary>
    internal abstract class Gun
    {
        /// <summary>
        /// 射击
        /// </summary>
        public abstract void Shoot();
        /// <summary>
        /// 装弹
        /// </summary>
        public abstract void Loading();
        /// <summary>
        /// 射程
        /// </summary>
        public abstract int Range { get; }
    }
    /// <summary>
    /// 手枪
    /// </summary>
    internal class Pistol : Gun
    {
        public override void Loading()
        {
            Console.WriteLine("手枪装弹");
        }

        public override void Shoot()
        {
            Console.WriteLine("手枪啪啪啪啪啪");
        }
        /// <summary>
        /// 射程
        /// </summary> 

        public override int Range => 50;
    }
    /// <summary>
    /// 步枪
    /// </summary>
    internal class Rifle : Gun
    {
        public override void Loading()
        {
            Console.WriteLine("步枪装弹");
        }

        public override void Shoot()
        {
            Console.WriteLine("步枪突突突突突");
        }
        /// <summary>
        /// 射程
        /// </summary> 

        public override int Range =>500;
    }

}
