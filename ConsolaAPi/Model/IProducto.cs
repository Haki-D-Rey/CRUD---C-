using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAPi.Model
{
        public interface IProducto
        {
            int? idProducto { get; set; }
            string descripcion { get; set; }
            int cantidad { get; set; }
            string? precio { get; set; }
            DateTime fechaCreacion { get; set; }
            DateTime? fechaModificacion { get; set; }
            bool estadoActivo { get; set; }
        }
    
}
