using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();

        }
        private Bitmap img;
        private Pessoa p1 = null;

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = new Pessoa();
            DateTime dt;
            p1.Nome = txtNome.Text;
            dt = dateTimePicker1.Value;
            p1.Nascimento = dt.ToString("dd/MM/aaaa");
            p1.Sexo = cbSexo.Text;
            p1.Planos = groupBox1.Text;
            p1.Treino = groupBox2.Text;
            p1.Img = img;
            Program.pessoas.Add(p1);

            if (rbMensal.Checked == true)
            {
                p1.Planos = " \n Mensal ";
            }
            else if (rbAnual.Checked == true)
            {
                p1.Planos = " \n Anual ";
            }
            else if (rbCombo.Checked == true)
            {
                p1.Planos = "\n Combo 3 Anos " ;
            }

            if (cboxHipertrofia.Checked == true)
            {
                p1.Treino = "\n Hipertrofia";
            }
            else if (cboxResistencia.Checked == true)
            {
                p1.Treino += " \n Resistencia \n";
            }
            else if (cbForça.Checked == true)
            {
                p1.Treino += "\n Força \n";
            }
            else if (cbHit.Checked == true)
            {
                p1.Treino += "\n HIT \n";

            }
            else if (cbPontenciaM.Checked == true ){

                p1.Treino += " Potência ";
            }
            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(openFileDialog1.FileName);
                Img_Foto.Image = img;
            }
        }
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string SexoSelecionado = cbSexo.SelectedItem.ToString();
                if (SexoSelecionado == "Masculino")
                {

                }
                else
                {
                    SexoSelecionado = "Feminino";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          

        }
    }
}
