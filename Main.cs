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

    public partial class Main : Form{

        private Empregado empregado = new Empregado();

        public Main(){
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e){
            populateDataGridView();
        }

        private void Main_FormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> cells = new List<string>();
            cells.Add(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            cells.Add(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            cells.Add(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            cells.Add(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            cells.Add(dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());

            bool safe = false;

            foreach (string cell in cells)
            {
                if (string.IsNullOrWhiteSpace(cell))
                {
                    MessageBox.Show("Preencha todos os Campos");
                    safe = false;
                    break;
                }
                safe = true;
            }

            if (safe)
            {
                empregado.id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                empregado.name = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                empregado.email = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                empregado.address = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                empregado.phone = Convert.ToInt64(dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                nametextBox.Text = empregado.name;
                emailtextBox.Text = empregado.email;
                addresstextBox.Text = empregado.address;
                phonetextBox.Text = empregado.phone.ToString();
            }
        }

        private void populateDataGridView() {

            Connection con = new Connection(Program.user, Program.password);
            MySqlDataAdapter da = con.selecionar();
            if (da != null) {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Falha");
            }

            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Nome";
            dataGridView.Columns[2].HeaderText = "E-mail";
            dataGridView.Columns[3].HeaderText = "Endereço";
            dataGridView.Columns[4].HeaderText = "Telefone";
            dataGridView.Columns[4].DefaultCellStyle.Format = "(##) # ####-####";
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            add.FormClosed += new FormClosedEventHandler(AddClosed);
        }

        protected void AddClosed(Object sender, EventArgs e) {
            populateDataGridView();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            Connection con = new Connection(Program.user, Program.password);
            if (con.remover(empregado))
            {
                MessageBox.Show("Deletado");
                populateDataGridView();
            }
            else
            {
                MessageBox.Show("Falha");
            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            Connection con = new Connection(Program.user, Program.password);
            empregado.name = nametextBox.Text;
            empregado.email = emailtextBox.Text;
            empregado.address = addresstextBox.Text;
            empregado.phone = Convert.ToInt64(phonetextBox.Text);

            if (con.atualizar(empregado))
            {
                MessageBox.Show("Editado");
                populateDataGridView();
            }
            else
            {
                MessageBox.Show("Falha");
            }
            /*
            try
             {
                string name = nametextBox.Text;
                string email = emailtextBox.Text;
                string address = addresstextBox.Text;
                int phone = Convert.ToInt32(phonetextBox.Text);

                string myConnection = "datasource=localhost;port=3306;username=root;password=root";
                string query = "update empresa.empregados set nome='" + name + "', email='" + email + "', address='" + address + "', phone=" + phone + " where id="+ id +";";
                MySqlConnection connection = new MySqlConnection(myConnection);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Editado");
                while (reader.Read())
                {
                }
                connection.Close();
                populateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
