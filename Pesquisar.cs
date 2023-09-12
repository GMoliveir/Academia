using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            foreach (var pessoa in Program.pessoas)
            {
                if (pessoa.Nome == txtPesquisa.Text)
                {
                    lbResultado.Items.Add(pessoa.Nome + pessoa.Nascimento + " \n  - " + pessoa.Sexo + " \n  - " + pessoa.Planos + " \n - "+ pessoa.Treino);
                    pbPesquisa. Image = pessoa.Img;
                }
            }
        }

        private void lbResultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }   
}
