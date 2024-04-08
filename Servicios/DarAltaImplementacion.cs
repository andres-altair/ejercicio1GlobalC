using ejercicio1GlobalC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Servicios
{
    internal class DarAltaImplementacion : DarAltaInterfaz
    {
        GenerarIdInterfaz gi = new GenerarIdImplemntacion();
        public void bibliotecaAlta(List<BibliotecaDto> listabibliteca)
        {
            long id = gi.generarIdBiblioteca(listabibliteca);
            Console.WriteLine("escribe el nombre ");
            string nombre= Console.ReadLine();
            Console.WriteLine("escrie al direccion");
            string direccion = Console.ReadLine();  
            BibliotecaDto nuevaBinlioteca = new BibliotecaDto(id,nombre,direccion);
            listabibliteca.Add(nuevaBinlioteca);
        }

        public void clienteAlta(List<ClienteDto> listaCliente)
        {
            long id = gi.generarIdCliente(listaCliente);
            Console.WriteLine("escribe tu nombre");
            //cliente.Nombre = Console.ReadLine();
            string nombre = Console.ReadLine();
            Console.WriteLine("escribe tu apellido");
            //cliente.Apellidos = Console.ReadLine();
            string apellido = Console.ReadLine();
            Console.WriteLine("escribe tu fecha de nacimiento (dd/MM/yyyy)");
            //cliente.Nacimiento = Convert.ToDateTime(Console.ReadLine());
            DateTime fchNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("escribe tu dni");
            //cliente.Dni = Console.ReadLine();
            string dni = Console.ReadLine();
            Console.WriteLine("escribe tu correo electronico");
            //cliente.CorreoElectronico = Console.ReadLine();
            string correoElectronico  = Console.ReadLine();
            ClienteDto cliente = new ClienteDto(id,nombre,apellido,fchNacimiento,dni,correoElectronico);

            listaCliente.Add(cliente);
            List<BibliotecaDto> listaBiblioteca = new List<BibliotecaDto>();

            foreach (BibliotecaDto bi in listaBiblioteca)
            {
                Console.WriteLine(bi.Nombre.ToString());
            }
            Console.WriteLine("en que biblioteca te vas ha registrar");
            string biblioteca = Console.ReadLine();

            BibliotecaDto nuevaBinlioteca = new BibliotecaDto();
            if(nuevaBinlioteca.Nombre.Equals(biblioteca)) 
            {
                nuevaBinlioteca.ClienteDtos.Add(cliente);
            }
            else
            {
                Console.WriteLine("biblioteca elegida no existe");
            }

        }

        public void libroAlta(List<LibroDto> listaLibro)
        {
            long id = gi.generarIdLibro(listaLibro);
            Console.WriteLine("escribe el titulo");
            string titulo = Console.ReadLine();
            Console.WriteLine("escribe el subtitulo");
            string subtitulo = Console.ReadLine();
            Console.WriteLine("escribe el nombre del autor");
            string autor = Console.ReadLine();
            Console.WriteLine("escribe el ISBN");
            string ISBN = Console.ReadLine();
            Console.WriteLine("escribe el numero de la edicion");
            int  numEdicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe la editorial");
            string editorial = Console.ReadLine();
            Console.WriteLine("escribe el numero de stock");
            int stock = Convert.ToInt32(Console.ReadLine());
            LibroDto libroDto = new LibroDto(id,titulo,subtitulo,autor,ISBN,numEdicion,editorial,stock);

            listaLibro.Add(libroDto);
            List<BibliotecaDto> listaBiblioteca = new List<BibliotecaDto>();

            foreach (BibliotecaDto bi in listaBiblioteca)
            {
                Console.WriteLine(bi.Nombre.ToString());
            }
            Console.WriteLine("en que biblioteca te vas ha registrar");
            string biblioteca = Console.ReadLine();

            BibliotecaDto nuevaBinlioteca = new BibliotecaDto();
            if (nuevaBinlioteca.Nombre.Equals(biblioteca))
            {
                nuevaBinlioteca.LibroDtos.Add(libroDto);
            }
            else
            {
                Console.WriteLine("biblioteca elegida no existe");
            }
        }

        public void prestamoAlta(List<PrestamoDto> listaPrestamo)
        {
            BibliotecaDto Biblioteca = new BibliotecaDto();
            List<object> listaCli = new List<object>();
            //listaCli.Add(Biblioteca.ClienteDtos);
           // listaCli a = new listaCli();
            
            
            
            long id = gi.generarIdPrestamo(listaPrestamo);
            Console.WriteLine("escribe el identificador del cliente");
            long idCliente = Convert.ToInt64(id);
            //if(idCliente==Biblioteca.ClienteDtos.id)
            Console.WriteLine("escribe el identificador del libro");
            long idLibro = Convert.ToInt64(id);
            Console.WriteLine("escribe la fecha de prestamo");
            DateTime fchPrestamo = Convert.ToDateTime(idCliente);
            Console.WriteLine("escribe el estado del prestamo");
            string estado  = Console.ReadLine();    
            PrestamoDto prestamo = new PrestamoDto(id,idCliente,idLibro,fchPrestamo,estado);
            listaPrestamo.Add(prestamo);
            List<BibliotecaDto> listaBiblioteca = new List<BibliotecaDto>();

            foreach (BibliotecaDto bi in listaBiblioteca)
            {
                Console.WriteLine(bi.Nombre.ToString());
            }
            Console.WriteLine("en que biblioteca te vas ha registrar");
            string biblioteca = Console.ReadLine();

            BibliotecaDto nuevaBinlioteca = new BibliotecaDto();
            if (nuevaBinlioteca.Nombre.Equals(biblioteca))
            {
                nuevaBinlioteca.PrestamoDtos.Add(prestamo);
            }
            else
            {
                Console.WriteLine("biblioteca elegida no existe");
            }
        }
    }
}
