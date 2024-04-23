using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Servicios
{
    /// <summary>
    /// implemtacion que implementa a MenuInterfaz
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {
            try 
            {
                Console.WriteLine("0. cerrar");
                Console.WriteLine("1. crear biblioteca");
                Console.WriteLine("2. crea un cliente");
                Console.WriteLine("3. crea un libro");
                Console.WriteLine("4. crea un prestamo");
                int opcion = Convert.ToInt32(Console.ReadLine());
                return opcion;
            }
            catch { throw; }
        }
    }
}
