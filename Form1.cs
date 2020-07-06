using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUNTADA_CASA_JULIUS
{
  public partial class Form1 : Form
  {

    double acuSueldos;
    int cantBedelesTurnoManana;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Bedel bedel1 = new Bedel(
        txtNombre.Text, 
        int.Parse(txtDNI.Text), 
        long.Parse(txtTelefono.Text), txtDomicilio.Text, 
        dtpFechaNac.Value, 
        cboSexo.SelectedIndex + 1, 
        int.Parse(txtLegajo.Text), 
        dtpFechaIngreso.Value, 
        double.Parse(txtSueldo.Text), 
        cboTurno.SelectedIndex + 1);

      bedel1.Curso.CantidadAlumnos = int.Parse(txtCantidadAlumnos.Text);
      bedel1.Curso.Division = int.Parse(txtDivision.Text);

      MessageBox.Show(bedel1.MostrarDatos());

      acuSueldos += bedel1.Sueldo;

      if (bedel1.Turno == 1) cantBedelesTurnoManana++;

      txtSumaSueldo.Text = acuSueldos.ToString();
      txtCantBedelesTurnoManana.Text = cantBedelesTurnoManana.ToString();



    }

    private void button2_Click(object sender, EventArgs e)
    {
      DialogResult closeDialog = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
      if (closeDialog == DialogResult.Yes) Close();


    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult closeDialog = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
      if (closeDialog == DialogResult.No) e.Cancel = true;
    }

  }
}
