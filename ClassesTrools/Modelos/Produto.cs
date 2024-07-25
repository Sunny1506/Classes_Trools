namespace Modelos
{
public class Produto : Registro 
  { 
    Unidade unidade;

    public Unidade GetUnidade()
    {
        return unidade; 
    }
    public void SetUnidade (Unidade u)
    {
        unidade = u;
    }
//---------------------------------------------------------------------------------------
    string NomedoProduto;
    int id;
    public void SetNomedoProduto (string NomedoProduto)
     {
        this.NomedoProduto = NomedoProduto;
     }
    public string GetNomedoProduto()
     {
        return NomedoProduto;
 //----------------------------------------------------------------------------------------
     }
     string Nome;
    public void SetNome (string Nome)
     {
        this.Nome = Nome;
     }
    public string GetNome()
     {
        return Nome;
     }
//---------------------------------------------------------------------------------------

     //preciso verificar qual ficará correto, ou o acima, verifiquei, posso usar unidade
     // int Quantidade;
    //public void SetQuantidade (int Quantidade)
     //{
        //this.Quantidade = Quantidade 
     //}
    //public int GetQuantidade()
     //{
        //return Quantidade;
    // }

//------------------------------------------------------------------------------------------
      string Tamanho;
    public void SetTamanho (string Tamanho)
     {
        this.Tamanho = Tamanho;
     }
    public string GetTamanho()
     {
        return Tamanho;
     }   
//--------------------------------------------------------------------------------------------- 
      string Cor;
    public void SetCor (string Cor)
     {
        this.Cor = Cor; 
     }
    public string GetCor()
     {
        return Cor;
     }
//----------------------------------------------------------------------------------------------
      int Mediadiaria;
    public void SetMediadiaria (int Mediadiaria)
     {
        this.Mediadiaria = Mediadiaria;
     }
    public int GetMediadiaria()
     {
        return Mediadiaria;
     }
  }   
}