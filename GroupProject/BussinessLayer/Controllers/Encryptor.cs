using System.Security.Cryptography;

namespace BussinessLayer.Controllers
{
    public class Encryptor
    {
        byte[] key;
        byte[] iv;

        public Encryptor()
        {
            key = new byte[16];
            iv = new byte[16];
        }

        public byte[] GenerateKey()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(key);
                return key;
            }
        }
        public byte[] GenerateIV()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(iv);
                return iv;
            }
        }

        public decimal Decrypt(byte[] cipheredtext, byte[] key, byte[] iv)
        {
            decimal salary = 0;
            using (Aes aes = Aes.Create())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(key,iv);

                using(MemoryStream memoryStream = new MemoryStream(cipheredtext))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cryptoStream))
                        {
                            string decriptedSalary = reader.ReadToEnd();

                            if (!decimal.TryParse(decriptedSalary, out salary))
                            {
                                return 0;

                            }
                        }
                    }
                }
            }
            return salary;
        }

        public byte[] Encrypt(decimal salary, byte[] key, byte[] iv)
        {
            byte[] cipheredtext;

            using (Aes aes = Aes.Create())
            {
                ICryptoTransform encryptor = aes.CreateEncryptor(key, iv);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(salary);
                        }
                        cipheredtext = memoryStream.ToArray();
                    }
                }
            }
            return cipheredtext;
        }
    }
}
