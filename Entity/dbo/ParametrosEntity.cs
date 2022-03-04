using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ParametrosEntity : DBEntity
    {
        public int? Id_Parametro { get; set; }

        public string Descripcion { get; set; }
        public object Codigo { get; set; }
        public object Valor { get; set; }
        public object Estado { get; set; }
    }
}
