using System.Xml.Linq;

namespace Turn_Order
{
    internal class Fighter : IComparable 
    {
        private int _initiative;
        private int _maxHealth;
        private string? _name;
        private Actor _actor;
        public Fighter(string name, int initiative, int health, int maxHealth, Actor actor)
        {
            Name = name;
            Initiative = initiative;
            Health = health;
            MaxHealth = maxHealth;

            _actor = actor;
        }
        public string Name 
        {
            get => _name!;
            init => _name = value.All(char.IsLetterOrDigit)
                ? value
                : throw new FighterException("Имя должно состоять только из букв и цифр!");
        }
        public int Initiative
        {
            get => _initiative;
            set => _initiative = value <= 40
                ? value
                : throw new FighterException("Инициатива меньше 40!");
        }
        public int Health { get; private set;}
        public int MaxHealth
        {
            get => _maxHealth;
            init => _maxHealth = value >= 0
                ? value
                : throw new FighterException("Макс Хиты не отрицательны!");
        }
        public bool Concentration { get; set; } = false;
        public void Damage(int damage)
        {
            Health = (Health - damage > MaxHealth) ? (MaxHealth) : (Health - damage);

            if (Health <= 0)
                Concentration = false;
        }
        public bool IsDead
        {
            get => Health <= 0 && _actor == Actor.Villain;
        }
        public override string ToString() => Name;
        public override int GetHashCode() => Name.GetHashCode();
        public override bool Equals(object? obj)
        {
            if (obj is Fighter fighter) 
                return Name == fighter.Name;
            return false;
        }
        public int CompareTo(object? obj)
        {
            if (obj is Fighter fighter)
                if (Initiative > fighter.Initiative)
                    return -1;
                else if (Initiative < fighter.Initiative)
                    return 1;
                else if (_actor != fighter._actor)
                    if (_actor == Actor.Hero)
                        return -1;
                    else
                        return Name.CompareTo(fighter.Name);
            return 0;
        }
    }

    enum Actor
    {
        Hero,
        Villain
    }
}
