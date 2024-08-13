using Modelos;

namespace Controles;

public class CosturaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CosturaControle() : base()
  {
    NomeDaTabela = "Costura";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Costura? LerTodos()
  {
    var tabela = liteDB.GetCollection<Costura>(NomeDaTabela);
    return new List<Costura>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Costura costura)
  {
    var collection = liteDB.GetCollection<Costura>(NomeDaTabela);
    collection.Upsert(costura);
  }

  //----------------------------------------------------------------------------
}