//Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Bucles_Prog.servicios
{
    /// <summary>
    /// Interfaz para el cálaculo que necesitaremos hacer
    /// rbr - 021123
    /// </summary>
    internal interface calcularInterfaz
    {
        /// <summary>
        /// Enunciado del método que tendrá la implementación
        /// rbr - 021123
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public int calculo(int numero);
    }
}
