using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagWeb
{
    internal class URL
    {
        string pagina;
        int veces;
        DateTime fehca;

        public string Pagina { get => pagina; set => pagina = value; }
        public int Veces { get => veces ; set => veces = value; }
        public DateTime Fehca { get => fehca; set => fehca = value; }
    }
}
