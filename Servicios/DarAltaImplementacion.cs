using ejercicio1GlobalC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Servicios
{
    /// <summary>
    /// implementacion que implementa a DarAltaInterfaz
    /// </summary>
    internal class DarAltaImplementacion : DarAltaInterfaz
    {
        GenerarIdInterfaz gi = new GenerarIdImplemntacion();
        public void bibliotecaAlta(List<BibliotecaDto> listabibliteca)
        {
            try
            {
                string ruta = "C:\\Users\\profesor\\Desktop\\repasoGlobal\\biblioteca.txt";
                long id = gi.generarIdBiblioteca(listabibliteca);
                Console.WriteLine("escribe el nombre de la biblioteca");
                string nombre = Console.ReadLine();
                Console.WriteLine("escrie al direccion");
                string direccion = Console.ReadLine();
                BibliotecaDto nuevaBinlioteca = new BibliotecaDto(id, nombre, direccion);
                listabibliteca.Add(nuevaBinlioteca);
                try
                {

                    StreamWriter sw = new StreamWriter(ruta);
                    foreach (BibliotecaDto b in listabibliteca)
                    {
                        sw.WriteLine(b.Id.ToString() + "," + b.Nombre.ToString() + "," + b.Direccion.ToString());
                    }

                    sw.Close();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void clienteAlta(List<ClienteDto> listaCliente, List<BibliotecaDto> listabibliteca)
        {
            try
            {
                long id = gi.generarIdCliente(listaCliente);
                Console.WriteLine("escribe el nombre de la biblioteca");
                string nombreBiblioteca = Console.ReadLine();
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
                string correoElectronico = Console.ReadLine();
                ClienteDto cliente = new ClienteDto(id, nombreBiblioteca, nombre, apellido, fchNacimiento, dni, correoElectronico);

                listaCliente.Add(cliente);


                try
                {
                    string ruta = "C:\\Users\\profesor\\Desktop\\repasoGlobal\\cliente.txt";
                    StreamWriter sw = new StreamWriter(ruta);
                    sw.WriteLine(cliente.ToString());
                    sw.Close();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void libroAlta(List<LibroDto> listaLibro, List<BibliotecaDto> listabibliteca)
        {
            try
            {
                long id = gi.generarIdLibro(listaLibro);
                Console.WriteLine("en que biblioteca te vas ha registrar");
                string biblioteca = Console.ReadLine();
                Console.WriteLine("escribe el titulo");
                string titulo = Console.ReadLine();
                Console.WriteLine("escribe el subtitulo");
                string subtitulo = Console.ReadLine();
                Console.WriteLine("escribe el nombre del autor");
                string autor = Console.ReadLine();
                Console.WriteLine("escribe el ISBN");
                string ISBN = Console.ReadLine();
                Console.WriteLine("escribe el numero de la edicion");
                int numEdicion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("escribe la editorial");
                string editorial = Console.ReadLine();
                Console.WriteLine("escribe el numero de stock");
                int stock = Convert.ToInt32(Console.ReadLine());
                LibroDto libroDto = new LibroDto(id, biblioteca, titulo, subtitulo, autor, ISBN, numEdicion, editorial, stock);

                listaLibro.Add(libroDto);


                try
                {
                    string ruta = "C:\\Users\\profesor\\Desktop\\repasoGlobal\\libro.txt";
                    StreamWriter sw = new StreamWriter(ruta);
                    sw.WriteLine(libroDto.ToString());
                    sw.Close();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

           public void prestamoAlta(List<PrestamoDto> listaPrestamo, List<BibliotecaDto> listabibliteca)
           {
                try
                {
                    long id = gi.generarIdPrestamo(listaPrestamo);
                    Console.WriteLine("en que biblioteca te vas ha registrar");
                    string biblioteca = Console.ReadLine();
                    Console.WriteLine("escribe el identificador del cliente");
                    long idCliente = Convert.ToInt64(id);
                    //if(idCliente==Biblioteca.ClienteDtos.id)
                    Console.WriteLine("escribe el identificador del libro");
                    long idLibro = Convert.ToInt64(id);
                    Console.WriteLine("escribe la fecha de prestamo");
                    DateTime fchPrestamo = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("escribe el estado del prestamo");
                    string estado = Console.ReadLine();
                    PrestamoDto prestamo = new PrestamoDto(id, biblioteca, idCliente, idLibro, fchPrestamo, estado);
                    listaPrestamo.Add(prestamo);

                    try
                    {
                        string ruta = "C:\\Users\\profesor\\Desktop\\repasoGlobal\\prestamo.txt";
                        StreamWriter sw = new StreamWriter(ruta);
                        sw.WriteLine(prestamo.ToString());
                        sw.Close();
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                catch (Exception e)
                {
                    throw;
                } 
            }     
    }
} 
