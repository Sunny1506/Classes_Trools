namespace Modelos
{
   public class Vendas : Registro
   {
      public int Id { get; set; }
      public string Valor { get; set; }
      public string Relatorio { get; set; }
      public string Cliente { get; set; }
      public string Produto { get; set; }
      public string Desconto { get; set; }
      public string Data { get; set; }

   }
}