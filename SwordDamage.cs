using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DamageCalculator3
{
    internal class SwordDamage : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;
        /// <summary>
        /// Константы калькулятора дамага
        /// </summary>
        /// 
        public SwordDamage(int startindRoll) : base(startindRoll) { }

        protected override void CalculatrDamage ()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}

