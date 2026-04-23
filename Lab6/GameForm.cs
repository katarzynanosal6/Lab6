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
    public partial class GameForm : Form
    {
        int[,] mapaPola; 
        int pozostalyCzas;
        int znalezioneDydelfy = 0;

        public GameForm()
        {
            InitializeComponent();
        }


    }
}
