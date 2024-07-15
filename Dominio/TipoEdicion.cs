using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoEdicion
    {
        public int Id { get; set; }
        [DisplayName("Descripción")]
        public string Descricion { get; set; }
    }
}
