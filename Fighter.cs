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
        public void NotifyArmy(FighterCondition condition)
        {
            Army?.NotifyObservers(this, condition);
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
            set
            {
                _initiative = value <= 40 ? value : 40;
                Army?.NotifyObservers(this, FighterCondition.Modify);
            }
        }
        public int Health 
        {
            get => _health;
            set
            {
                _health =
                   value > _maxHealth ? _maxHealth
                    : value < 0 ? 0
                    : value;
            }
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
                NotifyArmy(FighterCondition.Dead);
            }
            else
                NotifyArmy(FighterCondition.Modify);
        }
        public virtual bool IsDead { get; }
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
                Concentration = false;

            NotifyArmy(FighterCondition.Modify);
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
    enum FighterCondition
    {
        Add,
        Dead,
        Modify,
    }
    interface IFighterObserver
    {
        void UpdateFighter(Fighter? fighter, FighterCondition condition);
    }
    interface IFighterObservable
    {
        void RegisterObserver(IFighterObserver observer);
        void RemoveObserver(IFighterObserver observer);
        void NotifyObservers(Fighter? fighter, FighterCondition condition);
    }
    class ObserverComboBox : ComboBox, IFighterObserver
    {
        public void UpdateFighter(Fighter? fighter, FighterCondition condition)
        {
            if (fighter is null)
                return;

            switch (condition)
            {
                case FighterCondition.Add:
                    Items.Add(fighter);
                    break;
                case FighterCondition.Dead:
                    Items.Remove(fighter);
                    break;
                default:
                    break;
            }
        }
    }
    class Army : IFighterObservable, IFighterObserver
    {
        private PriorityQueue<Fighter, Fighter> _fightersOfRound = new();
        public Dictionary<string, Fighter> Fighters { get; private set; } = [];
        private readonly List<IFighterObserver> _observers = [];
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
        public void NotifyObservers(Fighter? fighter, FighterCondition condition)
        {
            foreach (var observer in _observers)
                observer.UpdateFighter(fighter, condition);
        }
        public void UpdateFighter(Fighter? fighter, FighterCondition condition)
        {
            if (fighter is null)
                return;

            switch (condition)
            {
                case FighterCondition.Add:
                    Fighters.Add(fighter.Name, fighter);
                    break;
                case FighterCondition.Dead:
                    if (Fighters.Remove(fighter.Name))
                    {
                        var queue = new PriorityQueue<Fighter, Fighter>();
                        while (_fightersOfRound.Count > 0)
                        {
                            Fighter f = _fightersOfRound.Dequeue();
                            if (f != fighter)
                                queue.Enqueue(f, f);
                        }
                        
                        _fightersOfRound = queue;

                        if (fighter == CurrentFighter)
                            NextTurn();
                    }
                    break;
                default:
                    break;
            }
        }
        public bool AddFighter(Fighter? fighter)
        {
            if (fighter == null)
                return false;
            
            if (!Fighters.ContainsKey(fighter.Name))
            {
                fighter.Army = this;
                NotifyObservers(fighter, FighterCondition.Add);
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
                foreach (var fighter in Fighters.Values)
                    _fightersOfRound.Enqueue(fighter, fighter);
            }

            CurrentFighter = _fightersOfRound.Dequeue();
        }
    }
}
