using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Order
{
    abstract class Fighter
    {
        public string? actor;
        public readonly string Name;
        private int _initiative;
        private int _health;
        private int _max_health;
        public int Initiative
        {
            get => _initiative;
            set => _initiative = value >= 0 && value <= 40
                ? value
                : throw new Fighter_Exception("Инициатива в диапозоне: от 0 до 40!");
        }
        public int Health
        {
            get => _health;
            set => _health = value > 0
                ? value
                : throw new Fighter_Exception("Хиты больше 0!");
        }
        public int Max_health
        {
            get => _max_health;
            init => _max_health = value > 0
                ? value
                : throw new Fighter_Exception("Макс Хиты больше 0!");
        }
        public bool Concentratoin { get; set; } = false;
        public Fighter(string name, int initiative, int health, int max_health)
        {
            Name = name;
            Initiative = initiative;
            Health = health;
            Max_health = max_health;
        }
        public override string ToString() => Name;
        public abstract bool Damage(int damage);
        public override int GetHashCode() => Name.GetHashCode();
        public override bool Equals(object? obj)
        {
            if (obj is Fighter fighter) return Name == fighter.Name;
            return false;
        }
    }

    class Hero : Fighter
    {
        public Hero(string name, int initiative, int health, int max_health)
            : base(name, initiative, health, max_health) { actor = "Hero"; }

        public override bool Damage(int damage)
        {
            Health = (Health - damage > Max_health) ? (Max_health) : (Health - damage);
            if (Health <= 0)
            {
                Concentratoin = false;
            }
            return false;
        }
    }
    class Villain : Fighter
    {
        public Villain(string name, int initiative, int health, int max_health)
            : base(name, initiative, health, max_health) { actor = "Villain"; }

        public override bool Damage(int damage)
        {
            Health = (Health - damage > Max_health) ? (Max_health) : (Health - damage);
            if (Health <= 0)
                return true;
            return false;
        }
    }
}
