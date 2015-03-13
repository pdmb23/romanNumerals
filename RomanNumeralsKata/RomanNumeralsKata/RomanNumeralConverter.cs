using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralConverter
    {
        #region Fields
        private Dictionary<int, string> _placeHolder;
        private Dictionary<int, int> _pivot;
        #endregion

        #region Constructor
        public RomanNumeralConverter()
        {
            _placeHolder = new Dictionary<int, string>() { 
                {1, "I"}, 
                {2, "V"},
                {3, "X"},
                {4, "L"}, 
                {5, "C"}, 
                {6, "D"}, 
                {7, "M"}, 
                {8, "Q"}
            };
            _pivot = new Dictionary<int, int>() {
                {1, 2},
                {2, 4},
                {3, 6},
                {4, 8}
            };
        }
        #endregion

        #region Methods
        public string Convert(int number)
        {
            var retval = "";
            var resultHolder = "";

            var stringEquiv = number.ToString();
            var stringEquivReverse = stringEquiv.Reverse().ToArray();

            for (int count = 0; count < stringEquivReverse.Length; ++count)
            {
                var placeValue = int.Parse(stringEquivReverse[count].ToString());
                number = placeValue;
                var pivotIndex = count + 1;
                while (number > 0)
                {
                    if (number >= 4)
                    {
                        if (number == 4 || number == 9)
                        {
                            retval = _placeHolder[_pivot[pivotIndex]-1];
                        }
                        if (number == 9)
                        {
                            retval += _placeHolder[_pivot[pivotIndex] + 1];
                            break;
                        }
                        else
                        {
                            retval += _placeHolder[_pivot[pivotIndex]];
                        }

                        number = number - 5;
                    }
                    else if (number >= 1)
                    {
                        var one = _placeHolder[_pivot[pivotIndex] - 1];
                        retval = retval + one;
                        number -= 1;
                    }
                }
                resultHolder = retval + resultHolder;
                retval = "";
            }

            return resultHolder;
        }
        #endregion
    }
}
