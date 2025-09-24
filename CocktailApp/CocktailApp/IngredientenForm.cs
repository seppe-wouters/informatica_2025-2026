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
    public partial class IngredientenForm : Form
    {
        Ingredienten _cocktail;
        public IngredientenForm(Ingredienten _cocktailIn)
        {
            InitializeComponent();
            _cocktail = _cocktailIn;

            UpdateForm();
        }
        private void UpdateForm()
        {
            lblNaamCocktail.Text = _cocktail.NaamCocktail;
            lblAlcohol.Text = _cocktail.Alcohol.ToString() + "%";
            lblNaamFrisdrank.Text = _cocktail.NaamFrisdrank;
            lblWater.Text = _cocktail.Water.ToString() + "%";
            lblPercentFrisdrank.Text = _cocktail.Frisdrank.ToString() + "%";
            cbIsAlcholisch.Checked = _cocktail.IsAlcoholisch;
            BackColor = _cocktail.Kleur;
        }

       
    }
}
