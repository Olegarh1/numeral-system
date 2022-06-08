using System;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace GuidUsage
{
    public class NumericalSystemUtils
    {
        public string BinaryToHex(string binary)
        {
            return Convert.ToInt32(binary, 2).ToString("X"); ;
        }

        //Task 1
        public string HexToDecimal(string hex)
        {
            return Convert.ToInt64(hex, 16).ToString();
        }

        //Task 2
        public string HexToBinary(string hex)
        {
            return String.Join(String.Empty,
  hex.Select(
    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
  )
);
        }

        //Task3
        public string ReverseBits(string hex)
        {
            return BinaryToHex(ReverseString(HexToBinary(hex)));
        }

        //Task4
        public string SumHexNumbers(string hex1, string hex2)
        {
            var modifiedHex = MakeHexValuesTheSameLength(hex1, hex2);
            hex1 = modifiedHex.Item1;
            hex2 = modifiedHex.Item2;

            BigInteger number1 = BigInteger.Parse(hex1, NumberStyles.HexNumber);
            BigInteger number2 = BigInteger.Parse(hex2, NumberStyles.HexNumber);
            BigInteger sum = BigInteger.Add(number1, number2);
            return sum.ToString("X");
        }

        //Task5
        public string SubtructHexNumbers(string hex1, string hex2)
        {
            var modifiedHex = MakeHexValuesTheSameLength(hex1, hex2);
            hex1 = modifiedHex.Item1;
            hex2 = modifiedHex.Item2;

            BigInteger number1 = BigInteger.Parse(hex1, NumberStyles.HexNumber);
            BigInteger number2 = BigInteger.Parse(hex2, NumberStyles.HexNumber);
            BigInteger sum = BigInteger.Subtract(number1, number2);
            return sum.ToString("X");
        }

        //Task6
        public string HexSignedToDecimal(string hex)
        {
            string binarySigned = HexToBinary(hex);
            string dec = BinaryToDecimal(binarySigned.Substring(1));
            if (binarySigned.StartsWith('1'))
            {
                return "-" + dec;
            }
            else
            {
                return dec;
            }
        }

        //Task7
        public string HexChangeSign(string hex)
        {
            string binarySigned = HexToBinary(hex);
            string oppositeSignBinary = "";
            if (binarySigned.StartsWith('1'))
            {
                oppositeSignBinary += '0' + binarySigned.Substring(1);
            }
            else
            {
                oppositeSignBinary += '1' + binarySigned.Substring(1);
            }
            return BinaryToHex(oppositeSignBinary);
        }

        //Task8
        public string HexAdditionalToDecimal(string hex)
        {
            string binary = HexToBinary(hex);
            binary = FromAdditionalToStraight(binary);
            string dec = BinaryToDecimal(binary.Substring(1));
            if (binary.StartsWith('1'))
            {
                return "-" + dec;
            }
            else
            {
                return dec;
            }
        }

        //Task 9
        public string HexAdditionalChangeSign(string hex)
        {
            return SumHexNumbers(SubtructHexNumbers("FF", hex), "1");
        }   

        private static string BinaryToDecimal(string binarySigned)
        {
            return Convert.ToInt32(binarySigned, 2).ToString();
        }

        private string ReverseString(string str)
        {
            char[] charArray = str.Reverse().ToArray();
            string reversedStr = "";

            for (int i = 0; i < charArray.Length; i++)
            {
                reversedStr += charArray[i];
            }
            return reversedStr;
        }

        private Tuple<string, string> MakeHexValuesTheSameLength(string hex1, string hex2)
        {
            var sbHex = new StringBuilder();
            if (hex1.Length > hex2.Length)
            {
                for (int i = 0; i < hex1.Length - hex2.Length; i++)
                {
                    sbHex.Append("0");
                }
                hex2 = sbHex.Append(hex2).ToString();
            }
            else if (hex1.Length < hex2.Length)
            {
                for (int i = 0; i < hex2.Length - hex1.Length; i++)
                {
                    sbHex.Append("0");
                }
                hex1 = sbHex.Append(hex1).ToString();
            }
            return Tuple.Create(hex1, hex2);
        }

        private string FromAdditionalToStraight(string binary)
        {
            if (binary.StartsWith('1'))
            {
                bool hasSub = false;
                for (int i = binary.Length - 1; i >= 0; i--)
                {
                    if (binary[i] == '1' && !hasSub)
                    {
                        binary = binary.Remove(i, 1).Insert(i, "0");
                        hasSub = true;
                    }
                }
                for (int i = 1; i < binary.Length; i++)
                {
                    if (binary[i] == '1')
                    {
                        binary = binary.Remove(i, 1).Insert(i, "0");
                    }
                    else
                    {
                        binary = binary.Remove(i, 1).Insert(i, "1");
                    }
                }
            }
            return binary;
        }
    }
}
