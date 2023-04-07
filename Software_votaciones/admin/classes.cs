//Clases para conectar la interfaz

//conexion: Inserta y busca ciudadanos
//ciudadano: inicializa los datos del ciudadano
//ventanaResultados: Muestra una ventana con los datos
//Autor: Luis Pedroza
//Fecha: 2022


using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace admin;
//
//CLASE CONEXIÓN
//
public class conexion
{
    //comando para agregar el cliente sql en admin.csproj
    //dotNET add package System.Data.SqlClient --version 4.8.5
    //
    SqlConnection data = new SqlConnection("Data Source = 'AGREGAR RUTA'; Initial Catalog=votaciones; Integrated Security = True");
    SqlCommand solicitud = new SqlCommand();

    //
    //MÉTODO PARA INSERTAR CIUDADANO EN LA BD
    //
    public void InsertarCiudadano(string clave, string nombre, string apellidoP, string apellidoM)
    {
        //Limpiar y asignar parámetros
        solicitud.Parameters.Clear();
        solicitud.Parameters.AddWithValue("@clave", clave);
        solicitud.Parameters.AddWithValue("@nombre", nombre);
        solicitud.Parameters.AddWithValue("@apellidoP", apellidoP);
        solicitud.Parameters.AddWithValue("@apellidoM", apellidoM);

        try
        {
            //Abrir conexión y ejecutar comando SQL
            data.Open();
            solicitud.Connection = data;
            //modificar valor de ROLid según la tabla que se esta usando
            solicitud.CommandText = "INSERT INTO ciudadano (claveRegistro, nombre, apellidoPaterno, apellidoMaterno, ROLid) VALUES (@clave, @nombre, @apellidoP, @apellidoM, 1);";
            solicitud.ExecuteNonQuery();
        }
        //Control de excepciones 
        catch (SqlException ex) { MessageBox.Show("ERROR: " + ex); }
        finally { data.Close(); }
    }
    //
    //MÉTODO PARA BUSCAR CIUDADANO
    //
    public void BuscarCiudadano(string clave, string nombre, string apellidoP, string apellidoM)
    {
        //Crear lista de ciudadanos encontrados
        List<ciudadano> listaCiudadanos = new List<ciudadano>();
        string solicitud = "SELECT claveRegistro, nombre, apellidoPaterno, apellidoMaterno FROM ciudadano WHERE (claveRegistro like '%' + @clave + '%' OR nombre like '%' + @nombre + '%' OR apellidoPaterno like '%' + @apellidoP + '%' OR apellidoMaterno like '%' + @apellidoM + '%') and ROLid = 1;";
        var comando = new SqlCommand(solicitud, data);
        //Limpiar y asignar parámetros
        comando.Parameters.Clear();
        comando.Parameters.AddWithValue("@clave", clave);
        comando.Parameters.AddWithValue("@nombre", nombre);
        comando.Parameters.AddWithValue("@apellidoP", apellidoP);
        comando.Parameters.AddWithValue("@apellidoM", apellidoM);
        data.Open();
        var lectura = comando.ExecuteReader();
        //leer datos e ingresar a lista
        while (lectura.Read())
        {
            try
            {
                //Lectura de datos
                string lecturaClave = lectura[0].ToString();
                string lecturaNombre = lectura[1].ToString();
                string lecturaApellidoP = lectura[2].ToString();
                string lecturaApellidoM = lectura[3].ToString();
                //Agregar datos a la lista
                listaCiudadanos.Add(new ciudadano
                {
                    getClaveUnica = lecturaClave,
                    getNombre = lecturaNombre,
                    getApellidoP = lecturaApellidoP,
                    getApellidoM = lecturaApellidoM
                });
            }
            //control de excepciones 
            catch { throw new Exception("NO SE ENCONTRÓ EL USUARIO"); }
        }
        lectura.Close();
        data.Close();
        //agregar lista a una tabla
        DataTable dt = new DataTable();
        dt.Columns.Add("Clave");
        dt.Columns.Add("Nombre");
        dt.Columns.Add("Apellido Paterno");
        dt.Columns.Add("Apellido Materno");
        foreach (var ciudadano in listaCiudadanos)
        {
            dt.Rows.Add(ciudadano.getClaveUnica, ciudadano.getNombre, ciudadano.getApellidoP, ciudadano.getApellidoM);
        }
        //agregar datos a una ventana con datagrid
        VentanaResultados resultados = new VentanaResultados();
        resultados.CargarResultados(dt);
        resultados.Show();
    }
    //
    //MÉTODO PARA OBTENER CONTRASEÑA
    //
    public string ObtenerContraseña(string nombre)
    {
        string solicitud = "SELECT contrasena FROM rol WHERE nombre = @nombre;";
        var comando = new SqlCommand(solicitud, data);

        //Limpiar y asignar parámetros
        comando.Parameters.Clear();
        comando.Parameters.AddWithValue("@nombre", nombre);
        data.Open();
        var lectura = comando.ExecuteReader();
        //realizar lectura y retornar la contraseña
        try
        {
            if (lectura.Read())
            {
                string lecturaContraseña = lectura["contrasena"].ToString();
                return lecturaContraseña;
            }
            else { return null; }
        }
        //control de excepciones
        catch { throw new Exception("Algo salio mal al buscar la contraseña"); }
        finally { data.Close(); }
    }
    //
    //MÉTODO PARA OBTENER EL TIPO DE ACCESO QUE SE LE ASIGNO AL ADMINISTRADOR
    //
    public int ObtenerAcceso()
    {
        //modificar ROLid SEGÚN LA TABLA QUE SE USE
        //declaración de comando y apertura de conexión
        string solicitud = "SELECT ACLid FROM rol_ACL WHERE ROLid = 3;";
        var comando = new SqlCommand(solicitud, data);
        data.Open();
        var lectura = comando.ExecuteReader();
        //realizar lectura y retornar valor
        try
        {
            if (lectura.Read())
            {
                int lecturaAcceso = Convert.ToInt16(lectura["ACLid"].ToString());
                return lecturaAcceso;
            }
            else { throw new Exception("No se pudo realizar la lectura"); }
        }
        catch { throw new Exception("Algo salio mal al buscar el acceso"); }
        finally { data.Close(); }
    }
}
//
//CLASE CIUDADANO
//
public class ciudadano
{
    public string getNombre { get; set; }
    public string getApellidoP { get; set; }
    public string getApellidoM { get; set; }
    public string getClaveUnica { get; set; }
}
//
//CLASE VentanaResultados
//
public class VentanaResultados : Form
{
    private DataGridView contenedorCiudadanos;

    public VentanaResultados()
    {
        InitializeComponent();
    }
    //inicializar ventana con datagrid para almacenar datos del ciudadano
    private void InitializeComponent()
    {
        this.contenedorCiudadanos = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.contenedorCiudadanos)).BeginInit();
        this.SuspendLayout();
        // 
        // contenedorCiudadanos
        // 
        this.contenedorCiudadanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.contenedorCiudadanos.Dock = System.Windows.Forms.DockStyle.Fill;
        this.contenedorCiudadanos.Location = new System.Drawing.Point(0, 0);
        this.contenedorCiudadanos.Name = "dataGridView1";
        this.contenedorCiudadanos.Size = new System.Drawing.Size(300, 300);
        this.contenedorCiudadanos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.contenedorCiudadanos.TabIndex = 0;
        // 
        // VentanaResultados
        // 
        this.ClientSize = new System.Drawing.Size(500, 200);
        this.Controls.Add(this.contenedorCiudadanos);
        this.Icon = new Icon(@"fav.ico");
        this.Name = "CiudadanosEncontrados";
        this.Text = "Ciudadanos Encontrados";
        ((System.ComponentModel.ISupportInitialize)(this.contenedorCiudadanos)).EndInit();
        this.ResumeLayout(false);
    }
    //almacenar datos en datagrid
    public void CargarResultados(DataTable datos)
    {
        contenedorCiudadanos.DataSource = datos;
    }
}
