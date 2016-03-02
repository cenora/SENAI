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

namespace Eleicao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Conecta, consulta
        /// </summary>
        /// <param name="consulta">string</param>
        /// <returns></returns>
        private MySqlDataReader consulta(string consulta)
        {
            string conexao = "server=localhost;user id=root;persistsecurityinfo=True;database=eleicao";
            MySqlConnection Sqlconexao = new MySqlConnection(conexao);
            MySqlCommand Sqlcomando = new MySqlCommand(consulta, Sqlconexao);
            MySqlDataReader Sqlleitor;
            Sqlconexao.Open();
            return Sqlleitor = Sqlcomando.ExecuteReader();
        }
        /// <summary>
        /// Botão Salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "INSERT INTO eleicao.bg(bg.turmas,bg.candidato) values('" + this.txtTurma.Text + "','" + this.txtNome.Text + "');";
                MySqlDataReader SaveData = consulta(Query);
                MessageBox.Show("Candidato adicionado!");
                while (SaveData.Read())
                {
                    
                }
                //fechar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "update eleicao.bg set id='" + this.idText.Text + "',candidato='" + this.txtNome.Text  + "',turmas='" + this.txtTurma.Text + "'where id='" + this.idText.Text + "';";
                MySqlDataReader UpdateData;
                UpdateData = consulta(Query);
                MessageBox.Show("Candidato Atualizado!");
                while (UpdateData.Read())
                {

                }
                //fechar
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from eleicao.bg where id='" + this.idText.Text + "';";
                MySqlDataReader DeleteData;
                DeleteData = consulta(Query);

                MessageBox.Show("Candidato retirado.");
                while (DeleteData.Read())
                {

                }
                //fechar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.bgTableAdapter.Fill(this.eleicaoDataSet.bg);
            this.dataGridView1.Refresh();
            this.dataGridView1.Update();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eleicaoDataSet.bg' table. You can move, or remove it, as needed.
            this.bgTableAdapter.Fill(this.eleicaoDataSet.bg);
            this.bgTableAdapter.Fill(this.eleicaoDataSet.bg);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form login = new Form1();
            login.Show();
        }

        
      
    }
}
