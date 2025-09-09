using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Printopdracht
    {
        private int _paginas;
        private int _exemplaren;

        public Printopdracht(int paginas, int exemplaren)
        {
            _paginas = paginas;
            _exemplaren = exemplaren;
        }
        
        public int Paginas
        {
            get { return _paginas; }
        }

        public int Exemplaren
        {
            get { return _exemplaren; }
        }
    }
}
