namespace Modelos
{
public class Metadiaria : Registro
  {
    int Meta;
   
    public void SetMetadiaria (int Metadiaria)
     {
        this.Meta = Metadiaria;
     }
    public int GetMetadiaria()
     {
        return Meta;
     }
  }     
}