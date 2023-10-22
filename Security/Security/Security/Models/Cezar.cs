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
            StringBuilder stringBuilder = new StringBuilder();
            foreach (ELetters c in Text)
            {
                stringBuilder.Append((char)(c + Shift));
            }
            return stringBuilder.ToString();
        }


    }
}
