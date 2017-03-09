using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace international_reference_number
{
    class ReferenceNumber
    {
        private string _input, _output, _fnum;
        private decimal _number, _remainder;
        private bool _checkoutput;
        private int[] _rplcarray = new int[6] { 2,7,1,5, 0 ,0 };
        private int i = 0;
        public ReferenceNumber()
        {
  
        }

        public ReferenceNumber(string input)
        {
            _input = input;
        }

        public string Output
        {
            get { return _output; }
        }

        public string CreateReferenceNumber()
        {
            int[] procarray = new int[_input.Length + _rplcarray.Length];

            i = 0;
            for (int c = 0; c < _input.Length; c++)
            {
                int.TryParse(_input[c].ToString(), out procarray[i]);
                i++;
            }
            for (int c = 0; c < _rplcarray.Length; c++)
            {
                int.TryParse(_rplcarray[c].ToString(), out procarray[i]);
                i++;
            }
            decimal.TryParse(string.Join("", procarray), out _number);
            _remainder = (_number % 97);
            _number = 98 - _remainder;
            _output = "RF" + _number + _input;
            return _output;
        }

        public bool CheckReferenceNumber(string s)
        {
            int[] procarray = new int[s.Length+2];

            i = 0;
            for (int c = 4; c < s.Length; c++)
            {

                int.TryParse(s[c].ToString(), out procarray[i]);
                i++;
            }
            for (int c = 0; c < 4; c++)
            {
                procarray[i] = _rplcarray[c] ;
                i++;
            }
            for (int c = 2; c < 4; c++)
            {
                int.TryParse(s[c].ToString(), out procarray[i]);
                i++;
            }
            decimal.TryParse(string.Join("", procarray), out _number);
            _remainder  = (_number % 97);
            if(_remainder == 1)
            {
                _checkoutput = true;
            }
            else
            {
                _checkoutput = false;
            }

            return _checkoutput;
        }



    }
}
