using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculator3
{
    internal class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal FLAME_DAMAGE = 2.5M;
        private const decimal MAGIC_MULTIPIER = 1.25M;
        /// <summary>
        /// Константы калькулятора дамага
        /// </summary>
        /// 
        public ArrowDamage(int startindRoll) : base(startindRoll) { }

        protected override void CalculatrDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
