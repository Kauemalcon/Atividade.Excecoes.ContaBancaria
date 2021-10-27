using System;
using System.Collections.Generic;


namespace Atividade.Exceções.ContaBancaria.Entitis.Exception
{
    class DomínioException : ApplicationException
    {
        //Cria um construtor para lançar a menssagem do metodo (ApplicationException)
        public DomínioException(string menssagem) : base (menssagem)
        {

        }
    }
}
