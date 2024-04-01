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

    }
}
