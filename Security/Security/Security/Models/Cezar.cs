using System.Text;
using System.Xml.Linq;

namespace Security.Models
{
    public class Cezar
    {
        public String Text { get; set; }
        public int Shift { get; set; }


        public bool IsValid()
        {
            return Text != null && Shift > 0;
        }

        public string EncryptingCezar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in Text)
            {
                int a = c + Shift;
                if(a )
                sb = sb.Append(c + Shift);

            }
            return "";
        }


    }
}
