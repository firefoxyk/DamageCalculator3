using DamageCalculator3;

class Program
{
    static Random random = new Random();
    private static int RollDince(int numberOfRolls)
    {
        int total = 0;
        for (int i = 0; i < numberOfRolls; i++) total += random.Next(1, 7);
        return total;
    }
    static void Main(string[] args)
    {
        SwordDamage swordDamage = new SwordDamage(RollDince(3));
        ArrowDamage arrowDamagre = new ArrowDamage(RollDince(1));

        while (true)
        {
            Console.WriteLine("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit:");
            char key = Console.ReadKey().KeyChar;
            if (key != '0' && key != '1' && key != '2' && key != '3') return;

            Console.WriteLine("\nS for sword, A from arrow, anything else to quit: ");
            char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

            switch (weaponKey)
            {
                case 'S':
                    swordDamage.Roll = RollDince(3);
                    swordDamage.Magic = (key == '1' || key == '3');
                    swordDamage.Flaming = (key == '2' || key == '3');
                    Console.WriteLine(
                        $"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP \n \n");
                    break;
                case 'A':
                    arrowDamagre.Roll = RollDince(1);
                    arrowDamagre.Magic = (key == '1' || key == '3');
                    arrowDamagre.Flaming = (key == '2' || key == '3');
                    Console.WriteLine(
                        $"\nRolled {arrowDamagre.Roll} for {arrowDamagre.Damage} HP \n \n");
                    break;
                default:
                    return;
            }

        }
    }
}
