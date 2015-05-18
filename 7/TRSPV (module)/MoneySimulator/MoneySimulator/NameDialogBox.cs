using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneySimulator
{
    public partial class NameDialogBox : Form
    {
        public NameDialogBox()
        {
            InitializeComponent();
        }

        ApplicationForm mainForm;

        public NameDialogBox(ApplicationForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text != string.Empty)
            {
                mainForm.UserProfile.Name = nameTextBox.Text;
                mainForm.changeName();
                mainForm.Show();
                this.Close();
            }
        }
    }
}
