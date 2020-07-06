namespace JUNTADA_CASA_JULIUS
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
      this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
      this.cboSexo = new System.Windows.Forms.ComboBox();
      this.cboTurno = new System.Windows.Forms.ComboBox();
      this.txtSueldo = new System.Windows.Forms.TextBox();
      this.txtDomicilio = new System.Windows.Forms.TextBox();
      this.txtLegajo = new System.Windows.Forms.TextBox();
      this.txtTelefono = new System.Windows.Forms.TextBox();
      this.txtDNI = new System.Windows.Forms.TextBox();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label12 = new System.Windows.Forms.Label();
      this.Divison = new System.Windows.Forms.Label();
      this.txtDivision = new System.Windows.Forms.TextBox();
      this.txtCantidadAlumnos = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.txtCantBedelesTurnoManana = new System.Windows.Forms.TextBox();
      this.txtSumaSueldo = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dtpFechaIngreso);
      this.groupBox1.Controls.Add(this.dtpFechaNac);
      this.groupBox1.Controls.Add(this.cboSexo);
      this.groupBox1.Controls.Add(this.cboTurno);
      this.groupBox1.Controls.Add(this.txtSueldo);
      this.groupBox1.Controls.Add(this.txtDomicilio);
      this.groupBox1.Controls.Add(this.txtLegajo);
      this.groupBox1.Controls.Add(this.txtTelefono);
      this.groupBox1.Controls.Add(this.txtDNI);
      this.groupBox1.Controls.Add(this.txtNombre);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(13, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(612, 575);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Bedeles";
      // 
      // dtpFechaIngreso
      // 
      this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaIngreso.Location = new System.Drawing.Point(251, 388);
      this.dtpFechaIngreso.Name = "dtpFechaIngreso";
      this.dtpFechaIngreso.Size = new System.Drawing.Size(313, 31);
      this.dtpFechaIngreso.TabIndex = 7;
      // 
      // dtpFechaNac
      // 
      this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFechaNac.Location = new System.Drawing.Point(251, 297);
      this.dtpFechaNac.Name = "dtpFechaNac";
      this.dtpFechaNac.Size = new System.Drawing.Size(313, 31);
      this.dtpFechaNac.TabIndex = 5;
      // 
      // cboSexo
      // 
      this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboSexo.FormattingEnabled = true;
      this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
      this.cboSexo.Location = new System.Drawing.Point(251, 196);
      this.cboSexo.Name = "cboSexo";
      this.cboSexo.Size = new System.Drawing.Size(313, 33);
      this.cboSexo.TabIndex = 3;
      // 
      // cboTurno
      // 
      this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboTurno.FormattingEnabled = true;
      this.cboTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
      this.cboTurno.Location = new System.Drawing.Point(251, 484);
      this.cboTurno.Name = "cboTurno";
      this.cboTurno.Size = new System.Drawing.Size(313, 33);
      this.cboTurno.TabIndex = 9;
      // 
      // txtSueldo
      // 
      this.txtSueldo.Location = new System.Drawing.Point(251, 436);
      this.txtSueldo.Name = "txtSueldo";
      this.txtSueldo.Size = new System.Drawing.Size(313, 31);
      this.txtSueldo.TabIndex = 8;
      // 
      // txtDomicilio
      // 
      this.txtDomicilio.Location = new System.Drawing.Point(251, 247);
      this.txtDomicilio.Name = "txtDomicilio";
      this.txtDomicilio.Size = new System.Drawing.Size(313, 31);
      this.txtDomicilio.TabIndex = 4;
      // 
      // txtLegajo
      // 
      this.txtLegajo.Location = new System.Drawing.Point(251, 347);
      this.txtLegajo.Name = "txtLegajo";
      this.txtLegajo.Size = new System.Drawing.Size(313, 31);
      this.txtLegajo.TabIndex = 6;
      // 
      // txtTelefono
      // 
      this.txtTelefono.Location = new System.Drawing.Point(251, 147);
      this.txtTelefono.Name = "txtTelefono";
      this.txtTelefono.Size = new System.Drawing.Size(313, 31);
      this.txtTelefono.TabIndex = 2;
      // 
      // txtDNI
      // 
      this.txtDNI.Location = new System.Drawing.Point(251, 97);
      this.txtDNI.Name = "txtDNI";
      this.txtDNI.Size = new System.Drawing.Size(313, 31);
      this.txtDNI.TabIndex = 1;
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(251, 50);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(313, 31);
      this.txtNombre.TabIndex = 0;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(49, 500);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(68, 25);
      this.label10.TabIndex = 0;
      this.label10.Text = "Turno";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(49, 450);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(79, 25);
      this.label9.TabIndex = 0;
      this.label9.Text = "Sueldo";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(49, 400);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(155, 25);
      this.label8.TabIndex = 0;
      this.label8.Text = "Fecha Ingreso ";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(49, 350);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(77, 25);
      this.label7.TabIndex = 0;
      this.label7.Text = "Legajo";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(50, 300);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(185, 25);
      this.label6.TabIndex = 0;
      this.label6.Text = "Fecha Nacimiento";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(50, 250);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(99, 25);
      this.label5.TabIndex = 0;
      this.label5.Text = "Domicilio";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(50, 200);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(61, 25);
      this.label4.TabIndex = 0;
      this.label4.Text = "Sexo";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(49, 150);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(96, 25);
      this.label3.TabIndex = 0;
      this.label3.Text = "Telefono";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(49, 100);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 25);
      this.label2.TabIndex = 0;
      this.label2.Text = "DNI";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(50, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.Divison);
      this.groupBox2.Controls.Add(this.txtDivision);
      this.groupBox2.Controls.Add(this.txtCantidadAlumnos);
      this.groupBox2.Location = new System.Drawing.Point(658, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(464, 194);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Curso a cargo";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(37, 109);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(187, 25);
      this.label12.TabIndex = 0;
      this.label12.Text = "Cantidad Alumnos";
      // 
      // Divison
      // 
      this.Divison.AutoSize = true;
      this.Divison.Location = new System.Drawing.Point(38, 60);
      this.Divison.Name = "Divison";
      this.Divison.Size = new System.Drawing.Size(88, 25);
      this.Divison.TabIndex = 0;
      this.Divison.Text = "Division";
      // 
      // txtDivision
      // 
      this.txtDivision.Location = new System.Drawing.Point(245, 57);
      this.txtDivision.Name = "txtDivision";
      this.txtDivision.Size = new System.Drawing.Size(183, 31);
      this.txtDivision.TabIndex = 0;
      // 
      // txtCantidadAlumnos
      // 
      this.txtCantidadAlumnos.Location = new System.Drawing.Point(245, 106);
      this.txtCantidadAlumnos.Name = "txtCantidadAlumnos";
      this.txtCantidadAlumnos.Size = new System.Drawing.Size(183, 31);
      this.txtCantidadAlumnos.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(701, 272);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(335, 93);
      this.button1.TabIndex = 2;
      this.button1.Text = "Registrar Bedel";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(701, 429);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(335, 93);
      this.button2.TabIndex = 3;
      this.button2.Text = "Salir";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label11);
      this.groupBox3.Controls.Add(this.label13);
      this.groupBox3.Controls.Add(this.txtCantBedelesTurnoManana);
      this.groupBox3.Controls.Add(this.txtSumaSueldo);
      this.groupBox3.Location = new System.Drawing.Point(1160, 13);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(421, 194);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Curso a cargo";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(15, 118);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(151, 25);
      this.label11.TabIndex = 0;
      this.label11.Text = "Suma Sueldos";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(15, 49);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(152, 50);
      this.label13.TabIndex = 0;
      this.label13.Text = "Cant Bedeles\r\nTurno Mañana";
      // 
      // txtCantBedelesTurnoManana
      // 
      this.txtCantBedelesTurnoManana.Enabled = false;
      this.txtCantBedelesTurnoManana.Location = new System.Drawing.Point(223, 59);
      this.txtCantBedelesTurnoManana.Name = "txtCantBedelesTurnoManana";
      this.txtCantBedelesTurnoManana.Size = new System.Drawing.Size(183, 31);
      this.txtCantBedelesTurnoManana.TabIndex = 0;
      this.txtCantBedelesTurnoManana.Text = "-";
      this.txtCantBedelesTurnoManana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtSumaSueldo
      // 
      this.txtSumaSueldo.Enabled = false;
      this.txtSumaSueldo.Location = new System.Drawing.Point(223, 115);
      this.txtSumaSueldo.Name = "txtSumaSueldo";
      this.txtSumaSueldo.Size = new System.Drawing.Size(183, 31);
      this.txtSumaSueldo.TabIndex = 1;
      this.txtSumaSueldo.Text = "-";
      this.txtSumaSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1624, 713);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox cboTurno;
    private System.Windows.Forms.TextBox txtSueldo;
    private System.Windows.Forms.TextBox txtLegajo;
    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.TextBox txtDNI;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label Divison;
    private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
    private System.Windows.Forms.DateTimePicker dtpFechaNac;
    private System.Windows.Forms.ComboBox cboSexo;
    private System.Windows.Forms.TextBox txtCantidadAlumnos;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox txtDomicilio;
    private System.Windows.Forms.TextBox txtDivision;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox txtCantBedelesTurnoManana;
    private System.Windows.Forms.TextBox txtSumaSueldo;
  }
}

