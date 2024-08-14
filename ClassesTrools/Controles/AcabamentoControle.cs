using Modelos;

namespace Controles;

public class AcabamentoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public AcabamentoControle() : base()
  {
    NomeDaTabela = "Acabamentista";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Acabamento>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Acabamento>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Acabamento>(NomeDaTabela);
    return new List<Acabamento>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Acabamento>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Acabamento acabamento)
  {
    var collection = liteDB.GetCollection<Acabamento>(NomeDaTabela);
    collection.Upsert(acabamento);
  }

  //----------------------------------------------------------------------------
}