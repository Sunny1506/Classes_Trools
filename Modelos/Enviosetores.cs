namespace modelos;
{


public class Enviosetores : Registro
 {
    int Envio;
    int64 id;
   
    public void SetEnvio (int Envio)
     {
        this.Envio = Envio
     }
    public int Envio()
     {
        return Envio;
     }
 }     

}