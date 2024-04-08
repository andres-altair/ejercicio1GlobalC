using ejercicio1GlobalC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Util
{
    internal class Utilidades
    {
        private long generarId()
        {
            List<object> listaBiblioteca = new List<object>();
            long id;
            int tamaño = listaBiblioteca.Count;
            if (tamaño > 0)
            {
                id = listaBiblioteca.Count + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }
    }
}
