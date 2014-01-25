using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSBitFlip.extensions
{
    public static class Extensions
    {
        public static string ToBinary(this string str)
        {
            var ascii = Encoding.ASCII.GetBytes(str);
            var bits = new BitArray(ascii);
            StringBuilder builder = new StringBuilder();
            foreach (bool bit in bits)
            {
                builder.Append(bit == true ? 1 : 0);
            }
            char[] reverse = builder.ToString().ToCharArray();
            Array.Reverse(reverse);
            return new String(reverse);
        }

        public static string BinaryToString(this string str)
        {
            byte[] bytes = new byte[str.Length / 8];
            for (int i = 0; i < str.Length / 8; i++)
            {
                string part = str.Substring(i * 8, 8);
                bytes[i] += Convert.ToByte(part, 2);
            }
            Array.Reverse(bytes);
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetString(bytes);
        }
    }
}
