using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SistemaLogin
{
    internal class ValidacaoLogin
    {

        public bool Validar(string usuario, string senha) {
            return usuario == "admin" && senha == "1234";
                }
    }
}
