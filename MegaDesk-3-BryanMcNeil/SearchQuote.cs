using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_BryanMcNeil
{
    public partial class SearchQuote : Form
    {
        public SearchQuote(Form form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form1.Hide();
        }
        private Form form1;

        private void SearchExit_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
