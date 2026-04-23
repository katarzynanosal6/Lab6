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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
                GlobalneUstawienia.LiczbaDydelfow = (int)numDydelfy.Value;
                GlobalneUstawienia.X = (int)numX.Value;
                GlobalneUstawienia.Y = (int)numY.Value;
                GlobalneUstawienia.LiczbaKrokodyli = (int)numKrokodyle.Value;
                GlobalneUstawienia.LiczbaSzopow = (int)numSzopy.Value;
                GlobalneUstawienia.Czas = (int)numCzas.Value;

               
                this.Close();
            
        }
    }
}
