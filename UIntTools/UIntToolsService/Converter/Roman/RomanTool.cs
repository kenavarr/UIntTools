using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UIntToolsService
{
    internal class RomanTool
    {
        private Dictionary<uint, string> _unitRomanDico;

        private Dictionary<uint, string> _decadeRomanDico;

        private Dictionary<uint, string> _hundredRomanDico;

        public RomanTool()
        {
            InitUnitRomanDico();
            InitDecadeRomanDico();
            InitHundredRomanDico();
            _thousandRomanString = "M";
        }

        public string GetRomanNumber(uint number)
        {
            uint unitNumber = 0;
            uint decadeNumber = 0;
            uint hundredNumber = 0;
            uint thousandNumber = 0;
            string stringNumber = number.ToString();

            unitNumber = uint.Parse(stringNumber.Last().ToString());
            stringNumber = stringNumber.Remove(stringNumber.Length - 1, 1);

            if (!string.IsNullOrWhiteSpace(stringNumber))
            {
                decadeNumber = uint.Parse(stringNumber.Last().ToString());
                stringNumber = stringNumber.Remove(stringNumber.Length - 1, 1);
            }

            if (!string.IsNullOrWhiteSpace(stringNumber))
            {
                hundredNumber = uint.Parse(stringNumber.Last().ToString());
                stringNumber = stringNumber.Remove(stringNumber.Length - 1, 1);
            }

            if (!string.IsNullOrWhiteSpace(stringNumber))
            {
                thousandNumber = uint.Parse(stringNumber);
            }

            return $"{GetThousandRomanNumber(thousandNumber)}{GetHundredRomanNumber(hundredNumber)}{GetDecadeRomanNumber(decadeNumber)}{GetUnitRomanNumber(unitNumber)}";
        }

        private string GetUnitRomanNumber(uint unitNumber)
        {
            return _unitRomanDico[unitNumber];
        }

        private string GetDecadeRomanNumber(uint decadeNumber)
        {
            return _decadeRomanDico[decadeNumber];
        }

        private string GetHundredRomanNumber(uint hundredNumber)
        {
            return _hundredRomanDico[hundredNumber];
        }

        private string GetThousandRomanNumber(uint thousandNumber)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < thousandNumber; i++)
            {
                sb.Append(_thousandRomanString);
            }
            return sb.ToString();
        }

        private string _thousandRomanString;

        private void InitUnitRomanDico()
        {
            _unitRomanDico = new Dictionary<uint, string>();
            _unitRomanDico.Add(0, "");
            _unitRomanDico.Add(1, "I");
            _unitRomanDico.Add(2, "II");
            _unitRomanDico.Add(3, "III");
            _unitRomanDico.Add(4, "IV");
            _unitRomanDico.Add(5, "V");
            _unitRomanDico.Add(6, "VI");
            _unitRomanDico.Add(7, "VII");
            _unitRomanDico.Add(8, "VIII");
            _unitRomanDico.Add(9, "IX");
        }

        private void InitDecadeRomanDico()
        {
            _decadeRomanDico = new Dictionary<uint, string>();
            _decadeRomanDico.Add(0, "");
            _decadeRomanDico.Add(1, "X");
            _decadeRomanDico.Add(2, "XX");
            _decadeRomanDico.Add(3, "XXX");
            _decadeRomanDico.Add(4, "XL");
            _decadeRomanDico.Add(5, "L");
            _decadeRomanDico.Add(6, "LX");
            _decadeRomanDico.Add(7, "LXX");
            _decadeRomanDico.Add(8, "LXXX");
            _decadeRomanDico.Add(9, "XC");
        }

        private void InitHundredRomanDico()
        {
            _hundredRomanDico = new Dictionary<uint, string>();
            _hundredRomanDico.Add(0, "");
            _hundredRomanDico.Add(1, "C");
            _hundredRomanDico.Add(2, "CC");
            _hundredRomanDico.Add(3, "CCC");
            _hundredRomanDico.Add(4, "CD");
            _hundredRomanDico.Add(5, "D");
            _hundredRomanDico.Add(6, "DC");
            _hundredRomanDico.Add(7, "DCC");
            _hundredRomanDico.Add(8, "DCCC");
            _hundredRomanDico.Add(9, "CM");
        }
    }
}
