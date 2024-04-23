namespace Turn_Order
{
    internal partial class TurnOrderForm : Form
    {
        public TurnOrderForm()
        {
            InitializeComponent();
        }

        //private List<Fighter> _setOfFighters = [];
        private PriorityQueue<Fighter, Fighter> _queueOfTurns = 
            new(Comparer<Fighter>.Create((a, b) => a.CompareTo(b)));
        private SortedSet<Fighter> _setOfFighters = [];
        private Fighter? _currentFighter;
        private void Next_button_Click(object sender, EventArgs e)
        {
            if (_setOfFighters.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Error!");
                return;
            }

            if (_queueOfTurns.Count == 0)
            {
                foreach (var fighter in _setOfFighters)
                    _queueOfTurns.Enqueue(fighter, fighter);
            }

            do
                _currentFighter = _queueOfTurns.Dequeue();
            while (_currentFighter.IsDead);

            currentFighterLabel.Text = _currentFighter.Name;
            concentraionText.Visible = _currentFighter.Concentration;
        }
        private void Turn_Order_Form_Load(object sender, EventArgs e)
        {
            Fighter a = new("Элли", 12, 31, 40, Actor.Hero);
            Fighter b = new("Вальт", 17, 50, 60, Actor.Hero);
            _setOfFighters.Add(a);
            _setOfFighters.Add(b);

            currentFighterLabel.Text = _setOfFighters.Max!.Name;

            deleteComboBox.Items.Add(_setOfFighters.Min!);
            initChangeComboBox.Items.Add(_setOfFighters.Min!);
            damageComboBox.Items.Add(_setOfFighters.Min!);

            deleteComboBox.Items.Add(_setOfFighters.Max!);
            initChangeComboBox.Items.Add(_setOfFighters.Max!);
            damageComboBox.Items.Add(_setOfFighters.Max!);

            Display();
        }
        private void Display()
        {
            nameText.Clear();
            initText.Clear();
            healthText.Clear();

            foreach (Fighter fighter in _setOfFighters)
            {
                nameText.Text += fighter.Name + Environment.NewLine;
                initText.Text += fighter.Initiative + Environment.NewLine;
                healthText.Text += fighter.Health + " \\ " + fighter.MaxHealth + Environment.NewLine;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (addNameText.Text == "" || addHealthText.Text == ""
                || addMaxHealthText.Text == "" || addInitText.Text == "")
            {
                MessageBox.Show("Введите данные!", "Warning!");
                return;
            }

            if (!(int.TryParse(addInitText.Text, out _)
                && int.TryParse(addHealthText.Text, out _) &&
                int.TryParse(addMaxHealthText.Text, out _)))
            {
                MessageBox.Show("Некорректный ввод!", "Error!");
                return;
            }

            Fighter added;
            try
            {
                Actor actor = heroCheck.Checked 
                    ? Actor.Hero 
                    : Actor.Villain;

                added = new Fighter(
                    addNameText.Text,
                    Convert.ToInt32(addInitText.Text),
                    Convert.ToInt32(addHealthText.Text),
                    Convert.ToInt32(addMaxHealthText.Text),
                    actor);
            }
            catch (FighterException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return;
            }

            if (_setOfFighters.Contains(added))
                return;

            _setOfFighters.Add(added);

            deleteComboBox.Items.Add(added);
            initChangeComboBox.Items.Add(added);
            damageComboBox.Items.Add(added);

            Display();
            Relocate(27);
        }
        public void ConcentrationCheck(Fighter concFighter, bool check)
        {
            concFighter.Concentration = check;

            if (concFighter == _currentFighter)
                concentraionText.Visible = check;
        }
        private void Relocate(int move)
        {
            if (_setOfFighters.Count > 4)
            {
                int add_move = (_setOfFighters.Count % 2 == 1) ? 1 : 0;
                move = (move > 0) ? move + add_move : move - add_move;
                nameText.Height += move;
                initText.Height += move;
                healthText.Height += move;
                _label1.Location = new Point(_label1.Location.X, _label1.Location.Y + move / 2);
                _label2.Location = new Point(_label2.Location.X, _label2.Location.Y + move / 2);
                if (_setOfFighters.Count > 7)
                {
                    listOfCharactersGroupBox.Height += move;
                    addGroupBox.Location = new Point(addGroupBox.Location.X, addGroupBox.Location.Y + move);
                    dropGroupBox.Location = new Point(dropGroupBox.Location.X, dropGroupBox.Location.Y + move);
                }
            }
        }
        private void Init_change_button_Click(object sender, EventArgs e)
        {
            if (_setOfFighters.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Error!");
                return;
            }

            if (initChangeComboBox.Text == "")
            {
                MessageBox.Show("Герой не выбран!", "Error!");
                return;
            }

            if (initChangeComboBox.SelectedItem is Fighter fighter 
                    && int.TryParse(initChangeButton.Text, out int init))
                fighter.Initiative = init;

            Display();
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (_setOfFighters.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Error!");
                return;
            }
            if (deleteComboBox.Text == "")
            {
                MessageBox.Show("Герой не выбран!", "Error!");
                return;
            }

            Relocate(-27);

            if (deleteComboBox.SelectedItem is Fighter fighter)
            {
                _setOfFighters.Remove(fighter);
                initChangeComboBox.Items.Remove(fighter);
                damageComboBox.Items.Remove(fighter);
                deleteComboBox.Items.Remove(fighter);
            }

            Display();
        }
        private void Damage_button_Click(object sender, EventArgs e)
        {
            if (_setOfFighters.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Error!");
                return;
            }
            if (damageComboBox.Text == "")
            {
                MessageBox.Show("Герой не выбран!", "Error!");
                return;
            }

            if (damageComboBox.SelectedItem is Fighter fighter &&
                int.TryParse(damageText.Text, out int damage))
            {
                fighter.Damage(damage);

                if (fighter.IsDead)
                {
                    Relocate(-27);

                    _setOfFighters.Remove(fighter);

                    initChangeComboBox.Items.Remove(damageComboBox.Text);
                    deleteComboBox.Items.Remove(damageComboBox.Text);
                    damageComboBox.Items.Remove(damageComboBox.Text);

                    Display();
                }
                else if (fighter.Concentration && damage > 0)
                {
                    Concentration save = new(this, fighter, damage);
                    save.Show();
                }
            }
        }
        private void Conc_button_Click(object sender, EventArgs e)
        {
            if (_setOfFighters.Count == 0)
            {
                MessageBox.Show("Список пуст","Error!");
                return;
            }
            _currentFighter!.Concentration = !_currentFighter.Concentration;
            concentraionText.Visible = _currentFighter.Concentration;
        }
    }
}
