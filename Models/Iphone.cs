namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public string VersaoIOS { get; set; }

        public Iphone(string numero, string modelo, string imei, int memoria, string versaoIOS) : base(numero, modelo, imei, memoria)
        {
            VersaoIOS = versaoIOS;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na versão {VersaoIOS} do iPhone...");
        }
    }
}