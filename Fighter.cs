using System.Xml.Linq;

namespace TurnOrder
{
    internal class Fighter : IComparable 
    {
        private int _initiative;
        private readonly int _maxHealth;
        private readonly string? _name;
        private readonly Actor _actor;
        public Fighter(string? name, int initiative, int health, int maxHealth, Actor actor)
        {
            Name = name!;
            Initiative = initiative;
            Health = health;
            MaxHealth = maxHealth;

            _actor = actor;
        }
        public string Name 
        {
            get => _name!;
            init
            { 
                value = value.TrimStart().TrimEnd();
                if (value is null || !value.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    _name = "Default";
                    throw new FighterException("Имя должно состоять только из букв и цифр!");
                }
                else
                    _name = value;
            }
        }
        public int Initiative
        {
            get => _initiative;
            set => _initiative = value <= 40 ? value : 40;
        }
        public int Health { get; private set;}
        public int MaxHealth
        {
            get => _maxHealth;
            init => _maxHealth = value >= 0 ? value: 0;
        }
        public bool Concentration { get; set; } = false;
        public void Damage(int damage)
        {
            Health = (Health - damage > MaxHealth) 
                ? (MaxHealth) 
                : (Health - damage);

            if (Health <= 0)
            {
                Health = 0;
                Concentration = false;
            }
        }
        public bool IsKnocked
        {
            get => Health == 0;
        }
        public bool IsDead
        {
            get => Health == 0 && _actor == Actor.Villain;
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
            {
                if (Initiative > fighter.Initiative)
                    return -1;
                else if (Initiative < fighter.Initiative)
                    return 1;

                if (_actor == Actor.Hero && fighter._actor == Actor.Villain)
                    return -1;
                else if (_actor == Actor.Villain && fighter._actor == Actor.Hero)
                    return 1;

                return Name.CompareTo(fighter.Name);
            }
            return 1;
        }
    }
    enum Actor
    {
        Hero,
        Villain
    }
}
