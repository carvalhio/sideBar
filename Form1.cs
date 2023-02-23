using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernSidebar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelButton1_MouseClick(object sender, MouseEventArgs e)
        {
            textLabel.Text = "Início";
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            textLabel.Text = "Usuários";
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            textLabel.Text = "Cadastros";
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            textLabel.Text = "Outras informações";
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            textLabel.Text = "Configurações";
        }
    }
}
