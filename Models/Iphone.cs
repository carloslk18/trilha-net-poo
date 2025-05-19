namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Modelo, string Imei, int Memoria) : base(Numero,Modelo,Imei,Memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O APP {nomeApp} foi instalado no Iphone.");

        }
    }
}