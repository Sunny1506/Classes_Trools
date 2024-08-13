using Modelos;

namespace Controles;

public class AcabamentistaControle : BaseControle
{
  //----------------------------------------------------------------------------

  public AcabamentistaControle() : base()
  {
    NomeDaTabela = "Acabamentista";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Acabamentista>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Acabamentista>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Acabamentista>(NomeDaTabela);
    return new List<Acabamentista>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Acabamentista>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Acabamentista acabamentista)
  {
    var collection = liteDB.GetCollection<Acabamentista>(NomeDaTabela);
    collection.Upsert(acabamentista);
  }

  //----------------------------------------------------------------------------
}