using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper.Forms
{
    public partial class InputBoxForm : Form
    {
        private String playerName;

        public InputBoxForm()
        {
            InitializeComponent();
        }

        private void acceptPlayerNameButton_Click(object sender, EventArgs e)
        {
            playerName = playerNameBox.Text;
            this.Hide();
        }

        public String GetPlayerName()
        {
            return playerName;
        }
    }
}
