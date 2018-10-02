
namespace Interfaces.Services
{
    //Serviço que calcula taxas de aluguel de veiculo no Brasil
    class BrazilTaxService : ITaxService //Realização da interface (Subtitulo da interface)
    {
        public double Tax(double amout)
        {
            if (amout <= 100.0)
            {
                return amout * 0.2;
            }
            else
            {
                return amout * 0.15;
            }
        }
    }
}
