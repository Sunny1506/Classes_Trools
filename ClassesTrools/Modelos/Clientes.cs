namespace Modelos
{
   public class Clientes : Registro
   {
      public int Id { get; set; }
      public string Nome { get; set; }
      public string Telefone { get; set; }
      public string CNPJ { get; set; }
      public string Endereço { get; set; }

      public string Cidade { get; set; }

      public string Estado { get; set; }

      public string Email { get; set; }

      public string CEP { get; set; }



   }
}