//Interfaz para configurar la base de datos que se usara en votaciones
//Por Luis Fernando Pedroza Moranchel

namespace configuracion;

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
        this.Text = "Configuracion";

         //
        // TabControl
        //
        this.TabControl = new System.Windows.Forms.TabControl();
        this.TabControl.ItemSize = new System.Drawing.Size(62, 20);
        this.TabControl.Text = "TabControl2";
        this.TabControl.Name = "TabControl";
        this.TabControl.Size = new System.Drawing.Size(800, 448);
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
        this.inicio.Size = new System.Drawing.Size(792, 420);
        this.TabControl.Controls.Add(this.inicio);

        //
        // contenedorInfoElecciones
        //
        this.contenedorInfoElecciones = new System.Windows.Forms.DataGridView();
        this.contenedorInfoElecciones.Location = new System.Drawing.Point(16, 16);
        this.contenedorInfoElecciones.Name = "contenedorInfoElecciones";
        this.contenedorInfoElecciones.Size = new System.Drawing.Size(470, 195);
        this.contenedorInfoElecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.contenedorInfoElecciones.MouseClick += CeldaEleccion_Click;
        this.inicio.Controls.Add(this.contenedorInfoElecciones);

        //
        // contenedorInfoCandidatos
        //
        this.contenedorInfoCandidatos = new System.Windows.Forms.DataGridView();
        this.contenedorInfoCandidatos.Location = new System.Drawing.Point(16, 215);
        this.contenedorInfoCandidatos.Name = "contenedorInfoCandidatos";
        this.contenedorInfoCandidatos.Size = new System.Drawing.Size(470, 195);
        this.contenedorInfoCandidatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.contenedorInfoCandidatos.MouseClick += CeldaCandidato_Click;
        this.inicio.Controls.Add(this.contenedorInfoCandidatos);

        //
        // nombreEventoAsignado
        //
        this.nombreEventoAsignado = new System.Windows.Forms.Label();
        this.nombreEventoAsignado.AutoSize = true;
        this.nombreEventoAsignado.Text = "Nombre del Evento:";
        this.nombreEventoAsignado.Location = new System.Drawing.Point(500, 48);
        this.nombreEventoAsignado.Name = "nombreEventoAsignado";
        this.nombreEventoAsignado.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.nombreEventoAsignado);

        //
        // fechaEventoAsignada
        //
        this.fechaEventoAsignada = new System.Windows.Forms.Label();
        this.fechaEventoAsignada.AutoSize = true;
        this.fechaEventoAsignada.Text = "Fecha del evento: ";
        this.fechaEventoAsignada.Location = new System.Drawing.Point(500, 72);
        this.fechaEventoAsignada.Name = "fechaEventoAsignada";
        this.fechaEventoAsignada.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.fechaEventoAsignada);

        //
        // fechaConfigAsignada
        //
        this.fechaConfigAsignada = new System.Windows.Forms.Label();
        this.fechaConfigAsignada.AutoSize = true;
        this.fechaConfigAsignada.Text = "Fecha de configuración: ";
        this.fechaConfigAsignada.Location = new System.Drawing.Point(500, 96);
        this.fechaConfigAsignada.Name = "fechaConfigAsignada";
        this.fechaConfigAsignada.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.fechaConfigAsignada);

        //
        // cantidadEleccionesAsignada
        //
        this.cantidadEleccionesAsignada = new System.Windows.Forms.Label();
        this.cantidadEleccionesAsignada.AutoSize = true;
        this.cantidadEleccionesAsignada.Text = "Cantidad de elecciones: ";
        this.cantidadEleccionesAsignada.Location = new System.Drawing.Point(500, 120);
        this.cantidadEleccionesAsignada.Name = "cantidadEleccionesAsignada";
        this.cantidadEleccionesAsignada.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.cantidadEleccionesAsignada);

        //
        // cantidadEquiposAsignada
        //
        this.cantidadEquiposAsignada = new System.Windows.Forms.Label();
        this.cantidadEquiposAsignada.AutoSize = true;
        this.cantidadEquiposAsignada.Text = "Cantidad de equipos: ";
        this.cantidadEquiposAsignada.Location = new System.Drawing.Point(500, 144);
        this.cantidadEquiposAsignada.Name = "cantidadEquiposAsignada";
        this.cantidadEquiposAsignada.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.cantidadEquiposAsignada);

        //
        // contrasenasAsignadas
        //
        this.contrasenasAsignadas = new System.Windows.Forms.Label();
        this.contrasenasAsignadas.AutoSize = true;
        this.contrasenasAsignadas.Text = "Contraseñas asignadas: ";
        this.contrasenasAsignadas.Location = new System.Drawing.Point(500, 168);
        this.contrasenasAsignadas.Name = "contrasenasAsignadas";
        this.contrasenasAsignadas.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.contrasenasAsignadas);

        //
        // modificacionBD
        //
        this.modificacionBD = new System.Windows.Forms.Label();
        this.modificacionBD.AutoSize = true;
        this.modificacionBD.Text = "Permitir ingresar Electores:";
        this.modificacionBD.Location = new System.Drawing.Point(500, 232);
        this.modificacionBD.Name = "modificacionBD";
        this.modificacionBD.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.modificacionBD);

        //
        // participantesEsperados
        //
        this.participantesEsperados = new System.Windows.Forms.Label();
        this.participantesEsperados.AutoSize = true;
        this.participantesEsperados.Text = "Participantes esperados: ";
        this.participantesEsperados.Location = new System.Drawing.Point(500, 256);
        this.participantesEsperados.Name = "participantesEsperados";
        this.participantesEsperados.Size = new System.Drawing.Size(47, 15);
        this.inicio.Controls.Add(this.participantesEsperados);

        //
        // btnTerminar
        //
        this.btnTerminar = new System.Windows.Forms.Button();
        this.btnTerminar.Text = "Terminar";
        this.btnTerminar.Cursor = Cursors.Hand;
        this.btnTerminar.Location = new System.Drawing.Point(500, 336);
        this.btnTerminar.Name = "terminar";
        this.btnTerminar.Size = new System.Drawing.Size(96, 32);
        this.btnTerminar.TabIndex = 5;
        this.btnTerminar.Click += btnTerminar_Click;
        this.inicio.Controls.Add(this.btnTerminar);


        //
        // evento
        //
        this.evento = new System.Windows.Forms.TabPage();
        this.evento.Location = new System.Drawing.Point(4, 24);
        this.evento.TabIndex = 2;
        this.evento.Text = "Evento";
        this.evento.Name = "configuracion";
        this.evento.Size = new System.Drawing.Size(792, 420);
        this.TabControl.Controls.Add(this.evento);

        //
        // nombreEvento
        //
        this.nombreEvento = new System.Windows.Forms.Label();
        this.nombreEvento.AutoSize = true;
        this.nombreEvento.Text = "Nombre del evento";
        this.nombreEvento.Location = new System.Drawing.Point(32, 16);
        this.nombreEvento.Name = "nombreEveto";
        this.nombreEvento.Size = new System.Drawing.Size(47, 15);
        this.evento.Controls.Add(this.nombreEvento);

        //
        // nombreEventoInput
        //
        this.nombreEventoInput = new System.Windows.Forms.TextBox();
        this.nombreEventoInput.Text = "";
        this.nombreEventoInput.Location = new System.Drawing.Point(175, 16);
        this.nombreEventoInput.Name = "nombreEventoInput";
        this.nombreEventoInput.Size = new System.Drawing.Size(146, 23);
        this.nombreEventoInput.TabIndex = 6;
        this.evento.Controls.Add(this.nombreEventoInput);

        //
        // fechaEvento
        //
        this.fechaEvento = new System.Windows.Forms.Label();
        this.fechaEvento.AutoSize = true;
        this.fechaEvento.Text = "Fecha de Evento";
        this.fechaEvento.Location = new System.Drawing.Point(32, 40);
        this.fechaEvento.Name = "fechaEveneto";
        this.fechaEvento.Size = new System.Drawing.Size(41, 15);
        this.evento.Controls.Add(this.fechaEvento);

        //
        // fechaEventoInput
        //
        this.fechaEventoInput = new System.Windows.Forms.DateTimePicker();
        this.fechaEventoInput.Format = DateTimePickerFormat.Custom;
        this.fechaEventoInput.CustomFormat = "yyyy/MM/dd";
        this.fechaEventoInput.Text = "";
        this.fechaEventoInput.Location = new System.Drawing.Point(175, 40);
        this.fechaEventoInput.Name = "fechaEventoInput";
        this.fechaEventoInput.Size = new System.Drawing.Size(146, 23);
        this.fechaEventoInput.TabIndex = 7;
        this.evento.Controls.Add(this.fechaEventoInput);

        //
        // fechaConfig
        //
        this.fechaConfig = new System.Windows.Forms.Label();
        this.fechaConfig.AutoSize = true;
        this.fechaConfig.Text = "Fecha de Configuración";
        this.fechaConfig.Location = new System.Drawing.Point(32, 64);
        this.fechaConfig.Name = "fechaConfig";
        this.fechaConfig.Size = new System.Drawing.Size(41, 15);
        this.evento.Controls.Add(this.fechaConfig);

        //
        // fechaConfigInput
        //
        this.fechaConfigInput = new System.Windows.Forms.DateTimePicker();
        this.fechaConfigInput.Format = DateTimePickerFormat.Custom;
        this.fechaConfigInput.CustomFormat = "yyyy/MM/dd";
        this.fechaConfigInput.Text = "";
        this.fechaConfigInput.Location = new System.Drawing.Point(175, 64);
        this.fechaConfigInput.Name = "fechaConfigInput";
        this.fechaConfigInput.Size = new System.Drawing.Size(146, 23);
        this.fechaConfigInput.TabIndex = 8;
        this.evento.Controls.Add(this.fechaConfigInput);

        //
        // numEquipos
        //
        this.numEquipos = new System.Windows.Forms.Label();
        this.numEquipos.AutoSize = true;
        this.numEquipos.Text = "Cantidad de equipos";
        this.numEquipos.Location = new System.Drawing.Point(32, 88);
        this.numEquipos.Name = "numEquipos";
        this.numEquipos.Size = new System.Drawing.Size(41, 15);
        this.evento.Controls.Add(this.numEquipos);


        //
        // numEquiposInput
        //
        this.numEquiposInput = new System.Windows.Forms.NumericUpDown();
        this.numEquiposInput.Value = 1;
        this.numEquiposInput.Maximum = 10;
        this.numEquiposInput.Minimum = 1;
        this.numEquiposInput.Text = "1";
        this.numEquiposInput.Location = new System.Drawing.Point(175, 88);
        this.numEquiposInput.Name = "numEquiposInput";
        this.numEquiposInput.Size = new System.Drawing.Size(146, 23);
        this.numEquiposInput.TabIndex = 9;
        this.evento.Controls.Add(this.numEquiposInput);

        //
        // btnConfigGuardar
        //
        this.btnConfigGuardar = new System.Windows.Forms.Button();
        this.btnConfigGuardar.Text = "Guardar";
        this.btnConfigGuardar.Location = new System.Drawing.Point(32, 152);
        this.btnConfigGuardar.Cursor = Cursors.Hand;
        this.btnConfigGuardar.Name = "btnConfigGuardar";
        this.btnConfigGuardar.Size = new System.Drawing.Size(96, 32);
        this.btnConfigGuardar.TabIndex = 11;
        this.btnConfigGuardar.Click += btnConfigGuardar_Click;
        this.evento.Controls.Add(this.btnConfigGuardar);

        //
        // eleccionActual
        //
        this.eleccionActual = new System.Windows.Forms.Label();
        this.eleccionActual.AutoSize = true;
        this.eleccionActual.Text = "Agregar nueva elección";
        this.eleccionActual.Location = new System.Drawing.Point(32, 232);
        this.eleccionActual.Name = "eleccionActual";
        this.eleccionActual.Size = new System.Drawing.Size(41, 15);
        this.evento.Controls.Add(this.eleccionActual);

        //
        // nombreEleccion
        //
        this.nombreEleccion = new System.Windows.Forms.Label();
        this.nombreEleccion.AutoSize = true;
        this.nombreEleccion.Text = "Nombre de la Elección";
        this.nombreEleccion.Location = new System.Drawing.Point(32, 264);
        this.nombreEleccion.Name = "nombreEleccion";
        this.nombreEleccion.Size = new System.Drawing.Size(41, 15);
        this.evento.Controls.Add(this.nombreEleccion);

        //
        // nombreEleccionInput
        //
        this.nombreEleccionInput = new System.Windows.Forms.TextBox();
        this.nombreEleccionInput.Text = "";
        this.nombreEleccionInput.Location = new System.Drawing.Point(170, 264);
        this.nombreEleccionInput.Name = "nombreEleccionInput";
        this.nombreEleccionInput.Size = new System.Drawing.Size(146, 23);
        this.nombreEleccionInput.TabIndex = 12;
        this.evento.Controls.Add(this.nombreEleccionInput);

        //
        // btnGuardarEleccion
        //
        this.btnGuardarEleccion = new System.Windows.Forms.Button();
        this.btnGuardarEleccion.Text = "Agregar";
        this.btnGuardarEleccion.Location = new System.Drawing.Point(32, 344);
        this.btnGuardarEleccion.Cursor = Cursors.Hand;
        this.btnGuardarEleccion.Name = "btnGuardarEleccion";
        this.btnGuardarEleccion.Size = new System.Drawing.Size(96, 32);
        this.btnGuardarEleccion.TabIndex = 14;
        this.btnGuardarEleccion.Click += btnGuardarEleccion_Click;
        this.evento.Controls.Add(this.btnGuardarEleccion);

        //
        // agregarCandidatoLabel
        //
        this.agregarCandidatoLabel = new System.Windows.Forms.Label();
        this.agregarCandidatoLabel.AutoSize = true;
        this.agregarCandidatoLabel.Text = "Agregar nuevo candidato";
        this.agregarCandidatoLabel.Location = new System.Drawing.Point(414, 40);
        this.agregarCandidatoLabel.Name = "eleccionActualNombre";
        this.agregarCandidatoLabel.Size = new System.Drawing.Size(41, 15);
        this.evento.Controls.Add(this.agregarCandidatoLabel);

        //
        // nombreCandidato
        //
        this.nombreCandidato = new System.Windows.Forms.Label();
        this.nombreCandidato.AutoSize = true;
        this.nombreCandidato.Text = "Nombre del candidato(a)";
        this.nombreCandidato.Location = new System.Drawing.Point(414, 75);
        this.nombreCandidato.Name = "nombreCandidato";
        this.nombreCandidato.Size = new System.Drawing.Size(41, 15);
        this.evento.Controls.Add(this.nombreCandidato);

        //
        // nombreCandidatoInput
        //
        this.nombreCandidatoInput = new System.Windows.Forms.TextBox();
        this.nombreCandidatoInput.Text = "";
        this.nombreCandidatoInput.Location = new System.Drawing.Point(605, 70);
        this.nombreCandidatoInput.Name = "nombreCandidatoInput";
        this.nombreCandidatoInput.Size = new System.Drawing.Size(146, 23);
        this.nombreCandidatoInput.TabIndex = 15;
        this.evento.Controls.Add(this.nombreCandidatoInput);

        //
        // paternoCandidato
        //
        this.paternoCandidato = new System.Windows.Forms.Label();
        this.paternoCandidato.AutoSize = true;
        this.paternoCandidato.Text = "Apellido Paterno del candidato(a)";
        this.paternoCandidato.Location = new System.Drawing.Point(414, 98);
        this.paternoCandidato.Name = "paternoCandidato";
        this.paternoCandidato.Size = new System.Drawing.Size(47, 15);
        this.evento.Controls.Add(this.paternoCandidato);

        //
        // paternoCandidatoInput
        //
        this.paternoCandidatoInput = new System.Windows.Forms.TextBox();
        this.paternoCandidatoInput.Text = "";
        this.paternoCandidatoInput.Location = new System.Drawing.Point(605, 96);
        this.paternoCandidatoInput.Name = "paternoCandidatoInput";
        this.paternoCandidatoInput.Size = new System.Drawing.Size(146, 23);
        this.paternoCandidatoInput.TabIndex = 16;
        this.evento.Controls.Add(this.paternoCandidatoInput);

        //
        // maternoCandidato
        //
        this.maternoCandidato = new System.Windows.Forms.Label();
        this.maternoCandidato.AutoSize = true;
        this.maternoCandidato.Text = "Apellido Materno del candidato(a)";
        this.maternoCandidato.Location = new System.Drawing.Point(414, 120);
        this.maternoCandidato.Name = "maternoCandidato";
        this.maternoCandidato.Size = new System.Drawing.Size(47, 15);
        this.evento.Controls.Add(this.maternoCandidato);

        //
        // maternoCandidatoInput
        //
        this.maternoCandidatoInput = new System.Windows.Forms.TextBox();
        this.maternoCandidatoInput.Text = "";
        this.maternoCandidatoInput.Location = new System.Drawing.Point(605, 120);
        this.maternoCandidatoInput.Name = "maternoCandidatoInput";
        this.maternoCandidatoInput.Size = new System.Drawing.Size(146, 23);
        this.maternoCandidatoInput.TabIndex = 17;
        this.evento.Controls.Add(this.maternoCandidatoInput);

        //
        // claveCandidato
        //
        this.claveCandidato = new System.Windows.Forms.Label();
        this.claveCandidato.AutoSize = true;
        this.claveCandidato.Text = "Clave unica del candidato(a)";
        this.claveCandidato.Location = new System.Drawing.Point(414, 147);
        this.claveCandidato.Name = "maternoCandidato";
        this.claveCandidato.Size = new System.Drawing.Size(47, 15);
        this.evento.Controls.Add(this.claveCandidato);

        //
        // claveCandidatoInput
        //
        this.claveCandidatoInput = new System.Windows.Forms.TextBox();
        this.claveCandidatoInput.Text = "";
        this.claveCandidatoInput.Location = new System.Drawing.Point(605, 144);
        this.claveCandidatoInput.Name = "claveCandidatoInput";
        this.claveCandidatoInput.Size = new System.Drawing.Size(146, 23);
        this.claveCandidatoInput.TabIndex = 17;
        this.evento.Controls.Add(this.claveCandidatoInput);

        //
        // eleccionCandidato
        //
        this.eleccionCandidato = new System.Windows.Forms.Label();
        this.eleccionCandidato.AutoSize = true;
        this.eleccionCandidato.Text = "Elección a la que pertenece";
        this.eleccionCandidato.Location = new System.Drawing.Point(414, 170);
        this.eleccionCandidato.Name = "eleccionCandidato";
        this.eleccionCandidato.Size = new System.Drawing.Size(47, 15);
        this.evento.Controls.Add(this.eleccionCandidato);


        //
        // eleccionCandidatoInput
        //
        this.eleccionCandidatoInput = new System.Windows.Forms.ComboBox();
        this.eleccionCandidatoInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.eleccionCandidatoInput.DropDownWidth = 128;
        this.eleccionCandidatoInput.ItemHeight = 15;
        this.eleccionCandidatoInput.Text = "";
        this.eleccionCandidatoInput.Location = new System.Drawing.Point(605, 168);
        this.eleccionCandidatoInput.Name = "eleccionCandidatoInput";
        this.eleccionCandidatoInput.Size = new System.Drawing.Size(146, 23);
        this.eleccionCandidatoInput.TabIndex = 18;
        this.eleccionCandidatoInput.Click += MostrarListaElecciones_Click;
        this.evento.Controls.Add(this.eleccionCandidatoInput);

        //
        // btnGuardarCandidato
        //
        this.btnGuardarCandidato = new System.Windows.Forms.Button();
        this.btnGuardarCandidato.Text = "Agregar";
        this.btnGuardarCandidato.Location = new System.Drawing.Point(414, 208);
        this.btnGuardarCandidato.Cursor = Cursors.Hand;
        this.btnGuardarCandidato.Name = "btnGuardarCandidato";
        this.btnGuardarCandidato.Size = new System.Drawing.Size(96, 32);
        this.btnGuardarCandidato.TabIndex = 19;
        this.btnGuardarCandidato.Click += btnGuardarCandidato_Click;
        this.evento.Controls.Add(this.btnGuardarCandidato);

        //
        // participantes
        //
        this.participantes = new System.Windows.Forms.TabPage();
        this.participantes.Location = new System.Drawing.Point(4, 24);
        this.participantes.TabIndex = 3;
        this.participantes.Text = "Participantes";
        this.participantes.Name = "participantes";
        this.participantes.Size = new System.Drawing.Size(792, 420);
        this.TabControl.Controls.Add(this.participantes);

        //
        // infoEncargados
        //
        this.infoEncargados = new System.Windows.Forms.Label();
        this.infoEncargados.AutoSize = true;
        this.infoEncargados.Text = "Asignación de contraseñas";
        this.infoEncargados.Location = new System.Drawing.Point(48, 24);
        this.infoEncargados.Name = "infoEncargados";
        this.infoEncargados.Size = new System.Drawing.Size(47, 15);
        this.participantes.Controls.Add(this.infoEncargados);

        //
        // puesto
        //
        this.puesto = new System.Windows.Forms.Label();
        this.puesto.AutoSize = true;
        this.puesto.Text = "Puesto";
        this.puesto.Location = new System.Drawing.Point(48, 72);
        this.puesto.Name = "puesto";
        this.puesto.Size = new System.Drawing.Size(47, 15);
        this.participantes.Controls.Add(this.puesto);

        //
        // contrasena
        //
        this.contrasena = new System.Windows.Forms.Label();
        this.contrasena.AutoSize = true;
        this.contrasena.Text = "Contraseña";
        this.contrasena.Location = new System.Drawing.Point(200, 72);
        this.contrasena.Name = "contrasena";
        this.contrasena.Size = new System.Drawing.Size(47, 15);
        this.participantes.Controls.Add(this.contrasena);

        //
        // administrador
        //
        this.administrador = new System.Windows.Forms.Label();
        this.administrador.AutoSize = true;
        this.administrador.Text = "Administrador(a)";
        this.administrador.Location = new System.Drawing.Point(48, 120);
        this.administrador.Name = "administrador";
        this.administrador.Size = new System.Drawing.Size(47, 15);
        this.participantes.Controls.Add(this.administrador);

        //
        // adminInput
        //
        this.adminInput = new System.Windows.Forms.TextBox();
        this.adminInput.Text = "";
        this.adminInput.Location = new System.Drawing.Point(200, 112);
        this.adminInput.Name = "adminInput";
        this.adminInput.Size = new System.Drawing.Size(146, 23);
        this.adminInput.TabIndex = 20;
        this.participantes.Controls.Add(this.adminInput);

        //
        // presidente
        //
        this.presidente = new System.Windows.Forms.Label();
        this.presidente.AutoSize = true;
        this.presidente.Text = "Presidente(a)";
        this.presidente.Location = new System.Drawing.Point(48, 144);
        this.presidente.Name = "presidente";
        this.presidente.Size = new System.Drawing.Size(47, 15);
        this.participantes.Controls.Add(this.presidente);

        //
        // presidenteInput
        //
        this.presidenteInput = new System.Windows.Forms.TextBox();
        this.presidenteInput.Text = "";
        this.presidenteInput.Location = new System.Drawing.Point(200, 136);
        this.presidenteInput.Name = "presidenteInput";
        this.presidenteInput.Size = new System.Drawing.Size(146, 23);
        this.presidenteInput.TabIndex = 21;
        this.participantes.Controls.Add(this.presidenteInput);

        //
        // secretario
        //
        this.secretario = new System.Windows.Forms.Label();
        this.secretario.AutoSize = true;
        this.secretario.Text = "Secretario(a)";
        this.secretario.Location = new System.Drawing.Point(48, 168);
        this.secretario.Name = "secretario";
        this.secretario.Size = new System.Drawing.Size(47, 15);
        this.participantes.Controls.Add(this.secretario);

        //
        // secretarioInput
        //
        this.secretarioInput = new System.Windows.Forms.TextBox();
        this.secretarioInput.Text = "";
        this.secretarioInput.Location = new System.Drawing.Point(200, 160);
        this.secretarioInput.Name = "secretarioInput";
        this.secretarioInput.Size = new System.Drawing.Size(146, 23);
        this.secretarioInput.TabIndex = 22;
        this.participantes.Controls.Add(this.secretarioInput);

        //
        // escrutador
        //
        this.escrutador = new System.Windows.Forms.Label();
        this.escrutador.AutoSize = true;
        this.escrutador.Text = "Escrutador(a)";
        this.escrutador.Location = new System.Drawing.Point(48, 192);
        this.escrutador.Name = "escrutador";
        this.escrutador.Size = new System.Drawing.Size(47, 15);
        this.participantes.Controls.Add(this.escrutador);

        //
        // escrutadorInput
        //
        this.escrutadorInput = new System.Windows.Forms.TextBox();
        this.escrutadorInput.Text = "";
        this.escrutadorInput.Location = new System.Drawing.Point(200, 184);
        this.escrutadorInput.Name = "escrutadorInput";
        this.escrutadorInput.Size = new System.Drawing.Size(146, 23);
        this.escrutadorInput.TabIndex = 23;
        this.participantes.Controls.Add(this.escrutadorInput);

        //
        // ingresarElector
        //
        this.ingresarElector = new System.Windows.Forms.CheckBox();
        this.ingresarElector.AutoSize = true;
        this.ingresarElector.Text = "Permitir ingresar Electores";
        this.ingresarElector.Location = new System.Drawing.Point(56, 248);
        this.ingresarElector.Name = "ingresarElector";
        this.ingresarElector.Size = new System.Drawing.Size(85, 19);
        this.ingresarElector.TabIndex = 24;
        this.participantes.Controls.Add(this.ingresarElector);

        //
        // btnParticipantesGuardar
        //
        this.btnParticipantesGuardar = new System.Windows.Forms.Button();
        this.btnParticipantesGuardar.Text = "Guardar";
        this.btnParticipantesGuardar.Cursor = Cursors.Hand;
        this.btnParticipantesGuardar.Location = new System.Drawing.Point(56, 290);
        this.btnParticipantesGuardar.Name = "btnParticipantesGuardar";
        this.btnParticipantesGuardar.Size = new System.Drawing.Size(96, 32);
        this.btnParticipantesGuardar.TabIndex = 25;
        this.btnParticipantesGuardar.Click += btnParticipantesGuardar_Click;
        this.participantes.Controls.Add(this.btnParticipantesGuardar);


        //
        // ayuda
        //
        this.ayuda = new System.Windows.Forms.TabPage();
        this.ayuda.Location = new System.Drawing.Point(4, 24);
        this.ayuda.TabIndex = 4;
        this.ayuda.Text = "Ayuda";
        this.ayuda.Name = "ayuda";
        this.ayuda.Size = new System.Drawing.Size(792, 420);
        this.TabControl.Controls.Add(this.ayuda);
    }
       
    #endregion
    private TabControl TabControl;
    private TabPage inicio;
    private DataGridView contenedorInfoElecciones;
    private DataGridView contenedorInfoCandidatos;
    private Label nombreEventoAsignado;
    private Label fechaEventoAsignada;
    private Label fechaConfigAsignada;
    private Label cantidadEleccionesAsignada;
    private Label cantidadEquiposAsignada;
    private Label contrasenasAsignadas;
    private Label modificacionBD;
    private Label participantesEsperados;
    private Button btnTerminar;
    private TabPage evento;
    private Label nombreEvento;
    private TextBox nombreEventoInput;
    private Label fechaEvento;
    private DateTimePicker fechaEventoInput;
    private Label fechaConfig;
    private DateTimePicker fechaConfigInput;
    private Label numEquipos;
    private NumericUpDown numEquiposInput;
    private Button btnConfigGuardar;
    private Label eleccionActual;
    private Label nombreEleccion;
    private TextBox nombreEleccionInput;
    private Button btnGuardarEleccion;
    private Label agregarCandidatoLabel;
    private Label nombreCandidato;
    private TextBox nombreCandidatoInput;
    private Label paternoCandidato;
    private TextBox paternoCandidatoInput;
    private Label maternoCandidato;
    private TextBox maternoCandidatoInput;
    private Label claveCandidato;
    private TextBox claveCandidatoInput;
    private Label eleccionCandidato;
    private ComboBox eleccionCandidatoInput;
    private Button btnGuardarCandidato;
    private TabPage participantes;
    private CheckBox ingresarElector;
    private Label infoEncargados;
    private Label puesto;
    private Label contrasena;
    private Label administrador;
    private TextBox adminInput;
    private Label presidente;
    private TextBox presidenteInput;
    private Label secretario;
    private TextBox secretarioInput;
    private Label escrutador;
    private TextBox escrutadorInput;
    private Button btnParticipantesGuardar;
    private TabPage ayuda;
}