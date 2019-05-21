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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(nametextBox);
            textBoxes.Add(emailtextBox);
            textBoxes.Add(addresstextBox);
            textBoxes.Add(phonetextBox);

            bool safe = false;

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Preencha todos os Campos");
                    safe = false;
                    break;
                }
                safe = true;
            }

            if (safe)
            {
                Empregado empregado = new Empregado();
                empregado.name = nametextBox.Text;
                empregado.email = emailtextBox.Text;
                empregado.address = addresstextBox.Text;
                string tmp = phonetextBox.Text;
                tmp = tmp.Replace(" ", "");
                tmp = tmp.Replace("(", "");
                tmp = tmp.Replace(")", "");
                tmp = tmp.Replace("-", "");
                Console.WriteLine(tmp);
                empregado.phone = Convert.ToInt64(tmp);

                Connection con = new Connection(Program.user, Program.password);
                if (con.adicionar(empregado))
                {
                    MessageBox.Show("Adicionado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha");
                    this.Close();
                }
            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
