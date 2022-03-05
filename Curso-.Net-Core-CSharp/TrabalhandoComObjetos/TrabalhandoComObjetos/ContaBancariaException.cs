using System;
using System.Collections.Generic;
using System.Text;


namespace TrabalhandoComObjetos
{
      class ContaBancariaException : Exception
    {
        public ContaBancariaException (string mensagem)
            :base(mensagem)
        {

        }
    }
}
