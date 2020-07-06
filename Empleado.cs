using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUNTADA_CASA_JULIUS
{
  class Empleado : Persona
  {
    //propiedades
    public int Legajo { get; set; }
    public DateTime FechaIngresoEmpresa { get; set; }
    public double Sueldo { get; set; }

    //constructores
    public Empleado() :base ()
    {
      Sueldo = Legajo = 0;
      FechaIngresoEmpresa = DateTime.Today;
    }

    public Empleado(string nombre, int dni, long telefono, string domicilio, DateTime fechaNac, int sexo, int legajo, DateTime fechaIngresoEmpresa, double sueldo) : base(nombre, dni, telefono, domicilio, fechaNac, sexo)
    {
      Legajo = legajo;
      FechaIngresoEmpresa = fechaIngresoEmpresa;
      Sueldo = sueldo;
    }

    //metodos
    public int GetAntiguedad()
    {
      return DateTime.Today.Year - FechaIngresoEmpresa.Year;
    }

    public override string MostrarDatos()
    {
      return
        $"{base.MostrarDatos()}\n" +
        $"Legajo: {Legajo}\n" +
        $"Antigüedad: {GetAntiguedad()}\n" +
        $"Sueldo: {Sueldo}";
    }
  }
}
