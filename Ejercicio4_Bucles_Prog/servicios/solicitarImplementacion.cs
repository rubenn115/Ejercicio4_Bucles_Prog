//Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Bucles_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz soicitar
    /// rbr - 021123
    /// </summary>
    internal class solicitarImplementacion : solicitarInterfaz
    {
        /// <summary>
        /// Método que solicitará por consola un número entero
        /// </summary>
        /// <returns></returns>
        public int solicitarNumero()
        {
            int numero;
            Console.WriteLine("Introduce un número entero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            return numero;
        }
    }
}
