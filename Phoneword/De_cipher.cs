using System.Text;

namespace Phoneword
{
    public static class De_cipher
    {
        public static string? ToNumber(string _phn, Button dialButton) 
        {
            try
            {
                if (!string.IsNullOrEmpty(_phn))
                {
                    string numbers = "0123456789";
                    var numToCall = new StringBuilder();
                    int count = 0;
                    foreach (var num in _phn)
                    {
                        if (numbers.Contains(num))
                        {
                            numToCall.Append(num);
                        }
                        else
                        {
                            string[] digits = { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
                            while(numToCall.Length<=10)
                            {
                                count %= 8;
                                var item = digits[count];
                                if (item.Contains(num) || (item.ToLower()).Contains(num))
                                {
                                    numToCall.Append(count+2);
                                    break;
                                }
                                ++count;
                            }
                        }
                    }
                    _phn = numToCall.ToString();
                }
                else
                    return null;
            } catch(Exception ex) 
            {
                throw new Exception("An error encounterd"+ex.Message);
            }
            dialButton.IsEnabled = true;
            return _phn;
        }
    }
}
