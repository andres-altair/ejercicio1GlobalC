using ejercicio1GlobalC.Dtos;

namespace ejercicio1GlobalC.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BibliotecaDto>listaBiblioteca = new List<BibliotecaDto>();
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<LibroDto> listaLibros = new List<LibroDto>();  
            List<PrestamoDto>listaPrestamos = new List<PrestamoDto>();
            if(listaBiblioteca.Count > 0)
            {
                bool abrir = false;
                int opcion;
                while(!abrir)
                {
                    switch (opcion)
                    {
                        case 0: abrir = true; 
                            break;
                        case 1: 

                    }
                }
            }
        }
    }
}