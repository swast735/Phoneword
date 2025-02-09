using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phoneword;

namespace Phoneword
{
    public static class De_cipher
    {
        public static string? ToNumber(string _phn, Button dialButton) 
        { 
            if (!string.IsNullOrEmpty(_phn)) 
            {
                string numbers = "0123456789";
                var numToCall = new StringBuilder();
                foreach(var num in _phn.Split())
                {
                    if(numbers.Contains(num))
                    {
                        numToCall.Append(num);
                    }
                    else
                    {
                        string[] digits = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
                    }
                }
            }
            else
                return null;
            return _phn;
        }
    }
}
