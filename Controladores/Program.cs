using ejercicio1GlobalC.Dtos;
using ejercicio1GlobalC.Servicios;

namespace ejercicio1GlobalC.Controladores
{
    /// <summary>
    /// clase principal
    /// 01/02/24 - amd
    /// </summary>
    class Program
    {
        /// <summary>
        /// metodo principal
        /// 01/02/24 - amd
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\profesor\\Desktop\\repasoGlobal";
            
            List<BibliotecaDto>listaBiblioteca = new List<BibliotecaDto>();
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<LibroDto> listaLibros = new List<LibroDto>();  
            List<PrestamoDto>listaPrestamos = new List<PrestamoDto>();
            MenuInterfaz mi = new MenuImplementacion();
            DarAltaInterfaz di = new DarAltaImplementacion();

            if(listaBiblioteca.Count == 0)
            {
                di.bibliotecaAlta(listaBiblioteca);

                bool abrir = false;
                int opcion;
                while (!abrir)
                {
                    opcion = mi.menu();
                    switch (opcion)
                    {
                        case 0:
                            abrir = true;
                            break;
                        case 1:
                            di.bibliotecaAlta(listaBiblioteca);
                            break;
                        case 2:
                            di.clienteAlta(listaClientes,listaBiblioteca);
                            break;
                        case 3:
                            di.libroAlta(listaLibros, listaBiblioteca);
                            break;
                        case 4:
                            di.prestamoAlta(listaPrestamos, listaBiblioteca);
                            break;
                            case 5:
                                foreach(BibliotecaDto a in listaBiblioteca)
                            {
                                Console.WriteLine(a.Nombre.ToString());
                            }
                                break;
                        default:
                            Console.WriteLine("eleccion no reconocida");
                            break;

                    }
                }
            }
            else
            {
                bool abrir = false;
                int opcion;
                while (!abrir)
                {
                    opcion = mi.menu();
                    switch (opcion)
                    {
                        case 0:
                            abrir = true;
                            break;
                        case 1:
                            di.bibliotecaAlta(listaBiblioteca);
                            break;
                        case 2:
                            di.clienteAlta(listaClientes, listaBiblioteca);
                            break;
                        case 3:
                            di.libroAlta(listaLibros,  listaBiblioteca);
                            break;
                        case 4:
                            di.prestamoAlta(listaPrestamos, listaBiblioteca);
                            break;
                        default:
                            Console.WriteLine("eleccion no reconocida");
                            break;

                    }
                }
            }
        }
    }
}