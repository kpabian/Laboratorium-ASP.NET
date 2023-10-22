using System.Text;

namespace Security_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = "aąbcdefgh";
            StringBuilder stringBuilder = new StringBuilder();
            foreach (ELetters c in S)
            {
                stringBuilder.Append((char)(c + 2));
            }
            Console.WriteLine(stringBuilder.ToString());
        }


    }
}