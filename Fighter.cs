using System.Xml.Linq;

namespace TurnOrder
{
    abstract class Fighter : IComparable<Fighter>
    {
        private int _initiative;
        private int _health;
        private readonly int _maxHealth;
        private readonly string? _name;
        public Army? Army { get; set; }
        public Fighter(string? name, int initiative, int health, int maxHealth)
        {
            Name = name!;
            Initiative = initiative;
            MaxHealth = maxHealth;
            Health = health;
        }
        public void AddNotifyArmy()
        {
            Army?.AddNotifyObservers(this);
        }
        public void RemoveNotifyArmy()
        {
            Army?.RemoveNotifyObservers(this);
        }
        public string Name
        {
            get => _name!;
            init
            {
                value = value.Trim();
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
        public int Health 
        {
            get => _health;
            set => _health = 
                value > _maxHealth ? _maxHealth
                : value < 0 ? 0
                : value;
        }
        public int MaxHealth
        {
            get => _maxHealth;
            init => _maxHealth = value >= 0 ? value : 0;
        }
        public bool Concentration { get; set; } = false;
        public virtual void Damage(int damage)
        {
            Health -= damage;

            if (Health == 0)
            {
                Concentration = false;
                RemoveNotifyArmy();
            }
        }
        public bool IsKnocked
        {
            get => Health == 0;
        }
        public abstract bool IsDead { get; }
        public override bool Equals(object? obj)
        {
            if (obj is Fighter fighter)
                return Name == fighter.Name;
            return false;
        }
        public override int GetHashCode() => Name.GetHashCode();
        public abstract int CompareTo(Fighter? other);
        public override string ToString() => Name;
    }
    class Hero(string? name, int initiative, int health, int maxHealth) : Fighter(name, initiative, health, maxHealth)
    {
        public override bool IsDead { get => false; }
        public override int CompareTo(Fighter? other)
        {
            ArgumentNullException.ThrowIfNull(other);

            if (Initiative != other.Initiative)
                return other.Initiative - Initiative;

            if (other is Villain)
                return -1;

            return Name.CompareTo(other.Name);
        }
        public override void Damage(int damage)
        {
            Health -= damage;

            if (Health == 0)
            {
                Concentration = false;
            }
        }
    }
    class Villain(string? name, int initiative, int health, int maxHealth) : Fighter(name, initiative, health, maxHealth)
    {
        public override bool IsDead { get => Health == 0; }
        public override int CompareTo(Fighter? other)
        {
            ArgumentNullException.ThrowIfNull(other);

            if (Initiative != other.Initiative)
                return other.Initiative - Initiative;

            if (other is Hero)
                return 1;

            return Name.CompareTo(other.Name);
        }
    }
    interface IFighterObserver
    {
        void AddUpdateFighter(Fighter? fighter);
        void RemoveUpdateFighter(Fighter? fighter);
    }
    interface IFighterObservable
    {
        void RegisterObserver(IFighterObserver observer);
        void RemoveObserver(IFighterObserver observer);
        void AddNotifyObservers(Fighter? fighter);
        void RemoveNotifyObservers(Fighter? fighter);
    }
    class ObserverComboBox : ComboBox, IFighterObserver
    {
        public void AddUpdateFighter(Fighter? fighter)
        {
            if (fighter is not null && !Items.Contains(fighter))
                Items.Add(fighter);
        }
        public void RemoveUpdateFighter(Fighter? fighter)
        {
            if (fighter is not null)
                Items.Remove(fighter);
        }
    }
    class Army : IFighterObservable, IFighterObserver
    {
        private readonly LinkedList<Fighter> _fightersOfRound = [];
        public SortedSet<Fighter> Fighters { get; private set; } = [];
        private readonly List<IFighterObserver> _observers = [];
        private readonly List<TextBox> _textBox = [];
        public Army()
        {
            _observers.Add(this);
        }
        public Fighter? CurrentFighter { get; private set; } = null;
        public void RegisterObserver(IFighterObserver observer)
        {
            if (observer != this)
                _observers.Add(observer);
        }
        public void RemoveObserver(IFighterObserver observer)
        {
            if (observer != this)
                _observers.Remove(observer);
        }
        public void AddNotifyObservers(Fighter? fighter)
        {
            foreach (var observer in _observers)
                observer.AddUpdateFighter(fighter);
        }
        public void RemoveNotifyObservers(Fighter? fighter)
        {
            foreach (var observer in _observers)
                observer.RemoveUpdateFighter(fighter);
        }
        public void AddUpdateFighter(Fighter? fighter)
        {
            if (fighter is null)
                return;

            Fighters.Add(fighter);
        }
        public void RemoveUpdateFighter(Fighter? fighter)
        {
            if (fighter is not null && Fighters.Remove(fighter))
            {
                _fightersOfRound.Remove(fighter);

                if (fighter == CurrentFighter)
                NextTurn();
            }
        }
        public bool AddFighter(Fighter? fighter)
        {
            if (fighter == null)
                return false;
            
            if (!Fighters.Contains(fighter))
            {
                fighter.Army = this;
                AddNotifyObservers(fighter);
                return true;
            }
            return false;
        }
        public void NextTurn()
        {
            if (Fighters.Count == 0)
                return;

            if (_fightersOfRound.Count == 0)
            {
                foreach (var fighter in Fighters)
                    _fightersOfRound.AddFirst(fighter);
            }

            CurrentFighter = _fightersOfRound.Last?.Value;
            _fightersOfRound.RemoveLast();
        }
        public void RegisterTextBox(TextBox textBox)
        {
            _textBox.Add(textBox);
        }
        public void RemoveTextBox(TextBox textBox)
        {
            _textBox.Remove(textBox);
        }
    }
}
