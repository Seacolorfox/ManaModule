using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaTemp
{
    public partial class SearchForm : Form
    {
        int selected;
        MainForm MainForm;
        public SearchForm(MainForm mainForm,int selected)
        {
            InitializeComponent();
            MainForm = mainForm;
            this.selected = selected;
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            textBox_search.Text = "";
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            if(selected==1)
                MainForm.renderSearchNameView(textBox_search.Text);
            else
                MainForm.renderSearchSexView(textBox_search.Text);
        }
    }
}
