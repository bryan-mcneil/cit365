using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BryanMcNeil
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(List<string> info, Form form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form1.Hide();
            label5.Text = info.ElementAt(0);
            label6.Text = info.ElementAt(1);
            label7.Text = info.ElementAt(2);
            label8.Text = info.ElementAt(3);
            label9.Text = info.ElementAt(4);
        }

        private Form form1;

        private void displayExit_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
