using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameForm oknoGry = new GameForm();
            oknoGry.Show();
            this.Hide();
        }

        private void btnUstawienia_Click(object sender, EventArgs e)
        {
            SettingsForm oknoUstawien = new SettingsForm();
            oknoUstawien.ShowDialog();
        }

        private void btnKoniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
