using Modelos;

namespace Controles;

public class CortadoresControle : BaseControle
{
  //----------------------------------------------------------------------------

  public CortadoresControle() : base()
  {
    NomeDaTabela = "Cortadores";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Cortadores>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Cortadores>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Cortadores>(NomeDaTabela);
    return new List<Cortadores>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Cortadores>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Cortadores cortadores)
  {
    var collection = liteDB.GetCollection<Cortadores>(NomeDaTabela);
    collection.Upsert(cortadores);
  }

  //----------------------------------------------------------------------------
}