using DesafioPOO.Models;
namespace DesafioPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando smartphone Nokia");
            var n1 = new Nokia("61984535689", "PHE2356", "SHJ9595PJ", 64);
            n1.Ligar();
            n1.InstalarAplicativo("Telegram");

            Console.WriteLine("Iniciando smartphone Iphone");
            var ip1 = new Iphone("61984515256", "PHE5658", "XPJ8545SE", 128);
            ip1.ReceberLigacao();
            ip1.InstalarAplicativo("WhatsApp");

        }
    }
}

