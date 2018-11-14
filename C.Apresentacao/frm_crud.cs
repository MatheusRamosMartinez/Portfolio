using C.Dados;
using C.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.Apresentacao
{
    public partial class frm_crud : Form
    {
        string idPessoa = "";
        bool revisador = false;
        public frm_crud()
        {
            InitializeComponent();
            Mostrar();
            timer1.Start();
        }


        public void Mostrar()
        {
            this.dataList.DataSource = NPessoa.Mostrar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            DateTime data;
            MemoryStream stream = new MemoryStream();

            if (pctFoto.Image != null)
            {
                pctFoto.Image.Save(stream, ImageFormat.Jpeg);
            }
            else
            {
                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            }

            byte[] foto = stream.ToArray();

            string resp = "";
            resp = NPessoa.InserirPessoa(
                    txtNome.Text.Trim(),
                    data = Convert.ToDateTime(this.txtNascimento.Text.Trim()),
                    txtNumeroCasa.Text.Trim(),
                    txtEndereco.Text.Trim(),
                    txtCPF.Text.Trim(),
                    txtTelefone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    foto);

            MessageBox.Show("Cadastrado com Sucesso");
            Mostrar();

            txtNome.Text = "";
            txtNascimento.Text = "";
            txtNumeroCasa.Text = "";
            txtEndereco.Text = "";
            txtCPF.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrarDados();
        }

        private void FiltrarDados()
        {
            string strSql = "select ID_PESSOA, NOME, DATA_NASCIMENTO, NUMERO_CASA, ENDERECO, CPF, TELEFONE, EMAIL from PESSOA where NOME like '%" + txtpesquisar.Text + "%'";
            SqlConnection con = new SqlConnection(Conexao.Cn);
            SqlCommand cmd = new SqlCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable PESSOA = new DataTable();
            da.Fill(PESSOA);
            dataList.DataSource = PESSOA;
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (idPessoa != "")
            {
                string resp = "";

                resp = NPessoa.Excluir(Convert.ToInt32(idPessoa));
                Mostrar();
            }
            else
            {
                MessageBox.Show("Selecione a pessoa que deve ser excluida");
            }
            

        }

        private void dataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPessoa = Convert.ToString(this.dataList.CurrentRow.Cells["ID_PESSOA"].Value);
        }

        private void editar_Click(object sender, EventArgs e)
        {
            
            frm_alterar form = new frm_alterar(idPessoa);
            form.ShowDialog();
            revisador = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (revisador == true)
            {
                Mostrar();
                revisador = false;
            }
        }

        private void frm_crud_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
    }
}
