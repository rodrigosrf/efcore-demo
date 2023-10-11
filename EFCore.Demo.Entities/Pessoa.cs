using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Demo.Entities
{
    public class Pessoa : EntidadeBase
    {

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public Pessoa(int id, string nome, string cpf) : base(id)
        {
            Nome = nome;
            CPF = cpf;
        }

        public Pessoa() {}

    }

}
