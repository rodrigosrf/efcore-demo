using EFCore.Demo.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Demo.Domain.Entities
{
    public class Person : BaseEntity
    {

        public string Name { get; private set; }
        public string CPF { get; private set; }
        public Person(string name, string cpf)
        {
            DomainExceptionValidation.When(String.IsNullOrEmpty(name), "Nome da pessoa é obrigatório!");
            DomainExceptionValidation.When(String.IsNullOrEmpty(cpf), "CPF da pessoa é obrigatório!");

            Name = name;
            CPF = cpf;
        }

    }
}
