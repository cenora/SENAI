using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassinoDados.Control;

namespace CassinoDados
{
    public partial class JogoDados : Form
    {
        public JogoDados()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado";
            JogoNegocios game = new JogoNegocios();
            game.lancar();
            if (game.verificar())
            {
                lblResultado.Text = "Venceu!!";
            }
            else
            {
                lblResultado.Text = "Mais um Otario!!";
            }
        }
    }
}
