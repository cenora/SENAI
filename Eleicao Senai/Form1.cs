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
using System.Threading;

namespace Eleicao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PassTextBox.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string stringconexao = "server=localhost;user id=root;persistsecurityinfo=True;database=eleicao";
                MySqlConnection minhaconexao = new MySqlConnection(stringconexao);
                MySqlCommand consulta = new MySqlCommand("select * from eleicao.users where user='" + this.UserTextBox.Text + "' and pass='" + this.PassTextBox.Text + "' ;", minhaconexao);
                MySqlDataReader containerusuarios;

                minhaconexao.Open();
                containerusuarios = consulta.ExecuteReader();
                int count = 0;
                while (containerusuarios.Read())
                {
                    Console.WriteLine(containerusuarios[count]);
                    count++;
                }
                //MessageBox.Show("Username and password is correct");
                //this.Hide();
                //Form2 f2 = new Form2();
                //f2.ShowDialog();
                if (count == 1)
                {
                    MessageBox.Show("Seja Bem-Vindo!");
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else if (count > 1)
                {

                    MessageBox.Show("Acesso negado.\nExiste usuario iguais. Contate o admin.");
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos.\nTente mais uma vez.");
                }
                minhaconexao.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eleicaoDataSet.bg' table. You can move, or remove it, as needed.
            this.bgTableAdapter.Fill(this.eleicaoDataSet.bg);

            string stringconexao = "server=localhost;user id=root;persistsecurityinfo=True;database=eleicao";
                MySqlConnection minhaconexao = new MySqlConnection(stringconexao);
                MySqlCommand consulta = new MySqlCommand("select distinct bg.turmas from eleicao.bg", minhaconexao);
                MySqlDataReader turmasunicas;

                minhaconexao.Open();
                turmasunicas = consulta.ExecuteReader();

            IList<string> listName = new List<string>();
                    while (turmasunicas.Read())
                    {
                        listName.Add(turmasunicas[0].ToString());
                    }
                    listName = listName.Distinct().ToList();
                    comboBox1.DataSource = listName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form votar = new Form3(this);
            votar.ShowDialog();
        }
      
    }
}
