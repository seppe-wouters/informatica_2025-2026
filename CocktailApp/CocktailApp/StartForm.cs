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

namespace CocktailApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnMojito_Click(object sender, EventArgs e)
        {
            IngredientenForm form = new IngredientenForm(new Ingredienten(50, 13, 37, "Suikersiroop", true, "Mojito", Color.LawnGreen));
            form.Show();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            IngredientenForm form = new IngredientenForm(new Ingredienten(20, 70, 10, "sapjes", true, "Pornstar Martini", Color.Orange));
            form.Show();
        }

        private void btnSOTB_Click(object sender, EventArgs e)
        {
            IngredientenForm form = new IngredientenForm(new Ingredienten(10, 80, 10, "fruitsap", true, "Sex on the beach", Color.Pink));
            form.Show();
        }

        private void btnLIIT_Click(object sender, EventArgs e)
        {
            IngredientenForm form = new IngredientenForm(new Ingredienten(0, 80, 20, "Cola", true, "Long island ice-tea", Color.Sienna));
            form.Show();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            IngredientenForm form = new IngredientenForm(new Ingredienten(0, 75, 25, "Limoensap", true, "Margherita", Color.Khaki));
            form.Show();
        }

        private void btnVM_Click(object sender, EventArgs e)
        {
            IngredientenForm form = new IngredientenForm(new Ingredienten(60, 0, 40, "Suikersiroop", false, "Virgin Mojito", Color.DarkGreen));
            form.Show();
        }

        private void btnSSOTB_Click(object sender, EventArgs e)
        {
            IngredientenForm form = new IngredientenForm(new Ingredienten(30, 0, 70, "Sapjes", false, "Safe sex on the beach", Color.Crimson));
            form.Show();
        }

        private void btnBL_Click(object sender, EventArgs e)
        {
            IngredientenForm form = new IngredientenForm(new Ingredienten(0, 60, 40, "Citroensap", true, "Blue lagoon", Color.LightSteelBlue));
            form.Show();
        }
    }
}
