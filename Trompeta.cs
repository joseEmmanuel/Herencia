using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Trompeta : Orquesta
    {
        public Trompeta() { 
        
        }
        public override String informacion()
        {
            return "INFORMACION DEL Trompeta \n"
                + "Nombre: " + this.nombre
                + "\n Notas: " + this.notas
                + "\n Precio: " + this.precio;
        }
    }
}