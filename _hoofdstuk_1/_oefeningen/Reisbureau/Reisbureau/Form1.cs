using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisbureau
{
    public partial class Form1 : Form
    {
        public Groepsreis Tuvalu = new Groepsreis("Tuvalu", 7, 2500);
        public Form1()
        {
            InitializeComponent();
        }


    }
}
