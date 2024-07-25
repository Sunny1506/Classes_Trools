namespace Modelos
{
public class Vendas : Registro 
  {
    int Valormensal;
    public void SetValormensal (int Valormensal)
     {
        this.Valormensal = Valormensal;
     }
    public int GetValormensal()
     {
        return Valormensal;
     }
//---------------------------------------------------------------------------------------     
     string Relatorio;
    public void SetRelatorio (string Relatorio)
     {
        this.Relatorio = Relatorio; 
     }
    public string GetRelatorio()
     {
        return Relatorio;
     }
//----------------------------------------------------------------------------------------     
     string Cliente;
    int id;
    public void SetCliente (string Cliente)
     {
        this.Cliente = Cliente;
     }
    public string GetCliente()
     {
        return Cliente;
     }


  }     
}     