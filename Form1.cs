using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();

            ComboECchack.Items.Add("Casado");
            ComboECchack.Items.Add("Solteiro");
            ComboECchack.Items.Add("Viuvo");
            ComboECchack.Items.Add("Separado");

            ComboECchack.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach(Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == label.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }
            if(TxtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome.");
                TxtNome.Focus();
                return;
            }
            if (TxtTelefone.Text == "")
            {
                MessageBox.Show("Preencha o campo Telefone.");
                TxtTelefone.Focus();
                return;
            }

            char sexo;
            if (radioM.Checked)
            {
                sexo = 'M';
            } else if (radioF.Checked)
            {
                sexo = 'F';
            } else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Nome = TxtNome.Text;
            p.DataNascimento = TxtData.Text;
            
            p.Telefone = TxtTelefone.Text;

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

        }

         private void Listar()
        {
            lista.Items.Clear();

            foreach(Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }
    }
}
