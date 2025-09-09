using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wekker
{
    public partial class WekkerForm : Form
    {
        public Wekker _wekker = new Wekker();
        public WekkerForm()
        {
            InitializeComponent();

            UpdateWekker();
        }

        private void uurOmhoogButton_Click(object sender, EventArgs e)
        {
            _wekker.UrenPlus();
            UpdateWekker();
        }

        private void minuutOmhoogButton_Click(object sender, EventArgs e)
        {
            _wekker.MinutenPlus();
            UpdateWekker();
        }

        private void uurOmlaagButton_Click(object sender, EventArgs e)
        {
            _wekker.UrenMin();
            UpdateWekker();
        }

        private void minuutOmlaagButton_Click(object sender, EventArgs e)
        {
            _wekker.MinutenMin();
            UpdateWekker();
        }

        public void UpdateWekker()
        {
            alarmOmTextBox.Text = _wekker.AlarmOm();
        }
    }
}
