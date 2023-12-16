using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turn_Order
{
    public partial class Concentration : Form
    {
        public Concentration()
        {
            InitializeComponent();
        }
        public Concentration(Turn_Order_Form parent, int damage, string name)
        {
            InitializeComponent();
            _Parent = parent;
            Dc_text.Text = damage.ToString();
            Hero_name_text.Text = name;
        }
        private Turn_Order_Form _Parent;
        private void Yes_button_Click(object sender, EventArgs e)
        {
            _Parent.Concentration_check(Hero_name_text.Text, true);
            Close();
        }

        private void No_button_Click(object sender, EventArgs e)
        {
            _Parent.Concentration_check(Hero_name_text.Text, false);
            Close();
        }
    }
}
