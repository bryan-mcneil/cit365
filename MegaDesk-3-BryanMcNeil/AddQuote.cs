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
    public partial class AddQuote : Form
    {
        public ErrorProvider IntError { get; }

        public AddQuote()
        {
            InitializeComponent();
            IntError = new ErrorProvider();
        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(WidthBox.Text) < 23 || int.Parse(WidthBox.Text) > 96)
            {
                e.Cancel = true;
                WidthBox.Select(0, WidthBox.Text.Length);
                this.IntError.SetError(WidthBox, "Min Width 24\" Max Width: 96\'");
            }

        }

        private void WidthBox_Validated(object sender, EventArgs e)
        {
            this.IntError.SetError(WidthBox, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayQuote DisplayNewQuoteForm = new DisplayQuote();
            DisplayNewQuoteForm.Show();
            this.Hide();
        }
    }
}
