namespace Turn_Order
{
    internal abstract class Fighter : IComparable 
    {
        private readonly string _name;
        private int _initiative;
        private int _health;
        private int _max_health;
        public Fighter(string name, int initiative, int health, int max_health)
        {
            if (!name.All(char.IsLetterOrDigit))
                throw new Fighter_Exception("Имя должно состоять только из букв и цифр!");
            _name = name;
            Initiative = initiative;
            Health = health;
            Max_health = max_health;
        }

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
        protected string? Actor { get; init; }
        public bool Concentration { get; set; } = false;

        public abstract bool Damage(int damage);
        public override string ToString() => _name;
        public override int GetHashCode() => _name.GetHashCode();
        public override bool Equals(object? obj)
        {
            if (obj is Fighter fighter) return _name == fighter._name;
            return false;
        }
        public int CompareTo(object? obj)
        {
            if (obj is Fighter fighter)
                if (Initiative > fighter.Initiative)
                    return -1;
                else if (Initiative < fighter.Initiative)
                    return 1;
                else if (Actor != fighter.Actor && Actor == "Hero")
                    return -1;
            return 0;
        }
    }

    internal class Hero : Fighter
    {
        public Hero(string name, int initiative, int health, int max_health)
            : base(name, initiative, health, max_health) { Actor = "Hero"; }

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
            : base(name, initiative, health, max_health) { Actor = "Villain"; }

        public override bool Damage(int damage)
        {
            Health = (Health - damage > Max_health) ? (Max_health) : (Health - damage);
            if (Health <= 0)
                return true;
            return false;
        }
    }
}
