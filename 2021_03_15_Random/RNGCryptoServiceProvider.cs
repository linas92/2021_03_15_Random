using System;

namespace _2021_03_15_Random
{
    internal class RNGCryptoServiceProvider
    {
        public RNGCryptoServiceProvider()
        {
        }

        public static implicit operator System.Security.Cryptography.RNGCryptoServiceProvider(RNGCryptoServiceProvider v)
        {
            throw new NotImplementedException();
        }
    }
}