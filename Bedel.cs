using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUNTADA_CASA_JULIUS
{
  class Bedel : Empleado
  {
    //propiedades
    public int Turno { get; set; }
    public Curso Curso { get; set; }

    //constructores
    public Bedel() :base()
    {
      Turno = 0;
      Curso = new Curso();
    }

    public Bedel(string nombre, int dni, long telefono, string domicilio, DateTime fechaNac, int sexo, int legajo, DateTime fechaIngresoEmpresa, double sueldo, int turno, Curso curso) :base(nombre, dni, telefono, domicilio, fechaNac, sexo, legajo, fechaIngresoEmpresa, sueldo)
    {
      Turno = turno;
      Curso = curso;
    }

    public Bedel(string nombre, int dni, long telefono, string domicilio, DateTime fechaNac, int sexo, int legajo, DateTime fechaIngresoEmpresa, double sueldo, int turno) : base(nombre, dni, telefono, domicilio, fechaNac, sexo, legajo, fechaIngresoEmpresa, sueldo)
    {
      Turno = turno;
      Curso = new Curso();
    }

    //metodos
    public string GetTurno()
    {
      switch (Turno)
      {
        case 1: return "Mañana";
        case 2: return "Tarde";
        default: return "Noche";
      }
    }

    public override string MostrarDatos()
    {
      return
        $"{base.MostrarDatos()}\n" +
        $"Turno: {GetTurno()}\n" +
        $"Curso: {Curso.MostrarDatos()}";
    }
  }
}
