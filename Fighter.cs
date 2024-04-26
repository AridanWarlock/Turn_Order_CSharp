using System.Xml.Linq;

namespace TurnOrder
{
    internal interface IFighter : IComparable<IFighter>
    {
        string Name { get; }
        int Initiative { get; set; }
        int Health {  get; }
        int MaxHealth {  get; }
        bool Concentration { get; set;}
        void Damage(int damage);
        bool IsDead { get; }
        bool IsKnocked { get; }
    }
    //internal class FighterComparer : IComparer<IFighter>
    //{
    //    public int Compare(IFighter? x, IFighter? y)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    abstract class Fighter : IFighter
    {
        private int _initiative;
        private readonly int _maxHealth;
        private readonly string? _name;
        public Fighter(string? name, int initiative, int health, int maxHealth)
        {
            Name = name!;
            Initiative = initiative;
            Health = health;
            MaxHealth = maxHealth;
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
        public int Health { get; private set; }
        public int MaxHealth
        {
            get => _maxHealth;
            init => _maxHealth = value >= 0 ? value : 0;
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
        public abstract bool IsDead { get; }
        public override bool Equals(object? obj)
        {
            if (obj is IFighter fighter)
                return Name == fighter.Name;
            return false;
        }
        public override int GetHashCode() => Name.GetHashCode();
        public abstract int CompareTo(IFighter? other);
        public override string ToString() => Name;
    }
    internal class Hero : Fighter
    {
        public Hero(string? name, int initiative, int health, int maxHealth) 
            : base(name, initiative, health, maxHealth) { }
        public override bool IsDead { get => false; }
        public override int CompareTo(IFighter? other)
        {
            ArgumentNullException.ThrowIfNull(other);

            if (Initiative != other.Initiative)
                return other.Initiative - Initiative;

            if (other is Villain)
                return -1;

            return Name.CompareTo(other.Name);
        }
    }
    internal class Villain : Fighter
    {
        public Villain(string? name, int initiative, int health, int maxHealth)
            : base(name, initiative, health, maxHealth) { }
        public override bool IsDead { get => Health == 0; }
        public override int CompareTo(IFighter? other)
        {
            ArgumentNullException.ThrowIfNull(other);

            if (Initiative != other.Initiative)
                return other.Initiative - Initiative;

            if (other is Hero)
                return 1;

            return Name.CompareTo(other.Name);
        }
    }
}
