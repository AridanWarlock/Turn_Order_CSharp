using System.Collections.ObjectModel;
using System.Linq;

namespace TurnOrder
{
    internal partial class TurnOrderForm : Form, IFighterObserver
    {
        public TurnOrderForm()
        {
            InitializeComponent();
        }
        private readonly Army army = new();
        private void Turn_Order_Form_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            army.RegisterObserver(deleteComboBox);
            army.RegisterObserver(initChangeComboBox);
            army.RegisterObserver(damageComboBox);
            army.RegisterObserver(this);

            var elly = new Hero("Элли", 12, 31, 40);
            var walt = new Hero("Вальт", 17, 50, 60);

            army.AddFighter(elly);
            army.AddFighter(walt);
        }
        private void Next_button_Click(object sender, EventArgs e)
        {
            army.NextTurn();

            if (army.CurrentFighter != null)
            {
                currentFighterLabel.Text = army.CurrentFighter.Name;
                concentraionText.Visible = army.CurrentFighter.Concentration;
            }
        }
        private void Display()
        {
            nameText.Clear();
            initText.Clear();
            healthText.Clear();

            foreach (var fighter in army.Fighters)
            {
                nameText.Text += fighter.Name + Environment.NewLine;
                initText.Text += fighter.Initiative + Environment.NewLine;
                healthText.Text += fighter.Health + " \\ " + fighter.MaxHealth + Environment.NewLine;
            }
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            Fighter added;

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

            army.AddFighter(added);
        }
        public void ConcentrationCheck(Fighter concFighter, bool check)
        {
            concFighter.Concentration = check;

            if (concFighter == army.CurrentFighter)
                concentraionText.Visible = check;
        }
        private void Relocate(int move)
        {
            if (army.Fighters.Count > 4)
            {
                int add_move = (army.Fighters.Count % 2 == 1) ? 1 : 0;
                move = (move > 0) ? move + add_move : move - add_move;
                nameText.Height += move;
                initText.Height += move;
                healthText.Height += move;
                _label1.Location = new Point(_label1.Location.X, _label1.Location.Y + move / 2);
                _label2.Location = new Point(_label2.Location.X, _label2.Location.Y + move / 2);
                if (army.Fighters.Count > 7)
                {
                    listOfCharactersGroupBox.Height += move;
                    addGroupBox.Location = new Point(addGroupBox.Location.X, addGroupBox.Location.Y + move);
                    dropGroupBox.Location = new Point(dropGroupBox.Location.X, dropGroupBox.Location.Y + move);
                }
            }
        }
        private void Init_change_button_Click(object sender, EventArgs e)
        {
            if (initChangeComboBox.SelectedItem is Fighter fighter 
                    && int.TryParse(initChangeText.Text, out var init))
            {
                fighter.Initiative = init;
                Display();
            }
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (deleteComboBox.SelectedItem is Fighter fighter)
                fighter.RemoveNotifyArmy();
        }
        private void Damage_button_Click(object sender, EventArgs e)
        {
            if (damageComboBox.SelectedItem is Fighter fighter &&
                int.TryParse(damageText.Text, out int damage))
            {
                fighter.Damage(damage);
                
                if (fighter.Concentration && damage > 0)
                {
                    var save = new Concentration(this, fighter, damage);
                    save.Show();
                }
                if (fighter == army.CurrentFighter)
                    concentraionText.Visible = fighter.Concentration;

                Display();
            }
        }
        private void Conc_button_Click(object sender, EventArgs e)
        {
            if (army.CurrentFighter is not null)
            {
                army.CurrentFighter.Concentration = !army.CurrentFighter.Concentration;
                concentraionText.Visible = army.CurrentFighter.Concentration;
            }
        }

        public void AddUpdateFighter(Fighter? fighter)
        {
            Relocate(27);
            Display();
        }
        public void RemoveUpdateFighter(Fighter? fighter)
        {
            Relocate(-27);
            Display();
        }
    }
}
