using C.Dados;
using C.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C.Apresentacao
{
    public partial class frm_alterar : Form
    {
        string idMorador;
        
        Image foto = null;

        public frm_alterar(string dadoMorador)
        {
            InitializeComponent();
            idMorador = dadoMorador;
            CarregarDadosMorador();

            SqlConnection conn = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = CRUD_CURRICULO; Integrated Security = true");
            SqlCommand comand = new SqlCommand("Select FOTO from PESSOA where ID_PESSOA = " + idMorador, conn);

            conn.Open();
            SqlDataReader reader = comand.ExecuteReader();

            Image imagem = null;

            if (reader.Read())
            {
                byte[] foto = (byte[])reader["FOTO"];

                MemoryStream ms = new MemoryStream(foto);
                imagem = Image.FromStream(ms);
            }

            fotoMorador.Image = imagem;
            conn.Close();

        }



        private void CarregarDadosMorador()
        {
         
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_morador_id";
                SqlCmd.Parameters.Add("@textbuscar", System.Data.SqlDbType.NVarChar, 50);
                SqlCmd.Parameters["@textbuscar"].Value = idMorador;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                SqlDataReader leitor = SqlCmd.ExecuteReader();



               
                while (leitor.Read())
                {
                    
                    Nome.Text = (leitor["NOME"].ToString());
                    txtEndereco.Text = (leitor["ENDERECO"].ToString());
                    txtData.Text = (leitor["DATA_NASCIMENTO"].ToString());
                    txtData.Text = txtData.Text.Remove(9, txtData.Text.Length - 10);
                    txtCasa.Text = (leitor["NUMERO_CASA"].ToString());
                    txtCPF.Text = (leitor["CPF"].ToString());
                    txtEmail.Text = (leitor["EMAIL"].ToString());
                    txtTelefone.Text = (leitor["TELEFONE"].ToString());
                }

               
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            DateTime data;
            string resp = "";

            resp = NPessoa.Editar(Nome.Text, Convert.ToInt32(idMorador), txtEndereco.Text.Trim(), data = Convert.ToDateTime(this.txtData.Text.Trim()), this.txtCasa.Text.Trim(), this.txtCPF.Text.Trim(), this.txtTelefone.Text.Trim(), this.txtEmail.Text.Trim());

            this.Close();
        }
    }
}
