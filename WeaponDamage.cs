using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculator3
{

    internal class WeaponDamage
    {
        /// <summary>
        /// Константы калькулятора дамага
        /// </summary>
        private int roll;
        /// <summary>
        /// Устанавливает или получает бросок кубика 3на6
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set { roll = value; CalculatrDamage(); }
        }

        public int Damage { get; protected set; }
        /// <summary>
        /// Вычисляет поражение в зависимости от текущих свойств
        /// </summary>
        protected virtual void CalculatrDamage()
        {
          /*Переопределяется в субклассе*/
        }

        private bool magic;
        /// <summary>
        /// Если меч волшебный true, иначе false
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set { magic = value; CalculatrDamage(); }
        }
        public bool flaming;
        /// <summary>
        /// Если меч огненный true, иначе false
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set { flaming = value; CalculatrDamage(); }
        }
        /// <summary>
        /// Вычисление поражения для занчений magic и flaminf по умолчанию и нач броска 3на6
        /// </summary>
        /// <param name="startindRoll"> Начальный бросок 3на6</param>
        public WeaponDamage(int startindRoll)
        {
            roll = startindRoll;
            CalculatrDamage();
        }

    }

}

