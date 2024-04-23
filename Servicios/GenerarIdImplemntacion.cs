using ejercicio1GlobalC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Servicios
{
    /// <summary>
    /// implemtacion que implementa a GenerarIdInterfaz
    /// </summary>
    internal class GenerarIdImplemntacion : GenerarIdInterfaz
    {
        public long generarIdBiblioteca(List<BibliotecaDto> listaBiblioteca)
        {
            try
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
            catch (Exception ex) { throw; } 
        }

        public long generarIdCliente(List<ClienteDto> listaCliente)
        {
            try
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
            catch (Exception ex) { throw; }    
        }

        public long generarIdLibro(List<LibroDto> listaLibro)
        {
            try
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
            catch (Exception ex) { throw; }          
        }

        public long generarIdPrestamo(List<PrestamoDto> listaPrestamo)
        {
            try
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
            catch (Exception ex) { throw; }            
        }
    }
}
