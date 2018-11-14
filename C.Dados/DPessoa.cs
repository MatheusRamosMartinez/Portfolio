using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Dados
{
    public class DPessoa
    {
        private int _idpessoa;
        private string _nome;
        private DateTime _data;
        private string _cnpj;
        private string _cpf;
        private string _telefone;
        private string _email;
        private byte[] _foto;
        private string _endereco;
        private string _numero;

        public DPessoa() { }

        public DPessoa(int idpessoa, string nome, DateTime data, string cnpj, string cpf, string telefone, string email, byte[] foto, string endereco, string numero)
        {
            _idpessoa = idpessoa;
            _nome = nome;
            _data = data;
            _cnpj = cnpj;
            _cpf = cpf;
            _telefone = telefone;
            _email = email;
            _foto = foto;
            _endereco = endereco;
            _numero = numero;
        }

        public int IdPessoa
        {
            get
            {
                return _idpessoa;
            }

            set
            {
                _idpessoa = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }



        public string NumeroCasa
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                _cpf = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _telefone;
            }

            set
            {
                _telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        public string Endereco
        {
            get
            {
                return _endereco;
            }

            set
            {
                _endereco = value;
            }
        }

        public string Cnjp
        {
            get
            {
                return _cnpj;
            }

            set
            {
                _cnpj= value;
            }
        }

    

        public byte[] Foto
        {
            get
            {
                return _foto;
            }

            set
            {
                _foto = value;
            }
        }


        public string inserirPessoa(DPessoa Pessoa_Apresentacao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPINSERIR_PESSOA";
                SqlCmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter ParIdPessoa = new SqlParameter();
                ParIdPessoa.ParameterName = "@ID_PESSOA";
                ParIdPessoa.SqlDbType = System.Data.SqlDbType.Int;
                ParIdPessoa.Direction = System.Data.ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPessoa);

                SqlParameter ParNomePessoa = new SqlParameter();
                ParNomePessoa.ParameterName = "@NOME";
                ParNomePessoa.SqlDbType = System.Data.SqlDbType.VarChar;
                ParNomePessoa.Size = 50;
                ParNomePessoa.Value = Pessoa_Apresentacao.Nome;
                SqlCmd.Parameters.Add(ParNomePessoa);

                SqlParameter ParDataPessoa = new SqlParameter();
                ParDataPessoa.ParameterName = "@DATA_NASCIMENTO";
                ParDataPessoa.SqlDbType = System.Data.SqlDbType.Date;
                ParDataPessoa.Size = 50;
                ParDataPessoa.Value = Pessoa_Apresentacao.Data;
                SqlCmd.Parameters.Add(ParDataPessoa);

                SqlParameter ParEnderecoPessoa = new SqlParameter();
                ParEnderecoPessoa.ParameterName = "@ENDERECO";
                ParEnderecoPessoa.SqlDbType = System.Data.SqlDbType.VarChar;
                ParEnderecoPessoa.Size = 45;
                ParEnderecoPessoa.Value = Pessoa_Apresentacao.Endereco;
                SqlCmd.Parameters.Add(ParEnderecoPessoa);

                SqlParameter ParNumeroPessoa = new SqlParameter();
                ParNumeroPessoa.ParameterName = "@NUMERO_CASA";
                ParNumeroPessoa.SqlDbType = System.Data.SqlDbType.VarChar;
                ParNumeroPessoa.Size = 4;
                ParNumeroPessoa.Value = Pessoa_Apresentacao.NumeroCasa;
                SqlCmd.Parameters.Add(ParNumeroPessoa);

                SqlParameter ParCPFPessoa = new SqlParameter();
                ParCPFPessoa.ParameterName = "@CPF";
                ParCPFPessoa.SqlDbType = System.Data.SqlDbType.VarChar;
                ParCPFPessoa.Size = 45;
                ParCPFPessoa.Value = Pessoa_Apresentacao.Cpf;
                SqlCmd.Parameters.Add(ParCPFPessoa);

                SqlParameter ParTelefonePessoa = new SqlParameter();
                ParTelefonePessoa.ParameterName = "@TELEFONE";
                ParTelefonePessoa.SqlDbType = System.Data.SqlDbType.VarChar;
                ParTelefonePessoa.Size = 45;
                ParTelefonePessoa.Value = Pessoa_Apresentacao.Telefone;
                SqlCmd.Parameters.Add(ParTelefonePessoa);

                SqlParameter ParEmailPessoa = new SqlParameter();
                ParEmailPessoa.ParameterName = "@EMAIL";
                ParEmailPessoa.SqlDbType = System.Data.SqlDbType.VarChar;
                ParEmailPessoa.Size = 45;
                ParEmailPessoa.Value = Pessoa_Apresentacao.Email;
                SqlCmd.Parameters.Add(ParEmailPessoa);

                SqlParameter ParFotoPessoa = new SqlParameter();
                ParFotoPessoa.ParameterName = "@FOTO";
                ParFotoPessoa.SqlDbType = System.Data.SqlDbType.Binary;
                ParFotoPessoa.Value = Pessoa_Apresentacao.Foto;
                SqlCmd.Parameters.Add(ParFotoPessoa);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "ok" : "resgistro";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == System.Data.ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("PESSOA");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPBUSCAR_PESSOA";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public string ExcluirPessoa(DPessoa Pessoa_Apresentacao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletarPessoa_apresentacao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Pessoa_Apresentacao.IdPessoa;
                SqlCmd.Parameters.Add(ParId);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi feita";


            }
            catch (Exception ex) { resp = ex.Message; }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        public string Editar(DPessoa Pessoa_Apresentacao)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SPALTERAR_PESSOA";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@NOME";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 256;
                ParNome.Value = Pessoa_Apresentacao.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParIdPessoa = new SqlParameter();
                ParIdPessoa.ParameterName = "@ID_PESSOA";
                ParIdPessoa.SqlDbType = SqlDbType.Int;
                ParIdPessoa.Value = Pessoa_Apresentacao.IdPessoa;
                SqlCmd.Parameters.Add(ParIdPessoa);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@ENDERECO";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 256;
                ParEndereco.Value = Pessoa_Apresentacao.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@DATA_NASCIMENTO";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Size = 256;
                ParData.Value = Pessoa_Apresentacao.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParCasa = new SqlParameter();
                ParCasa.ParameterName = "@NUMERO_CASA";
                ParCasa.SqlDbType = SqlDbType.VarChar;
                ParCasa.Size = 256;
                ParCasa.Value = Pessoa_Apresentacao.NumeroCasa;
                SqlCmd.Parameters.Add(ParCasa);

                SqlParameter ParCPF = new SqlParameter();
                ParCPF.ParameterName = "@CPF";
                ParCPF.SqlDbType = SqlDbType.VarChar;
                ParCPF.Size = 256;
                ParCPF.Value = Pessoa_Apresentacao.Cpf;
                SqlCmd.Parameters.Add(ParCPF);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@TELEFONE";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 256;
                ParTelefone.Value = Pessoa_Apresentacao.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@EMAIL";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 256;
                ParEmail.Value = Pessoa_Apresentacao.Email;
                SqlCmd.Parameters.Add(ParEmail);

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" :
                "A edição não foi feita";


            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return resp;
        }


    }



}

