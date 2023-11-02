//Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Bucles_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz calcular
    /// rbr - 021123
    /// </summary>
    internal class calcularImplementacion : calcularInterfaz
    {
        /// <summary>
        /// Método que realizará la operación solicitada por el ejercicio
        /// rbr - 021123
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int calculo(int numero)
        {
            int multiplicacion = 1;
            for (int contador = 1; contador <= numero; contador++)
            {
                multiplicacion = multiplicacion * contador;
            }
            Console.WriteLine("La multiplicación de todos los números hasta " + numero + " es : " + multiplicacion);
            return multiplicacion;
        }
    }
}
