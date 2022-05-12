using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VeterinarioBasico_2022
{

    class Conexion
    {
        public MySqlConnection conexion;
        

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd = ");
        }
        public Boolean loginVeterinario(String DNI, String pass)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                //consulta mal hecha, te pueden tirar la base de datos con "'OR 1=1;--
                //new MySqlCommand("SELECT * FROM usuario where DNI = '" + DNI + "' AND pass = '" + pass + "'", conexion);
                //consulta BIEN HECHA, hay que hacerla asi!!
                new MySqlCommand("SELECT * FROM usuario where DNI = @DNI", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    string passwordHash = resultado.GetString("password");
                    if (BCrypt.Net.BCrypt.Verify(pass, passwordHash))
                    {
                        return true;
                    }
                    return false;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
        public String insertaUsuario(String DNI, String Nombre, String Apellido, String password, String email)
        {     
                conexion.Open();
                MySqlCommand consultaUsuario =
                    new MySqlCommand("INSERT INTO usuario (DNI, Nombre, Apellido, password, email) VALUES (@DNI, @Nombre, @Apellido, @password, @email)", conexion);
            consultaUsuario.Parameters.AddWithValue("@DNI", DNI);
            consultaUsuario.Parameters.AddWithValue("@Nombre", Nombre);
            consultaUsuario.Parameters.AddWithValue("@Apellido", Apellido);
            consultaUsuario.Parameters.AddWithValue("@password", password);
            consultaUsuario.Parameters.AddWithValue("@email", email);

            //Al ser una consulta de inserción no se pone executeReader se pone esto, ya que no espera recibir nada

            consultaUsuario.ExecuteNonQuery();

                conexion.Close();
                return "ok";
          
        }
        public String insertaMascota(String chip, String Nombre, String Dueño, String Animal)
        {
            conexion.Open();
            MySqlCommand consultaMascota =
                new MySqlCommand("INSERT INTO mascotas (chip, Nombre, Dueño, Animal) VALUES (@chip, @Nombre, @Dueño, @Animal)", conexion);
            consultaMascota.Parameters.AddWithValue("@chip", chip);
            consultaMascota.Parameters.AddWithValue("@Nombre", Nombre);
            consultaMascota.Parameters.AddWithValue("@Dueño", Dueño);
            consultaMascota.Parameters.AddWithValue("@Animal", Animal);

            //Al ser una consulta de inserción no se pone executeReader se pone esto, ya que no espera recibir nada

            consultaMascota.ExecuteNonQuery();

            conexion.Close();
            return "ok";

        }
        public String insertaCita(String Dia, String Hora, String Motivo, String Mascota)
        {
            conexion.Open();
            MySqlCommand consultaCita =
                new MySqlCommand("INSERT INTO citas (Dia, Hora, Motivo, Mascota) VALUES (@Dia, @Hora, @Motivo, @Mascota)", conexion);
            consultaCita.Parameters.AddWithValue("@Dia", Dia);
            consultaCita.Parameters.AddWithValue("@Hora", Hora);
            consultaCita.Parameters.AddWithValue("@Motivo", Motivo);
            consultaCita.Parameters.AddWithValue("@Mascota", Mascota);

            //Al ser una consulta de inserción no se pone executeReader se pone esto, ya que no espera recibir nada

            consultaCita.ExecuteNonQuery();

            conexion.Close();
            return "ok";

        }
        public DataTable buscarUsuario(String busquedaU)
        {
            conexion.Open();
            string query1 = "SELECT * FROM usuario WHERE CONCAT(nombre) LIKE '%" + busquedaU + "%'";
            MySqlCommand consultaBusqueda = new MySqlCommand(query1, conexion);
            MySqlDataReader adaptar = consultaBusqueda.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(adaptar);
            conexion.Close();
            return tabla;
        }
        public DataTable buscarMascota(String busquedaM)
        {
            conexion.Open();
            string query2 = "SELECT * FROM mascotas WHERE CONCAT(nombre) LIKE '%" + busquedaM + "%'";
            MySqlCommand consultaBusqueda = new MySqlCommand(query2, conexion);
            MySqlDataReader adaptar = consultaBusqueda.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(adaptar);
            conexion.Close();
            return tabla;
        }
    }
    
}
