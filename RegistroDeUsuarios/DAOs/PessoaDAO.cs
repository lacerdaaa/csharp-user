using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RegistroDeUsuarios.Infra.DataBase;
using RegistroDeUsuarios.Models;

namespace RegistroDeUsuarios.DAOs
{
    public class PessoaDAO
    {
        private ConnectDatabase dbConnection;

        public PessoaDAO()
        {
            try { 
                dbConnection = new ConnectDatabase();
            } catch(Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        public void Create(Pessoa pessoa)
        {
            string Sql = "INSERT INTO pessoas" + "(name, email, phone) VALUES (@name, @email, @telefone)";

            try
            {
                var cmd = dbConnection.Connect().CreateCommand();
            }
            catch (Exception e) { }
        }
    }
}
