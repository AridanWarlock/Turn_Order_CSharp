namespace Turn_Order
{
    public partial class Turn_Order_Form : Form
    {
        public Turn_Order_Form()
        {
            InitializeComponent();
        }

        private readonly List<Fighter> fighters = [];
        private int _current_fighter = 0;

        private int Current_fighter 
        {
            get => _current_fighter;
            set => _current_fighter = (fighters.Count == 0)
                ? -1
                : value;
        }
        private void Next_button_Click(object sender, EventArgs e)
        {
            if (fighters.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Error!");
                return;
            }
            Current_fighter = (Current_fighter == fighters.Count - 1) ? (0) : (Current_fighter + 1);
            Current_label.Text = fighters[Current_fighter].Name;
            Conc_text.Visible = fighters[Current_fighter].Concentration;
        }
        private void Turn_Order_Form_Load(object sender, EventArgs e)
        {
            Fighter a = new Hero("Элли", 12, 31, 40);
            Fighter b = new Hero("Вальт", 17, 50, 60);
            fighters.Add(a);
            fighters.Add(b);

            fighters.Sort();
            Current_label.Text = fighters[0].Name;

            Delete_comboBox.Items.Add(fighters[0].Name);
            Init_change_comboBox.Items.Add(fighters[0].Name);
            Damage_comboBox.Items.Add(fighters[0].Name);

            Delete_comboBox.Items.Add(fighters[1].Name);
            Init_change_comboBox.Items.Add(fighters[1].Name);
            Damage_comboBox.Items.Add(fighters[1].Name);

            Display();
        }
        private void Display()
        {
            Name_text.Clear();
            Init_text.Clear();
            Health_text.Clear();
            for (int i = 0; i < fighters.Count; i++)
            {
                Name_text.Text += fighters[i].Name + Environment.NewLine;
                Init_text.Text += fighters[i].Initiative + Environment.NewLine;
                Health_text.Text += fighters[i].Health + " \\ " + fighters[i].Max_health + Environment.NewLine;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (Add_name_text.Text == "" || Add_health_text.Text == ""
                || Add_max_health_text.Text == "" || Add_init_text.Text == "")
            {
                MessageBox.Show("Введите данные!", "Warning!");
                return;
            }

            if (!(int.TryParse(Add_init_text.Text, out _)
                && int.TryParse(Add_health_text.Text, out _) &&
                int.TryParse(Add_max_health_text.Text, out _)))
            {
                MessageBox.Show("Некорректный ввод!", "Error!");
                return;
            }
            Fighter added;
            try
            {
                if (Actor_check.Checked)
                {
                    added = new Hero(
                        Add_name_text.Text,
                        Convert.ToInt32(Add_init_text.Text),
                        Convert.ToInt32(Add_health_text.Text),
                        Convert.ToInt32(Add_max_health_text.Text));
                }
                else
                {
                    added = new Villain(
                        Add_name_text.Text,
                        Convert.ToInt32(Add_init_text.Text),
                        Convert.ToInt32(Add_health_text.Text),
                        Convert.ToInt32(Add_max_health_text.Text));
                }
            }
            catch (Fighter_Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return;
            }
            if (fighters.Count > 0)
            {
                if (fighters.IndexOf(added) >= 0)
                {
                    MessageBox.Show("Такой герой уже существует!", "Error!");
                    return;
                }
            }
            else
                Current_fighter = 0;
            fighters.Add(added);
            if (added.Initiative > fighters[Current_fighter].Initiative)
                Current_fighter++;

            fighters.Sort();
            Delete_comboBox.Items.Add(added.Name);
            Init_change_comboBox.Items.Add(added.Name);
            Damage_comboBox.Items.Add(added.Name);
            Display();
            Relocate(27);
        }
        public void Concentration_check(string name, bool check)
        {
            int index = fighters.FindIndex(pred => pred.Name == name);
            fighters[index].Concentration = check;
            if (index == Current_fighter)
            {
                Conc_text.Visible = check;
            }
        }
        private void Relocate(int move)
        {
            if (fighters.Count > 4)
            {
                int add_move = (fighters.Count % 2 == 1) ? 1 : 0;
                move = (move > 0) ? move + add_move : move - add_move;
                Name_text.Height += move;
                Init_text.Height += move;
                Health_text.Height += move;
                _label1.Location = new Point(_label1.Location.X, _label1.Location.Y + move / 2);
                _label2.Location = new Point(_label2.Location.X, _label2.Location.Y + move / 2);
                if (fighters.Count > 7)
                {
                    List_of_Characters_groupBox.Height += move;
                    add_groupBox.Location = new Point(add_groupBox.Location.X, add_groupBox.Location.Y + move);
                    drop_groupBox.Location = new Point(drop_groupBox.Location.X, drop_groupBox.Location.Y + move);
                }
            }
        }
        private void Init_change_button_Click(object sender, EventArgs e)
        {
            if (fighters.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Error!");
                return;
            }
            if (Init_change_comboBox.Text == "")
            {
                MessageBox.Show("Герой не выбран!", "Error!");
                return;
            }
            fighters.Find(pred => pred.Name == Init_change_comboBox.Text)!.Initiative
                = Convert.ToInt32(Init_change_text.Text);
            fighters.Sort();
            Display();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (fighters.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Error!");
                return;
            }
            if (Delete_comboBox.Text == "")
            {
                MessageBox.Show("Герой не выбран!", "Error!");
                return;
            }
            Relocate(-27);
            int index = fighters.FindIndex(pred => pred.Name == Delete_comboBox.Text);
            fighters.RemoveAt(index);
            if (index <= Current_fighter)
                Current_fighter--;
            Init_change_comboBox.Items.Remove(Delete_comboBox.Text);
            Damage_comboBox.Items.Remove(Delete_comboBox.Text);
            Delete_comboBox.Items.Remove(Delete_comboBox.Text);
            Display();
        }

        private void Damage_button_Click(object sender, EventArgs e)
        {
            if (fighters.Count == 0)
            {
                MessageBox.Show("Список пуст!", "Error!");
                return;
            }
            int index = fighters.FindIndex(pred => pred.Name == Damage_comboBox.Text);
            if (index < 0)
            {
                MessageBox.Show("Герой не выбран!", "Error!");
                return;
            }
            if (fighters[index].Damage(Convert.ToInt32(Damage_text.Text)))
            {
                Relocate(-27);
                fighters.Remove(fighters.Find(pred => pred.Name == Damage_comboBox.Text)!);
                if (index <= Current_fighter)
                    Current_fighter--;
                Init_change_comboBox.Items.Remove(Damage_comboBox.Text);
                Delete_comboBox.Items.Remove(Damage_comboBox.Text);
                Damage_comboBox.Items.Remove(Damage_comboBox.Text);
                Display();
            }
            else if (Convert.ToInt32(Damage_text.Text) > 0 && fighters[index].Concentration)
            {
                int damage_check = (Convert.ToInt32(Damage_text.Text) > 20) ? (Convert.ToInt32(Damage_text.Text) / 2) : 10;
                Concentration save = new(this, damage_check, fighters[index].Name);
                save.Show();
            }
            Display();
        }

        private void Conc_button_Click(object sender, EventArgs e)
        {
            if (fighters.Count == 0)
            {
                MessageBox.Show("Список пуст","Error!");
                return;
            }
            fighters[Current_fighter].Concentration = !fighters[Current_fighter].Concentration;
            Conc_text.Visible = fighters[Current_fighter].Concentration;
        }
    }
}
