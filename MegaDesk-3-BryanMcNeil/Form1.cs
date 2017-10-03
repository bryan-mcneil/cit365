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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote(this);
            addNewQuoteForm.Show();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ViewQuote viewQuoteForm = new ViewQuote(this);
            viewQuoteForm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchQuote viewQuoteForm = new SearchQuote(this);
            viewQuoteForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
