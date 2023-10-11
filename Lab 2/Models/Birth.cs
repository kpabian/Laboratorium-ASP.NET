namespace Lab_2.Models
{
    public class Birth
    {
        public String Name { get; set; }
        public DateTime Date { get; set; }


        public bool IsValid()
        {
            return Name != null && Date < DateTime.Now;
        }

        public int Birth1()
        {
            return (int)(DateTime.Now.Year - Date.Year);
        }


    }
}
