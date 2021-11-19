using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1ARTHUR05.Code.DTO
{
    internal class HappyDTO
    {
        private string _id;
        private string _produto;
        private string _preco;

        public string Id { get => _id; set => _id = value; }
        public string Produto { get => _produto; set => _produto = value; }
        public string Preco { get => _preco; set => _preco = value; }
    }
}
