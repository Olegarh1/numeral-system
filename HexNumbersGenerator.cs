using System;

namespace GuidUsage
{
    class HexNumbersGenerator
    {
        private string hex128bit;
        private string hexByte;
        private string hexWord;
        private string hexWord2;

        public string Hex128bit { get => hex128bit; set => hex128bit = value; }
        public string HexByte { get => hexByte; set => hexByte = value; }
        public string HexWord { get => hexWord; set => hexWord = value; }
        public string HexWord2 { get => hexWord2; set => hexWord2 = value; }

        public HexNumbersGenerator()
        {
            this.Hex128bit = GuidGenerator();
            this.HexByte = hex128bit.Substring(hex128bit.Length - 2);
            this.HexWord = hex128bit.Substring(hex128bit.Length - 6, 4);
            this.hexWord2 = hex128bit.Substring(hex128bit.Length - 10, 4);
        }

        private string GuidGenerator()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString().ToUpper();
        }

        public override string ToString()
        {
            return "\nHEX (128 BIT LENGTH): " + hex128bit
                + "\nHEX ( BYTE   LENGTH): " + hexByte
                + "\nHEX ( WORD1   LENGTH): " + hexWord
                + "\nHEX ( WORD2   LENGTH): " + hexWord2;
        }
    }
}
