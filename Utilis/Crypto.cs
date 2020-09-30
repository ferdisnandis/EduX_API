using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EduX_API.Utilis
{
    public static class Crypto
    {
        public static string Criptografar(string Txt, string Salt) //Salta serve para que mesmo que pessoas usem senhais iguais seja gerado um HASH diferente
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputerHash (Hash tipo de criptográfia) - retorna um array de bytes.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Salt + Txt)); //código de Hash 

                //Conversão de array bytes para string 
                //Método serve para implentar/salvar no banco de dados      
                StringBuilder buider = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    buider.Append(bytes[i].ToString("x2"));
                }
                return buider.ToString();
            }

        }
    }
}