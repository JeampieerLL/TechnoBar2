using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno2
{
    public class ProductoDto
    {
        public string Id_Producto { get; set; }
        public string Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int stock { get; set; }
    }
}
