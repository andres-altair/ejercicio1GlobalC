using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Dtos
{
    internal class PrestamoDto
    {
        long id;
        string nombreBiblioteca = "aaaa";
        long identificadorCliente = 9999999;
        long identificadorLibro = 99999999;
        DateTime fchPrestamo = new DateTime();
        DateTime fchEntrega = new DateTime();
        string estadoPrestamo = "en proceso";

        public PrestamoDto() { }

        public PrestamoDto(long id, string nombreBiblioteca, long identificadorCliente, long identificadorLibro, DateTime fchPrestamo, string estadoPrestamo)
        {
            this.id = id;
            this.nombreBiblioteca = nombreBiblioteca;
            this.identificadorCliente = identificadorCliente;
            this.identificadorLibro = identificadorLibro;
            this.fchPrestamo = fchPrestamo;
            this.fchEntrega = fchPrestamo.AddDays(8);
            this.estadoPrestamo = estadoPrestamo;
        }

        public long Id { get => id; set => id = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public long IdentificadorCliente { get => identificadorCliente; set => identificadorCliente = value; }
        public long IdentificadorLibro { get => identificadorLibro; set => identificadorLibro = value; }
        public DateTime FchPrestamo { get => fchPrestamo; set => fchPrestamo = value; }
        public DateTime FchEntrega { get => fchEntrega; set => fchEntrega = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
    }
}
