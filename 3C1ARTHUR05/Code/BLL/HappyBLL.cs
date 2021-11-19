using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1ARTHUR05.Code.DTO;
using _3C1ARTHUR05.Code.DAL;
using System.Data;

namespace _3C1ARTHUR05.Code.BLL
{
    internal class HappyBLL
    {
        Banco bd = new Banco();
        string tabela = "rihappy";



        public void Inserir(HappyDTO happyDTO)
        {

            string inserir = $"insert into {tabela} values('{ happyDTO.Id}','{ happyDTO.Produto}','{ happyDTO.Preco}')";
            bd.ExecutarComando(inserir);
        }


        public void Excluir(HappyDTO happyDTO)
        {
            string excluir = $"delete from {tabela} where id = '{happyDTO.Id}';";
            bd.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela}; ";
            return bd.ExecutarConsulta(sql);
        }
        public void Editar(HappyDTO happyDTO)
        {
            string alterar = $"update {tabela} set produto = '{happyDTO.Produto}', preco = '{happyDTO.Preco}' where id = '{happyDTO.Id}';";
            bd.ExecutarComando(alterar);
        }
    }
}
