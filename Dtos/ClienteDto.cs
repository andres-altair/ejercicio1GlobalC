﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1GlobalC.Dtos
{
    internal class ClienteDto
    {
        long id;
        string nombreBiblioteca = "aaaa";
        string nombre = "aaaaa";
        string apellidos = "aaaaaa";
        DateTime nacimiento = new DateTime(9999, 12, 31);
        string dni = "aaaaaa";
        string correoElectronico = "aaaaaa";
        DateTime inicioSuspension = new DateTime(9999,12,31);
        DateTime finSuspension = new DateTime(9999,12,31);

        public ClienteDto() { }

        public ClienteDto(long id, string nombreBiblioteca, string nombre, string apellidos, DateTime nacimiento, string dni, string correoElectronico)
        {
            this.id = id;
            this.nombreBiblioteca = nombreBiblioteca;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nacimiento = nacimiento;
            this.dni = dni;
            this.correoElectronico = correoElectronico;
            this.inicioSuspension = inicioSuspension;
            this.finSuspension = inicioSuspension.AddDays(8);
        }

        public long Id { get => id; set => id = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public string Dni { get => dni; set => dni = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public DateTime InicioSuspension { get => inicioSuspension; set => inicioSuspension = value; }
        public DateTime FinSuspension { get => finSuspension; set => finSuspension = value; }
    }
}
