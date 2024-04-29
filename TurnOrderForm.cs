using System.Collections.ObjectModel;
using System.Linq;

namespace TurnOrder
{
    internal partial class TurnOrderForm : Form
    {
        public TurnOrderForm()
        {
            InitializeComponent();
        }
        private readonly PriorityQueue<IFighter, IFighter> _queueOfTurns = new();
        private readonly SortedDictionary<string, IFighter> _dictOfFighters = [];

        private IFighter? _currentFighter;
        private void Turn_Order_Form_Load(object sender, EventArgs e)
        {
            //TopMost = true;
            WindowState = FormWindowState.Maximized;

            var elly = new Hero("Элли", 12, 31, 40);
            var walt = new Hero("Вальт", 17, 50, 60);

            _dictOfFighters.Add(elly.Name, elly);
            _dictOfFighters.Add(walt.Name, walt);

            deleteComboBox.Items.Add(elly);
            initChangeComboBox.Items.Add(elly);
            damageComboBox.Items.Add(elly);

            deleteComboBox.Items.Add(walt);
            initChangeComboBox.Items.Add(walt);
            damageComboBox.Items.Add(walt);

            Display();
        }
        private void Next_button_Click(object sender, EventArgs e)
        {
            if (_dictOfFighters.Count == 0)
            {
                _queueOfTurns.Clear();
                return;
            }

            if (_queueOfTurns.Count == 0)
            {
                foreach (var fighter in _dictOfFighters.Values)
                    _queueOfTurns.Enqueue(fighter, fighter);
            }

            do
                _currentFighter = _queueOfTurns.Dequeue();
            while (_currentFighter.IsDead);

            currentFighterLabel.Text = _currentFighter.Name;
            concentraionText.Visible = _currentFighter.Concentration;
        }
        private void Display()
        {
            nameText.Clear();
            initText.Clear();
            healthText.Clear();

            var orderedDict = from fighter in _dictOfFighters.Values
                              orderby fighter
                              select fighter;
            
            foreach (var fighter in orderedDict)
            {
                nameText.Text += fighter.Name + Environment.NewLine;
                initText.Text += fighter.Initiative + Environment.NewLine;
                healthText.Text += fighter.Health + " \\ " + fighter.MaxHealth + Environment.NewLine;
            }
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            IFighter added;
            try
            {
                if (!(int.TryParse(addInitText.Text, out int init)
                    && int.TryParse(addHealthText.Text, out int health) &&
                    int.TryParse(addMaxHealthText.Text, out int maxHealth)))
                {
                    MessageBox.Show("Некорректный ввод!", "Error!");
                    return;
                }

                if (heroCheck.Checked)
                {
                    added = new Hero(
                        addNameText.Text,
                        init,
                        health,
                        maxHealth);
                }
                else
                { 
                    added = new Villain(
                        addNameText.Text,
                        init,
                        health,
                        maxHealth);
                }
            }
            catch (FighterException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return;
            }

            if (_dictOfFighters.ContainsKey(added.Name))
                return;

            _dictOfFighters.Add(added.Name, added);

            deleteComboBox.Items.Add(added);
            initChangeComboBox.Items.Add(added);
            damageComboBox.Items.Add(added);

            Relocate(27);
            Display();
        }
        public void ConcentrationCheck(IFighter concFighter, bool check)
        {
            concFighter.Concentration = check;

            if (concFighter == _currentFighter)
                concentraionText.Visible = check;
        }
        private void Relocate(int move)
        {
            if (_dictOfFighters.Count > 4)
            {
                int add_move = (_dictOfFighters.Count % 2 == 1) ? 1 : 0;
                move = (move > 0) ? move + add_move : move - add_move;
                nameText.Height += move;
                initText.Height += move;
                healthText.Height += move;
                _label1.Location = new Point(_label1.Location.X, _label1.Location.Y + move / 2);
                _label2.Location = new Point(_label2.Location.X, _label2.Location.Y + move / 2);
                if (_dictOfFighters.Count > 7)
                {
                    listOfCharactersGroupBox.Height += move;
                    addGroupBox.Location = new Point(addGroupBox.Location.X, addGroupBox.Location.Y + move);
                    dropGroupBox.Location = new Point(dropGroupBox.Location.X, dropGroupBox.Location.Y + move);
                }
            }
        }
        private void Init_change_button_Click(object sender, EventArgs e)
        {
            if (initChangeComboBox.SelectedItem is IFighter fighter 
                    && int.TryParse(initChangeText.Text, out var init))
            {
                fighter.Initiative = init;
                Display();
            }
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (deleteComboBox.SelectedItem is IFighter fighter)
            {
                _dictOfFighters.Remove(fighter.Name);

                initChangeComboBox.Items.Remove(fighter);
                damageComboBox.Items.Remove(fighter);
                deleteComboBox.Items.Remove(fighter);

                if (fighter == _currentFighter)
                    Next_button_Click(sender, e);

                Relocate(-27);
                Display();
            }
        }
        private void Damage_button_Click(object sender, EventArgs e)
        {
            if (damageComboBox.SelectedItem is IFighter fighter &&
                int.TryParse(damageText.Text, out int damage))
            {
                fighter.Damage(damage);

                if (fighter.IsDead)
                {
                    _dictOfFighters.Remove(fighter.Name);

                    initChangeComboBox.Items.Remove(fighter);
                    deleteComboBox.Items.Remove(fighter);
                    damageComboBox.Items.Remove(fighter);

                    if (fighter == _currentFighter)
                        Next_button_Click(sender, e);

                    Relocate(-27);
                }
                else if (fighter.Concentration && damage > 0)
                {
                    var save = new Concentration(this, fighter, damage);
                    save.Show();
                }
                else if (fighter.IsKnocked && fighter.Equals(_currentFighter))
                    concentraionText.Visible = false;

                Display();
            }
        }
        private void Conc_button_Click(object sender, EventArgs e)
        {
            if (_dictOfFighters.Count == 0)
                return;

            if (_currentFighter is not null)
            {
                _currentFighter.Concentration = !_currentFighter.Concentration;
                concentraionText.Visible = _currentFighter.Concentration;
            }
        }
    }
}
