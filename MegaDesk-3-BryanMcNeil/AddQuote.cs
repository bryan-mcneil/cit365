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
    public partial class AddQuote : Form
    {
        public AddQuote(Form form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form1.Hide();
        }
        private Form form1;

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> info = new List<string>();
            info.Add(NameBox.Text);
            info.Add(WidthBox.Text);
            info.Add(DepthBox.Text);
            info.Add(DrawerBox.Text);
            info.Add(MaterialBox.Text);

            TextWriter writer = new StreamWriter("quote.txt", true);
            writer.Write(NameBox.Text + ",");
            writer.Write(WidthBox.Text + ",");
            writer.Write(DepthBox.Text + ",");
            writer.Write(DrawerBox.Text + ",");
            writer.Write(MaterialBox.Text + '\n');
            writer.Close();

            DisplayQuote DisplayNewQuoteForm = new DisplayQuote(info, this);
            DisplayNewQuoteForm.Show();
        }

        private void addExit_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
