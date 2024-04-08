using ejercicio1GlobalC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Servicios
{
    internal interface GenerarIdInterfaz
    {
        /// <summary>
        /// metodo que se encarga de crear un id
        /// </summary>
        /// <returns>long (id)</returns>
        public long generarIdBiblioteca(List<BibliotecaDto> listaBiblioteca);



        /// <summary>
        /// metodo que se encarga de crear un id
        /// </summary>
        /// <returns>long (id)</returns>
        public long generarIdCliente(List<ClienteDto> listaCliente);

        /// <summary>
        /// metodo que se encarga de crear un id
        /// </summary>
        /// <returns>long (id)</returns>
        public long generarIdPrestamo(List<PrestamoDto> listaPrestamo);


        /// <summary>
        /// metodo que se encarga de crear un id
        /// </summary>
        /// <returns>long (id)</returns>
        public long generarIdLibro(List<LibroDto> listaLibro);


    }
}
