namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _modelo;

        private string _imei;

        private int _memoria;

        public string Numero { get; set; }

        public string Modelo 
        {
            get => _modelo;
            set
            {
                _modelo = Modelo;
            } 
        }
        
        public string Imei 
        {
            get => _imei;
            set
            {
                _imei = Imei;
            }
        }

        public int Memoria
        {
            get => _memoria;
            set
            {
                _memoria = Memoria;
            }
        }

        public Smartphone(string numero, string imei, int memoria, string modelo)
        {
            Numero = numero;
            Imei = imei;
            Memoria = memoria;
            Modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}