﻿namespace Turn_Order
{
    internal abstract class Fighter : IComparable 
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
            protected set => _health = value > 0
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
        public bool Concentration { get; set; } = false;
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

        public int CompareTo(object? obj)
        {
            if (obj is Fighter fighter)
                if (Initiative > fighter.Initiative)
                    return -1;
                else if (Initiative < fighter.Initiative)
                    return 1;
                else if (actor != fighter.actor && actor == "Hero")
                    return -1;
            return 0;
        }
    }

    internal class Hero : Fighter
    {
        public Hero(string name, int initiative, int health, int max_health)
            : base(name, initiative, health, max_health) { actor = "Hero"; }

        public override bool Damage(int damage)
        {
            Health = (Health - damage > Max_health) ? (Max_health) : (Health - damage);
            if (Health <= 0)
            {
                Concentration = false;
            }
            return false;
        }
    }

    internal class Villain : Fighter
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
