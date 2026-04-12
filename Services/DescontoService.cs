namespace AgenciaTurismo.Services
{
    public delegate decimal CalculateDelegate(decimal preco);

    public class DescontoService
    {
        public decimal AplicarDesconto(decimal preco)
        {
            return preco * 0.9m; 
        }
    }
}