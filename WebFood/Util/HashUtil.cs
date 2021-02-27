using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace WebFood.Util
{
    /// <summary>
    /// Classe utilitaria para hash
    /// </summary>
    public class HashUtil
    {
        private const int SaltSize = 32; // 256 bit 
        private const int KeySize = 64; // 512 bit
        private const int Iterations = 10000; 

       
        /// <summary>
        /// Gera um novo hash e salt para uma string e um determinado numero de iteraçoes (padrão 10.000)
        /// </summary>
        /// <param name="password"></param>
        /// <param name="nIteractions"></param>
        /// <returns></returns>
        public static Data GenerateHashSalt(string password, int nIteractions=Iterations) 
        {
            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            
            return new Data()
            {
                Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: nIteractions,
                numBytesRequested: KeySize)),
                Salt = salt.ToString(),
                Iterations= nIteractions
            };
        }
        /// <summary>
        /// Representa o hash de uma senha com seu salt dado um numero de iterações
        /// </summary>
        public class Data 
        {
            /// <summary>
            /// Hash resultante da string de entrada
            /// </summary>
            public string Password { get; set; }
            /// <summary>
            /// salt gerado para o hash
            /// </summary>
            public string Salt { get; set; }
            /// <summary>
            /// Numero e iterações utilizadas para gerar o hash
            /// </summary>
            public int Iterations { get; set; }
        }


    }
}
