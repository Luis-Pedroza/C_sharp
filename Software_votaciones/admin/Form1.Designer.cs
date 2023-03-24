namespace admin;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Icon = new Icon(@"fav.ico");
        this.Text = "Ventana principal";

        //
        // TabControl
        //
        this.TabControl = new System.Windows.Forms.TabControl();
        this.TabControl.ItemSize = new System.Drawing.Size(62, 20);
        this.TabControl.Text = "TabControl";
        this.TabControl.Name = "TabControl";
        this.TabControl.Size = new System.Drawing.Size(808, 456);
        this.TabControl.TabIndex = 0;
        this.Controls.Add(this.TabControl);

        //
        // inicio
        //
        this.inicio = new System.Windows.Forms.TabPage();
        this.inicio.Location = new System.Drawing.Point(4, 24);
        this.inicio.TabIndex = 1;
        this.inicio.Text = "Inicio";
        this.inicio.Name = "inicio";
        this.inicio.Size = new System.Drawing.Size(800, 428);
        this.TabControl.Controls.Add(this.inicio);

        //
        // buscarElector
        //
        this.buscarElector = new System.Windows.Forms.Label();
        this.buscarElector.AutoSize =  true;
        this.buscarElector.Location = new System.Drawing.Point(344,24);
        this.buscarElector.Name =  "buscarElector";
        this.buscarElector.Size = new System.Drawing.Size(47,15);
        this.inicio.Controls.Add(this.buscarElector);

        //
        // nombreElector
        //
        this.nombreElector = new System.Windows.Forms.Label();
        this.nombreElector.AutoSize = true;
        this.nombreElector.Text = "Nombre: ";
        this.nombreElector.Location = new System.Drawing.Point(248, 64);
        this.nombreElector.Name = "nombreElector";
        this.nombreElector.Size = new System.Drawing.Size(54, 15);
        this.inicio.Controls.Add(this.nombreElector);

        //
        // nombreElectorInput
        //
        this.nombreElectorInput = new System.Windows.Forms.TextBox();
        this.nombreElectorInput.Text =  "";
        this.nombreElectorInput.Location = new System.Drawing.Point(368,64);
        this.nombreElectorInput.Name =  "nombreElectorInput";
        this.nombreElectorInput.Size = new System.Drawing.Size(128,23);
        this.nombreElectorInput.TabIndex = 4;
        this.inicio.Controls.Add(this.nombreElectorInput);

        //
        // paternoElector
        //
        this.paternoElector = new System.Windows.Forms.Label();
        this.paternoElector.AutoSize = true;
        this.paternoElector.Text = "Apellido Paterno:";
        this.paternoElector.Location = new System.Drawing.Point(248, 88);
        this.paternoElector.Name = "paternoElector";
        this.paternoElector.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.paternoElector);
        //
        // paternoElectorInput
        //
        this.paternoElectorInput = new System.Windows.Forms.TextBox();
        this.paternoElectorInput.Text = "";
        this.paternoElectorInput.Location = new System.Drawing.Point(368, 88);
        this.paternoElectorInput.Name = "paternoElectorInput";
        this.paternoElectorInput.Size = new System.Drawing.Size(128, 23);
        this.paternoElectorInput.TabIndex = 5;
        this.inicio.Controls.Add(this.paternoElectorInput);

        //
        // maternoElector
        //
        this.maternoElector = new System.Windows.Forms.Label();
        this.maternoElector.AutoSize = true;
        this.maternoElector.Text = "Apellido Materno:";
        this.maternoElector.Location = new System.Drawing.Point(248, 112);
        this.maternoElector.Name = "maternoElector";
        this.maternoElector.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.maternoElector);

        //
        // maternoElectorInput
        //
        this.maternoElectorInput = new System.Windows.Forms.TextBox();
        this.maternoElectorInput.Text = "";
        this.maternoElectorInput.Location = new System.Drawing.Point(368, 112);
        this.maternoElectorInput.Name = "maternoElectorInput";
        this.maternoElectorInput.Size = new System.Drawing.Size(128, 23);
        this.maternoElectorInput.TabIndex = 6;
        this.inicio.Controls.Add(this.maternoElectorInput);

        //
        // claveRegistro
        //
        this.claveRegistro = new System.Windows.Forms.Label();
        this.claveRegistro.AutoSize = true;
        this.claveRegistro.Text = "Clave de Registro:";
        this.claveRegistro.Location = new System.Drawing.Point(248, 136);
        this.claveRegistro.Name = "claveRegistro";
        this.claveRegistro.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.claveRegistro);

        //
        // claveRegistroInput
        //
        this.claveRegistroInput = new System.Windows.Forms.TextBox();
        this.claveRegistroInput.Text = "";
        this.claveRegistroInput.Location = new System.Drawing.Point(368, 136);
        this.claveRegistroInput.Name = "claveRegistroInput";
        this.claveRegistroInput.Size = new System.Drawing.Size(128, 23);
        this.claveRegistroInput.TabIndex = 7;
        this.inicio.Controls.Add(this.claveRegistroInput);

        //
        // btnMostrarElector
        //Cambiar nombre del boton Guardar - Buscar
        this.btnMostrarElector = new System.Windows.Forms.Button();
        this.btnMostrarElector.Location = new System.Drawing.Point(324, 186);
        this.btnMostrarElector.Name = "btnMostrarElector";
        this.btnMostrarElector.Size = new System.Drawing.Size(96, 32);
        this.btnMostrarElector.TabIndex = 8;
        this.btnMostrarElector.Cursor = Cursors.Hand;
        this.btnMostrarElector.Click += btnMostrarUsuario_Click;
        this.inicio.Controls.Add(this.btnMostrarElector);

        //
        // terminar
        //
        this.terminar = new System.Windows.Forms.TabPage();
        this.terminar.Location = new System.Drawing.Point(4, 24);
        this.terminar.TabIndex = 2;
        this.terminar.Text = "Terminar";
        this.terminar.Name = "terminar";
        this.terminar.Size = new System.Drawing.Size(800, 428);
        this.TabControl.Controls.Add(this.terminar);

        //
        // terminarProceso
        //
        this.terminarProceso = new System.Windows.Forms.Label();
        this.terminarProceso.AutoSize = true;
        this.terminarProceso.Text = "Terminar Proceso";
        this.terminarProceso.Location = new System.Drawing.Point(336, 24);
        this.terminarProceso.Name = "terminarProceso";
        this.terminarProceso.Size = new System.Drawing.Size(47, 15);
        this.terminar.Controls.Add(this.terminarProceso);

        //
        // puesto
        //
        this.puesto = new System.Windows.Forms.Label();
        this.puesto.AutoSize = true;
        this.puesto.Text = "Puesto";
        this.puesto.Location = new System.Drawing.Point(248, 72);
        this.puesto.Name = "puesto";
        this.puesto.Size = new System.Drawing.Size(47, 15);
        this.terminar.Controls.Add(this.puesto);

        //
        // contraseña
        //
        this.contraseña = new System.Windows.Forms.Label();
        this.contraseña.AutoSize = true;
        this.contraseña.Text = "Contraseña";
        this.contraseña.Location = new System.Drawing.Point(400, 72);
        this.contraseña.Name = "contraseña";
        this.contraseña.Size = new System.Drawing.Size(47, 15);
        this.terminar.Controls.Add(this.contraseña);

        //
        // administrador
        //
        this.administrador = new System.Windows.Forms.Label();
        this.administrador.AutoSize = true;
        this.administrador.Text = "Administrador";
        this.administrador.Location = new System.Drawing.Point(248, 120);
        this.administrador.Name = "administrador";
        this.administrador.Size = new System.Drawing.Size(47, 15);
        this.terminar.Controls.Add(this.administrador);

        //
        // presidente
        //
        this.presidente = new System.Windows.Forms.Label();
        this.presidente.AutoSize = true;
        this.presidente.Text = "Presidente";
        this.presidente.Location = new System.Drawing.Point(248, 144);
        this.presidente.Name = "presidente";
        this.presidente.Size = new System.Drawing.Size(47, 15);
        this.terminar.Controls.Add(this.presidente);

        //
        // secretario
        //
        this.secretario = new System.Windows.Forms.Label();
        this.secretario.AutoSize = true;
        this.secretario.Text = "Secretario";
        this.secretario.Location = new System.Drawing.Point(248, 168);
        this.secretario.Name = "secretario";
        this.secretario.Size = new System.Drawing.Size(47, 15);
        this.terminar.Controls.Add(this.secretario);

        //
        // escrutador
        //
        this.escrutador = new System.Windows.Forms.Label();
        this.escrutador.AutoSize = true;
        this.escrutador.Text = "Escrutador";
        this.escrutador.Location = new System.Drawing.Point(248, 192);
        this.escrutador.Name = "escrutador";
        this.escrutador.Size = new System.Drawing.Size(47, 15);
        this.terminar.Controls.Add(this.escrutador);

        //
        // administradorInput
        //
        this.administradorInput = new System.Windows.Forms.TextBox();
        this.administradorInput.Text = "";
        this.administradorInput.Location = new System.Drawing.Point(368, 112);
        this.administradorInput.Name = "administradorInput";
        this.administradorInput.Size = new System.Drawing.Size(128, 23);
        this.administradorInput.TabIndex = 9;
        this.terminar.Controls.Add(this.administradorInput);

        //
        // presidenteInput
        //
        this.presidenteInput = new System.Windows.Forms.TextBox();
        this.presidenteInput.Text = "";
        this.presidenteInput.Location = new System.Drawing.Point(368, 136);
        this.presidenteInput.Name = "presidenteInput";
        this.presidenteInput.Size = new System.Drawing.Size(128, 23);
        this.presidenteInput.TabIndex = 10;
        this.terminar.Controls.Add(this.presidenteInput);

        //
        // secretarioInput
        //
        this.secretarioInput = new System.Windows.Forms.TextBox();
        this.secretarioInput.Text = "";
        this.secretarioInput.Location = new System.Drawing.Point(368, 160);
        this.secretarioInput.Name = "secretarioInput";
        this.secretarioInput.Size = new System.Drawing.Size(128, 23);
        this.secretarioInput.TabIndex = 11;
        this.terminar.Controls.Add(this.secretarioInput);

        //
        // escrutadorInput
        //
        this.escrutadorInput = new System.Windows.Forms.TextBox();
        this.escrutadorInput.Text = "";
        this.escrutadorInput.Location = new System.Drawing.Point(368, 184);
        this.escrutadorInput.Name = "escrutadorInput";
        this.escrutadorInput.Size = new System.Drawing.Size(128, 23);
        this.escrutadorInput.TabIndex = 12;
        this.terminar.Controls.Add(this.escrutadorInput);

        //
        // btnTerminar
        //
        this.btnTerminar = new System.Windows.Forms.Button();
        this.btnTerminar.Text = "Terminar";
        this.btnTerminar.Location = new System.Drawing.Point(324, 296);
        this.btnTerminar.Name = "btnTerminar";
        this.btnTerminar.Size = new System.Drawing.Size(96, 32);
        this.btnTerminar.TabIndex = 13;
        this.btnTerminar.Cursor = Cursors.Hand;
        this.btnTerminar.Click += btnTerminar_Click;
        this.terminar.Controls.Add(this.btnTerminar);

        //
        // ayuda
        //
        this.ayuda = new System.Windows.Forms.TabPage();
        this.ayuda.Location = new System.Drawing.Point(4, 24);
        this.ayuda.TabIndex = 3;
        this.ayuda.Text = "Ayuda";
        this.ayuda.Name = "ayuda";
        this.ayuda.Size = new System.Drawing.Size(800, 428);
        this.TabControl.Controls.Add(this.ayuda);

    }

    #endregion
    private TabControl TabControl;
    private TabPage inicio;
    private Label buscarElector;
    private TabPage terminar;
    private TabPage ayuda;
    private Label nombreElector;
    private TextBox nombreElectorInput;
    private Label paternoElector;
    private TextBox paternoElectorInput;
    private Button btnMostrarElector;
    private Label terminarProceso;
    private Label puesto;
    private Label contraseña;
    private Label administrador;
    private Label presidente;
    private Label secretario;
    private Label escrutador;
    private TextBox administradorInput;
    private TextBox presidenteInput;
    private TextBox secretarioInput;
    private TextBox escrutadorInput;
    private Button btnTerminar;
    private Label maternoElector;
    private Label claveRegistro;
    private TextBox maternoElectorInput;
    private TextBox claveRegistroInput;
}