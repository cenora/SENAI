using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Media;
using System.IO;

namespace Eleicao
{
    public partial class Form3 : Form
    {
        Form1 instanciaLogin; //passagem
        public string voto = string.Empty;

        public Form3(Form1 login)
        {
            InitializeComponent();
            instanciaLogin = login; //passagem
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form login = new Form1();
            login.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eleicaoDataSet.bg' table. You can move, or remove it, as needed.
            this.bgTableAdapter.Fill(this.eleicaoDataSet.bg);

            this.Text = "Votação da Turma: " + instanciaLogin.comboBox1.SelectedValue.ToString(); 

            //int altura = 25;
            int i = 0;
            foreach (string opcoes in this.preenche())
            {
                //RadioButton rb = new RadioButton()
                //{
                //    Text = linguagem,
                //    Location = new Point(10, altura),
                //    Width = opcoesDeCandidatos.Width - 30
                //};
                //altura += 25;
                //opcoesDeCandidatos.Controls.Add(rb);
                if (i == 0)
                {
                    if (opcoes == null)
                    {
                        radioButton1.Hide();
                    }
                    else
                        radioButton1.Text = opcoes;
                }
                if (i == 1)
                {
                    if (opcoes == null)
                    {
                        radioButton2.Hide();
                    }
                    else
                        radioButton2.Text = opcoes;
                }
                if (i == 2)
                {
                    if (opcoes == null)
                    {
                        radioButton3.Hide();
                    }
                    else
                        radioButton3.Text = opcoes;
                }
                if (i == 3)
                {
                    if (opcoes==null)
                    {
                        radioButton4.Hide();
                    }
                    else
                    radioButton4.Text = opcoes;
                }
                if (i == 4)
                {
                    if (opcoes == null)
                    {
                        radioButton5.Hide();
                    }
                    else
                        radioButton5.Text = opcoes;
                }
                if (i == 5)
                {
                    if (opcoes == null)
                    {
                        radioButton6.Hide();
                    }
                    else
                        radioButton6.Text = opcoes;
                }
                if (i == 6)
                {
                    if (opcoes == null)
                    {
                        radioButton7.Hide();
                    }
                    else
                        radioButton7.Text = opcoes;
                }
                if (i == 7)
                {
                    if (opcoes == null)
                    {
                        radioButton8.Hide();
                    }
                    else
                        radioButton8.Text = opcoes;
                }
                i++;

            }
            //altura += 10;
            //opcoesDeCandidatos.Height = altura;
            opcoesDeCandidatos.Text = "Escolha o seu candidato: ";
        }
        /// <summary>
        /// Retorna a lista de candidatos
        /// </summary>
        /// <returns>String Lista de candidatos</returns>
        private string[] preenche()
        {
            
            try
            {
                string Query = "SELECT candidato from bg where turmas= '" + this.instanciaLogin.comboBox1.SelectedValue.ToString() + "'";
                MySqlDataReader candidatos = consulta(Query);
                string[] listacandidatos = {};
                listacandidatos = new string[8];

                int i = 0;
                while (candidatos.Read())
                {
                    listacandidatos[i++] = candidatos["candidato"].ToString().ToUpper();
                }
                //fechar
                return listacandidatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new string[] { "ERRO", "ERRO", "ERRO", "ERRO", "ERRO", "ERRO", "ERRO", "ERRO" };
            }            
        }

        private MySqlDataReader consulta(string consulta)
        {
            string conexao = "server=localhost;user id=root;persistsecurityinfo=True;database=eleicao";
            MySqlConnection Sqlconexao = new MySqlConnection(conexao);
            MySqlCommand Sqlcomando = new MySqlCommand(consulta, Sqlconexao);
            MySqlDataReader Sqlleitor;
            Sqlconexao.Open();
            return Sqlleitor = Sqlcomando.ExecuteReader();
        }

        private void Confirma_Click(object sender, EventArgs e)
        {
            try
            {

                //TODO: Parei aqui, pegar valor do radio button checado
                string Query = "update eleicao.bg set qtdVotos= qtdVotos+1 where candidato='" + voto + "';";
                MySqlDataReader Voto;
                Voto = consulta(Query);
                string log = "insert into eleicao.log(candidato) values ('"+ voto + "')";
                Voto = consulta(log);
                MessageBox.Show("Voto realizado, Obrigado!");
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
                Voto.Dispose();
                //precisa da biblioteca media em system

                //Console.Beep(777, 300);
                //Console.Beep(888, 300);
                //Console.Beep(999, 300);
                //Console.Beep(777, 300);
                Thread.Sleep(10000);
                this.Hide();
                //while (UpdateData.Read())
                //{
                //
                //}
                //fechar
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fotoCandidato.ImageLocation = "\\fotos\\" + radioButton1.Text.ToLower() + ".jpg";
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voto = radioButton1.Text;
            }
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fotoCandidato.ImageLocation = "\\fotos\\" + radioButton2.Text.ToLower() + ".jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voto = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fotoCandidato.ImageLocation = "\\fotos\\" + radioButton3.Text.ToLower() + ".jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voto = radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fotoCandidato.ImageLocation = "\\fotos\\" + radioButton4.Text.ToLower() + ".jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voto = radioButton4.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fotoCandidato.ImageLocation = "\\fotos\\" + radioButton5.Text.ToLower() + ".jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voto = radioButton5.Text;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fotoCandidato.ImageLocation = "\\fotos\\" + radioButton6.Text.ToLower() + ".jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voto = radioButton6.Text;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fotoCandidato.ImageLocation = "\\fotos\\" + radioButton7.Text.ToLower() + ".jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voto = radioButton7.Text;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fotoCandidato.ImageLocation = "\\fotos\\" + radioButton8.Text.ToLower() + ".jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                voto = radioButton8.Text;
            }
        }

    }
}
