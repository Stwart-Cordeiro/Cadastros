using System;
using System.Data;
using BDSQL;
using DAO;

namespace Negocio
{
    public class cadastroModel
    {
        DadosSQLserver dadoSqlServer = new DadosSQLserver();

        public string Insert(Cadastro cadastro)
        {
            try
            {
                dadoSqlServer.limpaparametros();
                dadoSqlServer.adicionarParametros("@Nome", cadastro.Nome);
                dadoSqlServer.adicionarParametros("@Telefone", cadastro.Telefone);
                dadoSqlServer.adicionarParametros("@Email", cadastro.Email);
                string idcadastro = dadoSqlServer.executar(CommandType.StoredProcedure, "ins_cadastro").ToString();
                return idcadastro;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }

        }

        public string Update(Cadastro cadastro)
        {
            try
            {
                dadoSqlServer.limpaparametros();
                dadoSqlServer.adicionarParametros("@ID_cliente", cadastro.IDCadastro);
                dadoSqlServer.adicionarParametros("@Nome", cadastro.Nome);
                dadoSqlServer.adicionarParametros("@Telefone",cadastro.Telefone);
                dadoSqlServer.adicionarParametros("@Email", cadastro.Email);
                string idcadastro = dadoSqlServer.executar(CommandType.StoredProcedure, "up_cadastro").ToString();
                return idcadastro;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public string Delete(Cadastro cadastro)
        {
            try
            {
                dadoSqlServer.limpaparametros();
                dadoSqlServer.adicionarParametros("@ID_cliente", cadastro.IDCadastro);
                string idcadastro = dadoSqlServer.executar(CommandType.StoredProcedure, "del_cadastro").ToString();
                return idcadastro;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public CadastroColecao consulta(string nome)
        {
            try
            {
                CadastroColecao ConsultaNome = new CadastroColecao();
                dadoSqlServer.limpaparametros();
                dadoSqlServer.adicionarParametros("@Nome", nome);
                DataTable dataTable = dadoSqlServer.executconsulta(CommandType.StoredProcedure, "Consulta");
                foreach (DataRow linha in dataTable.Rows)
                {
                    Cadastro cadastro = new Cadastro();
                    cadastro.IDCadastro = Convert.ToInt32(linha["ID_cliente"]);
                    cadastro.Nome = Convert.ToString(linha["Nome"]);
                    cadastro.Telefone = Convert.ToString(linha["Telefone"]);
                    cadastro.Email = Convert.ToString(linha["Email"]);

                    ConsultaNome.Add(cadastro);
                }
                return ConsultaNome;
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possivel Consultar o Cadastro por Nome Detalhes: "+erro.Message);
            }

        }
        
    }
}
