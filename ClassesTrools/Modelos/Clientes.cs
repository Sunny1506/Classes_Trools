namespace Modelos
{
public class Clientes : Registro 
  {
    string NomedoCliente;
    int id;
    public void SetNomedoCliente (string NomedoCliente)
     {
        this.NomedoCliente = NomedoCliente; 
     }
    public string GetNomedoCliente()
     {
        return NomedoCliente;
     }
// ------------------------------------------------------------------------------     
    string Telefone;
    public void SetTelefone (string Telefone)
     {
        this.Telefone = Telefone;
     }
    public string GetTelefone()
     {
        return Telefone;
     }
// -------------------------------------------------------------------------------
      string CNPJ;
    public void SetCNPJ (string CNPJ)
     {
        this.CNPJ = CNPJ;
     }
    public string GetCNPJ()
     {
        return CNPJ;
     }
//----------------------------------------------------------------------------------
      string Endereço;
    public void SetEndereço (string Endereço)
     {
        this.Endereço = Endereço;
     }
    public string GetEndereço()
     {
        return Endereço;
     }
//------------------------------------------------------------------------------------
     string Cidade;
    public void SetCidade (string Cidade)
     {
        this.Cidade = Cidade;
     }
    public string GetCidade()
     {
        return Cidade;
     }
//-----------------------------------------------------------------------------------------
     string Estado;
    public void SetEstado (string Estado)
     {
        this.Estado = Estado;
     }
    public string GetEstado()
     {
        return Estado;
     }
//------------------------------------------------------------------------------------------     
     string Email;
    public void SetEmail (string Email)
     {
        this.Email = Email;
     }
    public string GetEmail()
     {
        return Email;
     }
//------------------------------------------------------------------------------------------     
      string CEP;
    public void SetCEP (string CEP)
     {
        this.CEP = CEP;
     }
    public string GetCEP()
     {
        return CEP;
     }
     

  }
}