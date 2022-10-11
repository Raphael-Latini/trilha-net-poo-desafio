namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
            public override void InstalarAplicativo(string nomeApp)
        {
            Console.Write("Instalnado: "+ nomeApp);
        }
    }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}