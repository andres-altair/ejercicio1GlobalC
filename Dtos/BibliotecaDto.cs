using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Dtos
{
    internal class BibliotecaDto
    {
        long id;
        string nombre = "aaaaaa";
        string direccion = "aaaaaa";
        List<ClienteDto> clienteDtos = new List<ClienteDto>();
        List<LibroDto> libroDtos = new List<LibroDto>();
        List<PrestamoDto> prestamoDtos = new List<PrestamoDto>();

        public BibliotecaDto() { }
        public BibliotecaDto(long id, string nombre, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.clienteDtos = clienteDtos;
            this.libroDtos = libroDtos;
            this.prestamoDtos = prestamoDtos;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<ClienteDto> ClienteDtos { get => clienteDtos; set => clienteDtos = value; }
        internal List<LibroDto> LibroDtos { get => libroDtos; set => libroDtos = value; }
        internal List<PrestamoDto> PrestamoDtos { get => prestamoDtos; set => prestamoDtos = value; }
    }
}
