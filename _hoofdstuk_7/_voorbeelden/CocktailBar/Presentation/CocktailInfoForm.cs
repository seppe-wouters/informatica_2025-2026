using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;

namespace Presentation
{
    public partial class CocktailInfoForm : Form
    {
        private Cocktail _cocktail;

        public CocktailInfoForm(Cocktail cocktail)
        {
            InitializeComponent();
            _cocktail = cocktail;
            updateForm();
        }
        
        private void toonButton_Click(object sender, EventArgs e)
        {
            IngredientForm form = new IngredientForm((Ingredient)ingredientenListBox.SelectedItem);
            form.Show();
        }

        private void pittigerButton_Click(object sender, EventArgs e)
        {
            _cocktail.MaakPittiger();
            updateForm();
        }

        public void updateForm()
        {
            naamTextBox.Text = _cocktail.Naam;
            kostprijsTextBox.Text = _cocktail.Kostprijs.ToString("C");
            inhoudTextBox.Text = _cocktail.InhoudCocktail().ToString();
            alcoholpercentageTextBox.Text = _cocktail.Alcoholpercentage().ToString("P0");
            ingredientenListBox.DataSource = _cocktail.Ingredienten;
        }
    }
}
