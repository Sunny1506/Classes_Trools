namespace modelos;
{
public class Unidade : Registro
   {
    int id;
    string name;
   
    public void SetId (int i)
     {
        Id = i;
     }
    public string GetId()
     {
        return Id;
     }
   }
}