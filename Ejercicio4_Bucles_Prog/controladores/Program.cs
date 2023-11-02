//Ruben Bernal Ramos, CSI1

using Ejercicio4_Bucles_Prog.servicios;

namespace Ejercicio4_Bucles_Prog.controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 021123
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la apicación
        /// rbr - 021123
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            //Declaro las variables
            int numero;
            char respuesta = 's';

            //Instancio las interfaces con sus implementaciones
            solicitarInterfaz si = new solicitarImplementacion();
            calcularInterfaz ci = new calcularImplementacion();

            do
            {
                //Solicito el número entero
                numero = si.solicitarNumero();

                //Realizo la operación
                ci.calculo(numero);

                Console.WriteLine("Quieres volver a probar??? (s = si  //  n = no):");
                respuesta = Convert.ToChar(Console.ReadLine());
            } while (respuesta == 's');
        }
    }
}