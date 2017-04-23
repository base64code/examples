using System;
using System.Text;

namespace Base64convert.Example
{
    public class Base64Sample {

        static void Main(string[] args)
        {
            string strB64Encoded = "SXQncyBsdW5jaCB0aW1l";
            byte[] data = Convert.FromBase64String(strB64Encoded);
            string strB64Decoded = UTF8Encoding.GetString(data);
            Console.WriteLine(strB64Decoded);

            string strB64Decoded = "It's lunch time";
            byte[] data = UTF8Encoding.GetBytes(strB64Decoded);
            string strB64Encoded = Convert.ToBase64String(data);
            Console.WriteLine(strB64Encoded);
        }
    }
}