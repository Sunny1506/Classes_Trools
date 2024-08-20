
using Modelos;

namespace Controles;

public class UnidadeControle : BaseControle
{
  //----------------------------------------------------------------------------

  public UnidadeControle() : base()
  {
    NomeDaTabela = "Unidade";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Unidade>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return new List<Unidade>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Unidade unidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Upsert(unidade);
  }

  //----------------------------------------------------------------------------
}
