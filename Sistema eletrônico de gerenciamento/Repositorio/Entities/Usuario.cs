using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Usuario
    {
        protected string error;
        public string Nome { get; set; }
        public string Senha {  get; private set; }

        public Usuario(string nome, string senha) 
        {
            try
            {
                if (nome != "" || senha != "")
                {
                    Nome = nome;
                    Senha = senha;
                }
            }
            catch (Exception e) 
            {
                error = e.Message;
            }
          
            

        }
    }
}
