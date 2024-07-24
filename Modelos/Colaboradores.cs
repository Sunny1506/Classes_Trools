namespace modelos;
{
public class Colaboradores : Registro 
  {
    string NomedoColaborador;
    int64 id;
    public void SetNomedoColaborador (string NomedoColaborador)
     {
        this.NomedoColaborador = NomedoColaborador 
     }
    public string GetNomedoColaborador()
     {
        return NomedoColaborador;
     }
     string TelefonedoColaborador;
    public void SetTelefonedoColaborador (string TelefonedoColaborador)
     {
        this.TelefonedoColaborador = TelefonedoColaborador
     }
    public string GetTelefonedoColaborador()
     {
        return TelefonedoColaborador;
     }
  }
}