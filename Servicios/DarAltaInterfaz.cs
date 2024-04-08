using ejercicio1GlobalC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Servicios
{
    /// <summary>
    /// interfaz encargada de las acciones de dar alta 
    /// 02/02/24 - amd
    /// </summary>
    internal interface DarAltaInterfaz
    {
        /// <summary>
        /// metodo que se encarga de dar alta una biblioteca
        /// 02/02/24 - amd
        /// </summary>
        public void bibliotecaAlta(List<BibliotecaDto> listaBibliteca);
        
        /// <summary>
        /// metodo que se encarga de dar alta un cliente
        /// 02/02/24 - amd
        /// </summary>
        public void clienteAlta(List<ClienteDto> listaCliente);
        
        /// <summary>
        /// metodo que se encarga de dar alta un libro
        /// 02/02/24 - amd
        /// </summary>
        public void libroAlta(List<LibroDto> listaLibro);
        
        /// <summary>
        /// metodo que se encarga de dar alta un prestamo
        /// 02/02/24 - amd
        /// </summary>
        public void prestamoAlta(List<PrestamoDto> listaPrestamo);
    }
}
