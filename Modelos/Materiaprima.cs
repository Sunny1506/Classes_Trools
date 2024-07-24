namespace modelos;
{
public class Materiaprima : Registro
 {
    //aqui eu coloquei a unidade de medida da matéria prima
    Unidade unidade;

    public Unidade GetUnidade()
    {
        return unidade; 
    }
    public void SetUnidade (Unidade u)
    {
        unidade = u;
    }
    //--------------------------------------------------------------------------------------
    string Material;
   
    public void SetMaterial (string Material)
     {
        this.Material = Material
     }
    public string GetMaterial()
     {
        return Material;
     }
     //----------------------------------------------------------------------------------------  

 }
}