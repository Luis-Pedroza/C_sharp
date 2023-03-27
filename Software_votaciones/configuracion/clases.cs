//Clases para las funciones de la interfaz que configura la base de datos que se usara en votaciones
//Por Luis Fernando Pedroza Moranchel
using System.Data.SqlClient;
namespace configuracion;
//CLASE CONEXIÓN
public class conexion
{
    //comando
    //dotNET add package System.Data.SqlClient --version 4.8.5
    SqlConnection data = new SqlConnection("Data Source = AGREGAR RUTA\\SQLEXPRESS; Initial Catalog=votaciones; Integrated Security = True");
    SqlCommand solicitud = new SqlCommand();
    //
    //METODO PARA INSERTAR LAS ELECCIONES EN LA BD
    //
    public void InsertarEleccion(string nombre, string fechaV, string fechaC)
    {
        //Limpiar y asignar parámetros
        solicitud.Parameters.Clear();
        solicitud.Parameters.AddWithValue("@nombre", nombre);
        solicitud.Parameters.AddWithValue("@fechaV", fechaV);
        solicitud.Parameters.AddWithValue("@fechaC", fechaC);
        try
        {
            //Abrir conexión y ejecutar comando SQL
            data.Open();
            solicitud.CommandText = "INSERT INTO eleccion (nombre, fechaVotacion, fechaCreacion ) VALUES (@nombre, @fechaV, @fechaC);";
            solicitud.Connection = data;
            solicitud.ExecuteNonQuery();
        }
        catch { MessageBox.Show("ALGO SALIO MAL AL GUARDAR LA ELECCIÓN"); }
        finally { data.Close(); }
    }

    //
    //MÉTODO PARA INSERTAR LOS CANDIDATOS EN LA BD
    //
    public void InsertarCandidato(string clave, string nombre, string apellidoP, string apellidoM, string eleccion)
    {
        //Declaración de variables y comandos SQL
        string solicitudID = "SELECT id FROM eleccion WHERE nombre = @eleccion;";
        var comando = new SqlCommand(solicitudID, data);
        //modificar valor de ROLid según la tabla que se esta usando
        var ciudadano = solicitud.CommandText = "INSERT INTO ciudadano (claveRegistro, nombre, apellidoPaterno, apellidoMaterno, ROLid) VALUES (@clave, @nombre, @apellidoP, @apellidoM, 2);";
        var candidato = solicitud.CommandText = "INSERT INTO candidato (claveRegistroID, eleccionID) VALUES (@clave, @ID);";

        //Limpiar y asignar parámetros
        solicitud.Parameters.Clear();
        solicitud.Parameters.AddWithValue("@clave", clave);
        solicitud.Parameters.AddWithValue("@nombre", nombre);
        solicitud.Parameters.AddWithValue("@apellidoP", apellidoP);
        solicitud.Parameters.AddWithValue("@apellidoM", apellidoM);
        comando.Parameters.AddWithValue("@eleccion", eleccion);

        //Abrir conexión y obtener el ID de la eleccion seleccionada
        data.Open();
        var lectura = comando.ExecuteReader();
        if (lectura.Read())
        {
            int ID = Convert.ToInt16(lectura[0].ToString());
            solicitud.Parameters.AddWithValue("@ID", ID);
            lectura.Close();
        }

        try
        {
            //Ingresar Ciudadano
            solicitud.Connection = data;
            solicitud.CommandText = ciudadano;
            solicitud.ExecuteNonQuery();
            //Ingresar Candidato
            solicitud.CommandText = candidato;
            solicitud.ExecuteNonQuery();
        }
        catch (SqlException ex) { MessageBox.Show("ERROR: " + ex); }
        finally { data.Close(); }
    }

    //
    //MÉTODO PARA CAMBIAR CONTRASEÑAS DE ROLES EN LA BD
    //
    public void InsertarROL(string nombre, string contrasena)
    {
        //Limpiar y asignar parámetros
        solicitud.Parameters.Clear();
        solicitud.Parameters.AddWithValue("@nombre", nombre);
        solicitud.Parameters.AddWithValue("@contrasena", contrasena);
        try
        {
            //Abrir conexión y ejecutar comando SQL
            data.Open();
            solicitud.CommandText = "UPDATE rol SET contrasena = @contrasena, fecha = GETDATE() WHERE nombre = @nombre;";
            solicitud.Connection = data;
            solicitud.ExecuteNonQuery();
        }
        catch (SqlException ex) { MessageBox.Show("ERROR: " + ex); }
        finally { data.Close(); }
    }

    //
    //MÉTODO PARA OBTENER LA CANTIDAD DE CIUDADANOS
    //
    public int ObtenerCiudadanos()
    {
        string solicitud = "SELECT COUNT(*) FROM ciudadano;";
        var comando = new SqlCommand(solicitud, data);
        //Abrir conexión y obtener el ID de la eleccion seleccionada
        data.Open();
        var lectura = comando.ExecuteReader();
        if (lectura.Read())
        {
            int ID = Convert.ToInt16(lectura[0].ToString());
            lectura.Close();
            data.Close();
            return ID;
        }
        else { data.Close(); return 0; }

    }

    //
    //MÉTODO PARA MODIFICAR EL ACCESO DEL ADMINISTRADOR
    //
    public void ModificarAcceso(bool acceso)
    {
        try
        {
            //Abrir conexión y ejecutar comando SQL
            data.Open();
            //modificar rol_ACL y ACLid según la tabla que se use
            if (acceso == true)
            {
                solicitud.CommandText = "UPDATE rol_ACL SET ROLid = 3, ACLid = 2 WHERE id = 1;";
                solicitud.Connection = data;
                solicitud.ExecuteNonQuery();
            }
            else if (acceso == false)
            {
                solicitud.CommandText = "UPDATE rol_ACL SET ROLid = 3, ACLid = 1 WHERE id = 1;";
                solicitud.Connection = data;
                solicitud.ExecuteNonQuery();
            }
            else { throw new Exception("No se recibió un valor valido"); }
        }
        catch { MessageBox.Show("NO SE PUDO CAMBIAR EL ACCESO DEL ADMINISTRADOR"); }
        finally { data.Close(); }

    }
}
//
//CLASE CONFIGURACIÓN
//
public class Configuracion
{
    public string getNombreEvento { get; set; }
    public string getFechaEvento { get; set; }
    public string getFechaConfig { get; set; }
    public int getCantidadEquipos { get; set; }
}
//
//CLASE ROL
//
public class Rol
{
    public string getNombreRol { get; set; }
    public string getContrasenaRol { get; set; }
}
//
//CLASE ELECCIÓN
//
public class Eleccion
{
    public string getNombreEleccion { get; set; }
    public int getNumCandidatosEleccion { get; set; }
}
//
//CLASE CANDIDATO
//
public class Candidato : Eleccion
{
    public string getNombreCandidato { get; set; }
    public string getApellidoPaternoCandidato { get; set; }
    public string getApellidoMaternoCandidato { get; set; }
    public string getClaveCandidato { get; set; }
}