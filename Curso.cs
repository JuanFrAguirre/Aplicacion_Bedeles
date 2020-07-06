using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUNTADA_CASA_JULIUS
{
  class Curso
  {
    public int CantidadAlumnos { get; set; }
    public int Division { get; set; }

    public Curso()
    {
      CantidadAlumnos = Division = 0;
    }

    public Curso(int cantidadAlumnos, int division)
    {
      CantidadAlumnos = cantidadAlumnos;
      Division = division;
    }

    public string MostrarDatos()
    {
      return
        $"Cantidad de alumnos: {CantidadAlumnos}\n" +
        $"Division: {Division}";
    }
  }
}
