using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class CopierForm : Form
    {
        private Copier _copier;
        public CopierForm()
        {
            InitializeComponent();
            _copier = new Copier();
        }

        private void inWachtrijButton_Click(object sender, EventArgs e)
        {
            _copier.VoegPrintopdrachtToe((int)paginasNumericUpDown.Value, (int)kopiesNumericUpDown.Value);
            paginasNumericUpDown.Value = 1;
            kopiesNumericUpDown.Value = 1;
            UpdateForm();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (wachtrijListBox.Items.Count != 0)
                {
                    _copier.Print();
                    UpdateForm();
                }
                else throw new ArgumentNullException("geen printopdrachten");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Geen printopdrachten aangemaakt");
            }
            
        }

        public void UpdateForm()
        {
            wachtrijListBox.DataSource = null;
            wachtrijListBox.DataSource = _copier.Wachtrij;
            tellerTextBox.Text = _copier.Teller.ToString();
        }
    }
}
