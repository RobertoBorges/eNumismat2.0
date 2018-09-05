using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace eNumismat2._0.Classes
{
    class GetHash
    {
        //=============================================================================================================================
        public string Calculate(string input)
        {
            byte[] value = Encoding.UTF8.GetBytes(input);
            SHA256Managed sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(value);

            var HashResult = new StringBuilder();

            foreach (byte theByte in hash)
            {
                HashResult.Append(theByte.ToString("x2"));
            }
            return HashResult.ToString();
        }
    }
}
