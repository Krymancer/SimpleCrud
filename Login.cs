using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimpleCrud
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Program.user = usernametextBox.Text;
            Program.password = passwordtextBox.Text;

            //User user = new User(username, password);
            Connection connection = new Connection(Program.user, Program.password);
            MySqlConnection c = connection.getConnection();
            try
            {
                c.Open();
                Main main = new Main();
                this.Visible = false;
                main.ShowDialog();
                this.Close();
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
