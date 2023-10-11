using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Demo.Domain.Validations
{
    public class DomainExceptionValidation : Exception
    {

        public DomainExceptionValidation(string errorMessage) : base(errorMessage) { }

        public static void When(bool errorValidate, string message)
        {
            if (errorValidate) throw new DomainExceptionValidation(message);
        }

    }
}
