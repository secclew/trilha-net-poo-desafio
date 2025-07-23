namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public string VersaoAndroid { get; set; }

        public Nokia(string numero, string modelo, string imei, int memoria, string versaoAndroid) 
            : base(numero, modelo, imei, memoria)
        {
            VersaoAndroid = versaoAndroid;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na versão {VersaoAndroid} do Nokia...");
        }
    }
}