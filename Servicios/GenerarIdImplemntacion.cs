using ejercicio1GlobalC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Servicios
{
    internal class GenerarIdImplemntacion : GenerarIdInterfaz
    {
        /// <summary>
        /// metodo que se encarga de crear un id
        /// </summary>
        /// <returns>long (id)</returns>
        public long generarIdBiblioteca(List<BibliotecaDto> listaBiblioteca)
        {
           long id;
                int tamaño = listaBiblioteca.Count;
                if (tamaño > 0)
                {
                    id = listaBiblioteca[tamaño - 1].Id + 1;
                }
                else
                {
                    id = 1;
                }
                return id;     
        }

        public long generarIdCliente(List<ClienteDto> listaCliente)
        {
            long id;
            int tamaño = listaCliente.Count;
            if (tamaño > 0)
            {
                id = listaCliente[tamaño - 1].Id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }

        public long generarIdLibro(List<LibroDto> listaLibro)
        {
            long id;
            int tamaño = listaLibro.Count;
            if (tamaño > 0)
            {
                id = listaLibro[tamaño - 1].Id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }

        public long generarIdPrestamo(List<PrestamoDto> listaPrestamo)
        {
            long id;
            int tamaño = listaPrestamo.Count;
            if (tamaño > 0)
            {
                id = listaPrestamo[tamaño - 1].Id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }
    }
}
