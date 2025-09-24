using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Ingredienten
    {
		//eigenschappen
		private int _water;
		private int _alcohol;
		private int _frisdrank;
		private string _naamFrisdrank;
		private bool _isAlcoholisch;
		private string _naamCocktail;
		private Color _kleur;

		//props read only
		public int Water
		{
			get { return _water; }
		}
		public int Alcohol
		{
			get { return _alcohol; }
		}
		public int Frisdrank
		{
			get { return _frisdrank; }
		}
		public string NaamFrisdrank
		{
			get { return _naamFrisdrank; }
		}
		public bool IsAlcoholisch
		{
			get { return _isAlcoholisch; }
		}
		public string NaamCocktail
		{
			get { return _naamCocktail; }
		}

		public Color Kleur
		{
			get { return _kleur; }
		}

		public Ingredienten(int water, int alcohol, int frisdrank, string naamFrisdrank, bool isAlcoholisch, string naamCocktail, Color kleur)
		{
			_water = water;
			_alcohol = alcohol;
			_frisdrank = frisdrank;
			_naamFrisdrank = naamFrisdrank;
			_isAlcoholisch = isAlcoholisch;
			_naamCocktail = naamCocktail;
			_kleur = kleur;
		}
	}
}
