namespace Turn_Order
{
    internal partial class Concentration : Form
    {
        public Concentration(TurnOrderForm parent, Fighter fighter, int damage)
        {
            InitializeComponent();

            _parent = parent;
            _fighter = fighter;

            heroNameText.Text = _fighter.Name;

            damage = damage > 20 ? damage / 2 : 10;
            dcText.Text = damage.ToString();
        }
        private readonly TurnOrderForm _parent;
        private Fighter _fighter;
        private void Yes_button_Click(object sender, EventArgs e)
        {
            _parent.ConcentrationCheck(_fighter, true);
            //_parent.concentraionText.Visible = _fighter.Concentration;
            Close();
        }

        private void No_button_Click(object sender, EventArgs e)
        {
            _parent.ConcentrationCheck(_fighter, false);
            Close();
        }
    }
}
