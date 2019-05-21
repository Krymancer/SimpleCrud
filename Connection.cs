using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SimpleCrud
{
    class Connection
    {
        String user;
        String password;

        public Connection(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public MySqlConnection getConnection() {
            string myConnection = "datasource=localhost;port=3306;username="+ this.user + ";password="+this.password;          
            return new MySqlConnection(myConnection);
        }
        

        public bool adicionar(Empregado empregado)
        {
            try
            {
                MySqlConnection con = getConnection();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into empresa.empregados values (0, ?name,?email,?address,?phone)", con);
                cmd.Parameters.Add(new MySqlParameter("name", empregado.name));
                cmd.Parameters.Add(new MySqlParameter("email", empregado.email));
                cmd.Parameters.Add(new MySqlParameter("address", empregado.address));
                cmd.Parameters.Add(new MySqlParameter("phone", empregado.phone));

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read()) { }
                con.Close();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public bool atualizar(Empregado empregado)
        {
            try
            {
                MySqlConnection con = getConnection();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update empresa.empregados set nome= ?name, email= ?email, address= ?address, phone= ?phone where id= ?id",   con);
                cmd.Parameters.AddWithValue("?name", empregado.name);
                cmd.Parameters.Add(new MySqlParameter("email", empregado.email));
                cmd.Parameters.Add(new MySqlParameter("address", empregado.address));
                cmd.Parameters.Add(new MySqlParameter("phone", empregado.phone));
                cmd.Parameters.Add(new MySqlParameter("id", empregado.id));

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read()) {}
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }

        }

        public bool remover(Empregado empregado)
        {
            try
            {
                MySqlConnection con = getConnection();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("delete from empresa.empregados where id=?id", con);
                cmd.Parameters.Add(new MySqlParameter("id", empregado.id));

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read()) { }
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public MySqlDataAdapter selecionar()
        {
            try
            {
                MySqlConnection con = getConnection();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from empresa.empregados", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                con.Close();
                return adapter;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }


        public bool loginAutenticate(User user)
        {
            MySqlConnection con = getConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from empresa.users where username=?username and password=?password", con);
            cmd.Parameters.Add(new MySqlParameter("username", user.username));
            cmd.Parameters.Add(new MySqlParameter("password", user.password));

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class Empregado
    {
        public string name    { get; set; }
        public string email   { get; set; }
        public string address { get; set; }
        public long   phone   { get; set; }
        public int    id      { get; set; }

    }

    public class User
    {

        public string username { get; set; }
        public string password { get; set; }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

    }
}
