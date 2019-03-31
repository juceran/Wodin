using System.Text;

namespace Wodin.Comuns
{
    class RemoverCaracteres
    {
        public static string StringSemFormatacao(string str)
        {
            if (str != null)
            {
                var sb = new StringBuilder(str.Length);
                foreach (var chr in str) if (char.IsDigit(chr)) sb.Append(chr);
                return sb.ToString();
            }
            else
            {
                return str;
            }
        }
    }
}
