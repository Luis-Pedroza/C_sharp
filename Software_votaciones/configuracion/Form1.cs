//Funciones para la interfaz que configura la base de datos que se usara en votaciones
//Por Luis Fernando Pedroza Moranchel
namespace configuracion;

public partial class Form1 : Form
{
    List<Eleccion> listaEleccion = new List<Eleccion>();
    List<Candidato> listaCandidatos = new List<Candidato>();
    Configuracion newConfig = new Configuracion();
    Rol adminRol = new Rol();
    Rol presidenteRol = new Rol();
    Rol secretarioRol = new Rol();
    Rol escrutadorRol = new Rol();
    conexion conectar = new conexion();
    public Form1()
    {
        InitializeComponent();
    }

    //
    //FUNCIÓN PARA TERMINAR LA CONFIGURACIÓN
    //
    private void btnTerminar_Click(object sender, EventArgs e)
    {
        //validación de nulos
        if (RevisarNulo("OBparticipantes") != true && RevisarNulo("candidatoGrid") != true && RevisarNulo("eleccionGrid") != true && RevisarNulo("OBevento") != true)
        {
            //aviso para terminar
            var msg = MessageBox.Show("¿Desea terminar la configuración?", "Terminar", MessageBoxButtons.OKCancel);
            if (msg == DialogResult.OK)
            {
                try
                {
                    //Ingresar elecciones, ciudadanos, candidatos
                    foreach (DataGridViewRow row in contenedorInfoElecciones.Rows)
                    {
                        conectar.InsertarEleccion(row.Cells[0].Value.ToString(), newConfig.getFechaEvento, newConfig.getFechaConfig);
                    }
                    foreach (DataGridViewRow row in contenedorInfoCandidatos.Rows)
                    {
                        conectar.InsertarCandidato(row.Cells[3].Value.ToString(), row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString());
                    }
                    //Modificacion de las contraseñas en la tabla rol
                    conectar.InsertarROL("administrador", adminRol.getContrasenaRol);
                    conectar.InsertarROL("presidente", presidenteRol.getContrasenaRol);
                    conectar.InsertarROL("secretario", secretarioRol.getContrasenaRol);
                    conectar.InsertarROL("escrutador", escrutadorRol.getContrasenaRol);
                    //modificar acceso del administrador
                    if (ingresarElector.Checked)
                    {
                        conectar.ModificarAcceso(true);
                    }
                    else
                    {
                        conectar.ModificarAcceso(false);
                    }

                    MessageBox.Show("Los datos se guardaron correctamente");
                    this.Close();
                }
                catch { throw new Exception("ALGO SALIO MAL A GUARDAR LOS DATOS"); }
            }
        }
        else { MessageBox.Show("Aun no ingresa todos los datos, verifique todos los campos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
    }

    //
    //MOSTRAR OPCIÓN ELIMINAR CELDA DE ELECCIÓN EN FILA SELECCIONADA CON CLICK DERECHO
    //
    private void CeldaEleccion_Click(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            int posicion = contenedorInfoElecciones.HitTest(e.X, e.Y).RowIndex;
            if (posicion > -1)
            {
                menu.Items.Add("eliminar").Name = "Eliminar";
            }
            menu.Show(contenedorInfoElecciones, e.X, e.Y);
            menu.ItemClicked += new ToolStripItemClickedEventHandler(EliminarFilaEleccion);
        }
    }
    //
    //FUNCIÓN PARA ELIMINAR FILA SELECCIONADA EN LA TABLA ELECION
    //
    private void EliminarFilaEleccion(object sender, ToolStripItemClickedEventArgs e)
    {
        int fila = contenedorInfoElecciones.CurrentRow.Index;
        listaEleccion.RemoveAt(fila);
        contenedorInfoElecciones.DataSource = null;
        contenedorInfoElecciones.DataSource = listaEleccion;
        contenedorInfoElecciones.Columns[0].HeaderText = "Eleccion";
        contenedorInfoElecciones.Columns[1].HeaderText = "Candidatos";
    }

    //
    //MOSTRAR OPCIÓN ELIMINAR CELDA DE CANDIDATOS EN FILA SELECCIONADA CON CLICK DERECHO
    //
    private void CeldaCandidato_Click(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            int posicion = contenedorInfoCandidatos.HitTest(e.X, e.Y).RowIndex;
            if (posicion > -1)
            {
                menu.Items.Add("eliminar").Name = "Eliminar";
            }
            menu.Show(contenedorInfoCandidatos, e.X, e.Y);
            menu.ItemClicked += new ToolStripItemClickedEventHandler(EliminarFilaCandidato);
        }
    }

    //
    //FUNCIÓN PARA ELIMINAR FILA SELECCIONADA EN LA TABLA CANDIDATOS
    //
    private void EliminarFilaCandidato(object sender, ToolStripItemClickedEventArgs e)
    {
        int fila = contenedorInfoCandidatos.CurrentRow.Index;

        //restar el candidato eliminado en la tabla elecciones 
        foreach (DataGridViewRow row in contenedorInfoElecciones.Rows)
        {
            if (row.Cells[0].Value.ToString() == contenedorInfoCandidatos.Rows[fila].Cells[4].Value.ToString())
            {
                row.Cells[1].Value = Convert.ToInt16(row.Cells[1].Value) - 1;
            }
        }

        listaCandidatos.RemoveAt(fila);
        contenedorInfoCandidatos.DataSource = null;
        contenedorInfoCandidatos.DataSource = listaCandidatos;
        contenedorInfoCandidatos.Columns[0].HeaderText = "Nombre";
        contenedorInfoCandidatos.Columns[1].HeaderText = "Ap Paterno";
        contenedorInfoCandidatos.Columns[2].HeaderText = "Ap Materno";
        contenedorInfoCandidatos.Columns[3].HeaderText = "Clave";
        contenedorInfoCandidatos.Columns[4].HeaderText = "Eleccion";
        contenedorInfoCandidatos.Columns.RemoveAt(5);
    }

    //
    //FUNCIÓN PARA GUARDAR LOS DATOS DEL EVENTO
    //
    private void btnConfigGuardar_Click(object sender, EventArgs e)
    {
        //validación de nulos
        if (RevisarNulo("evento") != true)
        {
            try
            {
                //Obtener datos de Input
                newConfig.getNombreEvento = CambiarTexto(nombreEventoInput.Text);
                newConfig.getFechaEvento = fechaEventoInput.Text;
                newConfig.getFechaConfig = fechaConfigInput.Text;
                newConfig.getCantidadEquipos = Int32.Parse(numEquiposInput.Text);

                //Asignar valores en Labels
                nombreEventoAsignado.Text = "Nombre del evento: " + newConfig.getNombreEvento;
                fechaEventoAsignada.Text = "Fecha del evento: " + newConfig.getFechaEvento;
                fechaConfigAsignada.Text = "Fecha de configuración: " + newConfig.getFechaConfig;
                cantidadEquiposAsignada.Text = "Cantidad de equipos: " + newConfig.getCantidadEquipos;
            }
            catch { throw new Exception("ALGO SALIO MAL A GUARDAR LOS DATOS"); }
        }
        else { MessageBox.Show("No puede agregar un campo vació", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
    }

    //
    //FUNCIÓN PARA GUARDAR NUEVA ELECCIÓN
    //
    private void btnGuardarEleccion_Click(object sender, EventArgs e)
    {
        Eleccion newEleccion = new Eleccion();
        //validación de nulos
        if (RevisarNulo("eleccion") != true)
        {
            try
            {
                //obtener datos de input
                newEleccion.getNombreEleccion = CambiarTexto(nombreEleccionInput.Text);
                newEleccion.getNumCandidatosEleccion = 0;
                //agregar a lista, asignar al contenedor y asignar nombRe de las columnas
                listaEleccion.Add(newEleccion);
                contenedorInfoElecciones.DataSource = null;
                contenedorInfoElecciones.DataSource = listaEleccion;
                contenedorInfoElecciones.Columns[0].HeaderText = "Eleccion";
                contenedorInfoElecciones.Columns[1].HeaderText = "Candidatos";
                //limpiar campos y enfocar el cursor
                nombreEleccionInput.Clear();
                nombreEleccionInput.Focus();
            }
            catch { throw new Exception("ALGO SALIO MAL AL GUARDAR LOS DATOS"); }
            cantidadEleccionesAsignada.Text = "Cantidad de elecciones: " + contenedorInfoElecciones.RowCount;
            contenedorInfoElecciones.Columns[1].ReadOnly = true;
        }
        else { MessageBox.Show("No puede agregar un campo vació", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
    }

    //
    //FUNCIÓN PARA GUARDAR NUEVO CANDIDATO
    //
    private void btnGuardarCandidato_Click(object snder, EventArgs e)
    {
        Candidato newCandidato = new Candidato();
        //Validación de nulos
        if (RevisarNulo("candidato") != true)
        {
            try
            {
                //obtener datos de input
                newCandidato.getNombreCandidato = CambiarTexto(nombreCandidatoInput.Text);
                newCandidato.getApellidoPaternoCandidato = CambiarTexto(paternoCandidatoInput.Text);
                newCandidato.getApellidoMaternoCandidato = CambiarTexto(maternoCandidatoInput.Text);
                newCandidato.getClaveCandidato = claveCandidatoInput.Text;
                newCandidato.getNombreEleccion = eleccionCandidatoInput.Text;
                //agregar a lista, asignar al contenedor y asignar nombe de las columnas
                listaCandidatos.Add(newCandidato);
                contenedorInfoCandidatos.DataSource = null;
                contenedorInfoCandidatos.DataSource = listaCandidatos;
                contenedorInfoCandidatos.Columns[0].HeaderText = "Nombre";
                contenedorInfoCandidatos.Columns[1].HeaderText = "Ap Paterno";
                contenedorInfoCandidatos.Columns[2].HeaderText = "Ap Materno";
                contenedorInfoCandidatos.Columns[3].HeaderText = "Clave";
                contenedorInfoCandidatos.Columns[4].HeaderText = "Eleccion";
                contenedorInfoCandidatos.Columns.RemoveAt(5);
                //aumentar numero de candidatos en la tabla elecciones
                foreach (DataGridViewRow row in contenedorInfoElecciones.Rows)
                {
                    if (row.Cells[0].Value.ToString() == newCandidato.getNombreEleccion)
                    {
                        row.Cells[1].Value = Convert.ToInt16(row.Cells[1].Value) + 1;
                    }
                }
                //Limpiar campos y posicionar el cursor
                nombreCandidatoInput.Clear();
                paternoCandidatoInput.Clear();
                maternoCandidatoInput.Clear();
                claveCandidatoInput.Clear();
                eleccionCandidatoInput.Text = null;
                nombreCandidatoInput.Focus();

            }
            catch { throw new Exception("ALGO SALIO MAL AL GUARDAR LOS DATOS"); }
            contenedorInfoCandidatos.Columns[4].ReadOnly = true;
        }
        else { MessageBox.Show("No puede agregar un campo vació", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
    }

    //
    //FUNCIÓN PARA MOSTRAR LAS ELECCIONES DISPONIBLES EN COMBOBOXES
    //
    private void MostrarListaElecciones_Click(object sender, EventArgs e)
    {
        eleccionCandidatoInput.Items.Clear();
        for (int i = 0; i < contenedorInfoElecciones.RowCount; i++)
        {
            eleccionCandidatoInput.Items.Add(contenedorInfoElecciones.Rows[i].Cells[0].Value);
        }
    }
    //
    //FUNCION PARA OBTENER CONTRASEÑAS ASIGNADAS
    //
    private void btnParticipantesGuardar_Click(object sender, EventArgs e)
    {
        int ciudadanos = conectar.ObtenerCiudadanos();
        //validación de nulos
        if (RevisarNulo("participantes") != true)
        {
            try
            {
                //Obtener datos de Input
                adminRol.getContrasenaRol = adminInput.Text;
                presidenteRol.getContrasenaRol = presidenteInput.Text;
                secretarioRol.getContrasenaRol = secretarioInput.Text;
                escrutadorRol.getContrasenaRol = escrutadorInput.Text;
                contrasenasAsignadas.Text = "Contraseñas asignadas: SI";
            }
            catch { throw new Exception("ALGO SALIO MAL AL GUARDAR LOS DATOS"); }
        }
        else { MessageBox.Show("No puede agregar un campo vació", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        //obtener opción del CheckBox
        if (ingresarElector.Checked)
        {
            modificacionBD.Text = "Permitir ingresar Electores: SI";
        }
        else
        {
            modificacionBD.Text = "Permitir ingresar Electores: NO";
        }
        participantesEsperados.Text = "Participantes esperados: " + ciudadanos;
    }
    //
    //FUNCIÓN PARA CAMBIAR TEXTO INGRESADO (Primera Letra Mayúscula)
    //
    private string CambiarTexto(string sender)
    {
        try
        {
            string texto = sender.ToLower() ?? throw new Exception();
            return texto.First().ToString().ToUpper() + texto.Substring(1);
        }
        catch { return string.Empty; }
    }
    //
    //FUNCIÓN PARA REVISAR NULOS POR BLOQUE (EVENTO, ELECCIÓN, CANDIDATO, PARTICIPANTES)
    //
    public bool RevisarNulo(string bloque)
    {
        bool retorno = true;
        switch (bloque)
        {
            case "evento":
                retorno = string.IsNullOrEmpty(nombreEventoInput.Text);
                break;
            case "OBevento":
                retorno = string.IsNullOrEmpty(newConfig.getNombreEvento);
                break;
            case "eleccion":
                retorno = string.IsNullOrEmpty(nombreEleccionInput.Text);
                break;
            case "candidato":
                retorno = string.IsNullOrEmpty(nombreCandidatoInput.Text)
                || string.IsNullOrEmpty(paternoCandidatoInput.Text)
                || string.IsNullOrEmpty(maternoCandidatoInput.Text)
                || string.IsNullOrEmpty(claveCandidatoInput.Text)
                || string.IsNullOrEmpty(eleccionCandidatoInput.Text);
                break;
            case "eleccionGrid":
                retorno = contenedorInfoElecciones.Rows.Count == 0;
                break;
            case "candidatoGrid":
                retorno = contenedorInfoCandidatos.Rows.Count == 0;
                break;
            case "OBparticipantes":
                retorno = string.IsNullOrEmpty(adminRol.getContrasenaRol)
            || string.IsNullOrEmpty(presidenteRol.getContrasenaRol)
            || string.IsNullOrEmpty(secretarioRol.getContrasenaRol)
            || string.IsNullOrEmpty(escrutadorRol.getContrasenaRol);
                break;
            case "participantes":
                retorno = string.IsNullOrEmpty(adminInput.Text)
            || string.IsNullOrEmpty(presidenteInput.Text)
            || string.IsNullOrEmpty(secretarioInput.Text)
            || string.IsNullOrEmpty(escrutadorInput.Text);
                break;
            default: throw new Exception("Bloque no reconocido");
        }
        return retorno;
    }
}