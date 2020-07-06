using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUNTADA_CASA_JULIUS
{
  class Persona
  {
    //propiedades
    public string Nombre { get; set; }
    public int DNI { get; set; }
    public long Telefono { get; set; }
    public int Sexo { get; set; }

    public string Domicilio { get; set; }
    public DateTime FechaNac { get; set; }

    //constructor
    

    public Persona(string nombre, int dni, long telefono, string domicilio, DateTime fechaNac, int sexo)
    {
      Nombre = nombre;
      DNI = dni;
      Telefono = telefono;
      Domicilio = domicilio;
      FechaNac = fechaNac;
      Sexo = sexo;
    }

    public Persona()
    {
      Nombre = Domicilio = "";
      Telefono = DNI = Sexo = 0;
      FechaNac = DateTime.Today;
    }

    //metodos
    public string GetSexo()
    {
      switch (Sexo)
      {
        case 1: return "Masculino";
        case 2: return "Femenino";
        default: return "Otro";
      }
    }

    public int GetEdad()
    {
      int edad;

      edad = DateTime.Today.Year - FechaNac.Year;

      if (FechaNac.Month > DateTime.Today.Month) edad -= 1;
      if (FechaNac.Month == DateTime.Today.Month)
      {
        if (FechaNac.Day > DateTime.Today.Day) edad -= 1;
      }
      return edad;
    }
    public virtual string MostrarDatos()
    {
      return
        $"Nombre: {Nombre}\n" +
        $"DNI: {DNI}\n" +
        $"Telefono: {Telefono}\n" +
        $"Domicilio: {Domicilio}\n" +
        $"Sexo: {GetSexo()}\n" +
        $"Fecha Nacimiento: {FechaNac.ToShortDateString()}";
    }
  }
}
