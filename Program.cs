using System;

namespace MyOwnIdea
{

    class Program
    {
        class Warrior
        {
            Random random = new Random();

            private string name;
            private int damage;
            private int armorValue;
            private int move;

            //Constructor
            public Warrior(string name, int damage, int armorValue, int move)
            {
                this.name = name;
                this.damage = damage;
                this.armorValue = armorValue;
                this.move = move;
            }

            public string Name { get { return name; } }
            public int Damage { get { return damage; } }
            public int ArmorValue { get { return armorValue; } }
            public int Move { get { return move; } }

            public void Attack()
            {
                damage = random.Next(1, 10);
                Console.WriteLine($"Warrior attacked for " + damage + " points of damage");
            }

            public override string ToString()
            {
                return $"Name: {name}, Damage: {damage}, Armor Value: {armorValue}, Move: {move}";
            }
        }
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Thor",10,10,2);
            Console.WriteLine(warrior);
            warrior.Attack();
            
        }
    }
}
