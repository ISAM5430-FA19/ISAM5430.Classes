using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Library
{
    public class Bits
    {
        private readonly string _bits;
        private readonly bool _signed;
        public Bits(string bits, bool signed)
            : this(bits)
        {
            _signed = signed;
        }

        public Bits(string bits)
        {
            _bits = bits;
        }

        public override string ToString()
        {
            return _signed ? $"-{_bits}" : _bits;
        }

        /// <summary>
        /// Exclusive Or
        /// 10101010
        /// 11110000
        /// 1011010
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Bits Xor(Bits other)
        {
            // this function is incomplete!
            char[] a = this._bits.ToCharArray();
            char[] b = other._bits.ToCharArray();
            int len = a.Length > b.Length ? a.Length : b.Length; // maximum length
            char[] c = new char[len];
            for (int i = 0; i < len; i++)
            {
                int aIndex = a.Length - 1 - i;
                int bIndex = b.Length - 1 - i;
                char bitA;
                char bitB;
                bitA = aIndex >= 0 ? a[aIndex] : '0';
                bitB = bIndex >= 0 ? b[bIndex] : '0';
                if (bitA != bitB)
                {
                    c[i] = '1';
                }
                else
                {
                    c[i] = '0';
                }
            }
            string s = new string(c);
            Bits result = new Bits(s);
            return result;
        }
    }
}
