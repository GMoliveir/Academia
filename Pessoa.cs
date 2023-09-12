using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia
{
    internal class Pessoa
    {
        private string nome;
        private string nascimento;
        private string sexo;
        private string treino;
        private string planos;
        private Bitmap img;

        public string Nome { get => nome; set => nome = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Treino { get => treino; set => treino = value; }
        public string Planos { get => planos; set => planos = value; }
        public Bitmap Img { get => img; set => img = value; }



    }


}
