using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_game
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void okayButtonClick(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
