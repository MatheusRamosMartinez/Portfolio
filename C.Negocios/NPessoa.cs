using C.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Negocios
{
    public class NPessoa
    {
        public static string InserirPessoa(string nome, DateTime data, string numero, string endereco, string cpf, string telefone, string email, byte[] foto)
        {
            DPessoa Obj = new DPessoa();
            Obj.Nome = nome;
            Obj.Data = data;
            Obj.Endereco = endereco;
            Obj.NumeroCasa = numero;
            Obj.Cpf = cpf;
            Obj.Telefone = telefone;
            Obj.Email = email;
            Obj.Foto = foto;
            return Obj.inserirPessoa(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPessoa().Mostrar();
        }

        public static string Excluir(int id)
        {
            DPessoa Obj = new DPessoa();
            Obj.IdPessoa = id;

            return Obj.ExcluirPessoa(Obj);
        }

        public static string Editar(string nome, int id, string endereco, DateTime data, string numero, string cpf, string telefone, string email)
        {
            DPessoa Obj = new DPessoa();
            Obj.Nome = nome;
            Obj.IdPessoa = id;
            Obj.Endereco = endereco;
            Obj.Data = data;
            Obj.NumeroCasa = numero;
            Obj.Cpf = cpf;
            Obj.Telefone = telefone;
            Obj.Email = email;
           
            return Obj.Editar(Obj);
        }

    }
}
